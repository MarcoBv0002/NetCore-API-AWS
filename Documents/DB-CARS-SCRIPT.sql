CREATE DATABASE db_cars
GO

USE db_cars
GO

CREATE TABLE Cars (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Brand NVARCHAR(50) NOT NULL,
    Model NVARCHAR(50) NOT NULL,
    Year INT NOT NULL,
    Color NVARCHAR(50),
    Price DECIMAL(18,2) NOT NULL
);
GO


INSERT INTO Cars (Brand, Model, Year, Color, Price) VALUES
('Toyota', 'Corolla', 2019, 'Blue', 15000.00),
('Honda', 'Civic', 2018, 'Red', 16000.00),
('Ford', 'Mustang', 2020, 'Black', 35000.00),
('Chevrolet', 'Camaro', 2017, 'Yellow', 30000.00),
('Nissan', 'Altima', 2019, 'Silver', 20000.00),
('BMW', '3 Series', 2019, 'White', 40000.00),
('Audi', 'A4', 2021, 'Gray', 45000.00),
('Mercedes-Benz', 'C-Class', 2020, 'Black', 50000.00),
('Volkswagen', 'Jetta', 2019, 'Blue', 18000.00),
('Tesla', 'Model 3', 2021, 'Red', 55000.00),
('Subaru', 'Outback', 2018, 'Green', 25000.00),
('Hyundai', 'Elantra', 2020, 'Silver', 20000.00),
('Kia', 'Sorento', 2019, 'White', 28000.00),
('Mazda', 'CX-5', 2020, 'Black', 32000.00),
('Lexus', 'RX', 2021, 'Blue', 60000.00),
('Jeep', 'Wrangler', 2017, 'Gray', 35000.00),
('Volvo', 'XC60', 2019, 'Red', 45000.00),
('Porsche', '911', 2020, 'Silver', 120000.00),
('Infiniti', 'Q50', 2018, 'Black', 30000.00),
('Land Rover', 'Range Rover', 2021, 'White', 90000.00);
GO