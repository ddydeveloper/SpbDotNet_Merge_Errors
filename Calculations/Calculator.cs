namespace Calculations
{
    public class Calculator
    {
        public static int SaltedSum(int first, int second)
        {
            var salt = 10;       
            salt++;
            salt++;
            salt += 2;
            salt += 2;
            
            return first + second + salt;
        }
    }
}