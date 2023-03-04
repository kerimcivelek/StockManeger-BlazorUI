namespace WebUI.PBYS.Shared.Utilities
{
    public class BaseException
    {
        public static void ResponseException(string exception)
        {
            if (exception != null)
            {
                throw new Exception(exception);
            }
        }
    }
}
