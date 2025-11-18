namespace Project1
{
    public static class Helper
    {
        private static int IdCounter = 1;
        
        public static int GenerateId()
        {
           return IdCounter++;
        }
    }
}
