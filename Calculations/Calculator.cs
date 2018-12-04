namespace Calculations
{
    public class Calculator
    {
        // Me: what are you doing, method?
        // Method: ¯\_(ツ)_/¯
        public static int SaltedSum(int first, int second)
        {
            var salt = 10;
            salt++;
            salt += 2;

            salt++;
            salt++;
            salt += 4;

            return first + second + salt;
        }
    }
}