namespace Calculations
{
    public class Calculator
    {
        public static int SaltedSum(int first, int second)
        {
            var salt = 10;       
            salt++;
            
            return first + second + salt;
        }
    }
}