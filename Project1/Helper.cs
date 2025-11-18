namespace Project1
{
    public static class Helper
    {
        public static int IdCounter = 1;
        
        public static int GenerateId()
        {
           return IdCounter++;
        }
    }
}
