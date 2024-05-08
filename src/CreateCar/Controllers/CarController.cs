using CreateCar.DTO;
using CreateCar.Entities;
using CreateCar.Services;
using CreateCar.Utils;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using System;

namespace CreateCar.Controllers
{
    [ApiController]
    public class CarController(CarService carService) : ControllerBase
    {
        private readonly CarService _carService = carService;
        private readonly VerifyResponses _verifyResponses = new();

        [HttpGet()]
        [Route("GetCars")]
        public void GetCars()
        {
            List<Car> Cars = _carService.GetAll();
            if (Cars.Count == 0) SendResponses.SendNoContentResponse(HttpContext);
            else SendResponses.SendOkResponse(HttpContext, Cars, "Success");
        }
        [Route("GetCar")]
        [HttpGet("GetCar/{id}")]
        public void GetCar(int id)
        {
            if (id < 1)
            {
                SendResponses.SendBadRequestResponse(HttpContext);
            }
            else _verifyResponses.ExecuteAction(HttpContext, () =>
            {
                Car car = _carService.GetCarById(id);
                if (car == null) SendResponses.SendNotFoundResponse(HttpContext, "Car not found");
                else SendResponses.SendOkResponse(HttpContext, car, "Car found!");
            });
        }

        [Route("CreateCar")]
        [HttpPost("CreateCar")]
        public void CreateCar(CarDTO carDTO)
        {
            if (carDTO == null || !CarDTO.IsValid(carDTO)) SendResponses.SendBadRequestResponse(HttpContext);
            else _verifyResponses.ExecuteAction(HttpContext, () =>
            {
                string message = _carService.AddCar(carDTO);
                SendResponses.SendOkResponse(HttpContext, "", message);
            });
        }

        [Route("UpdateCar")]
        [HttpPut("UpdateCar/{id}")]
        public void UpdateCar(int id, [FromBody] CarDTO carDTO)
        {
            if (id < 1 || carDTO == null || !CarDTO.IsValid(carDTO)) SendResponses.SendBadRequestResponse(HttpContext);
            else _verifyResponses.ExecuteAction(HttpContext, () =>
            {
                string message = _carService.UpdateCar(id, carDTO!);
                SendResponses.SendOkResponse(HttpContext, "", message);
            });
        }

        [Route("DeleteCar")]
        [HttpDelete("DeleteCar/{id}")]
        public void DeleteCar(int id)
        {
            if (id < 1) SendResponses.SendBadRequestResponse(HttpContext);
            else _verifyResponses.ExecuteAction(HttpContext, () =>
            {
                string message = _carService.DeleteCar(id);
                SendResponses.SendOkResponse(HttpContext, "", message);
            });
        }
    }
}