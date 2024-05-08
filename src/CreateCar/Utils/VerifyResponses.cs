namespace CreateCar.Utils
{
    public class VerifyResponses
    {
        public void ExecuteAction(HttpContext context, Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                SendResponses.SendInternalServerErrorResponse(context, ex.Message);
            }
        }
    }
}
