namespace Calculations
{
    public class Calculator
    {
        public int SaltedSumm(int first, int second)
        {
            var salt = 10;
            salt++;
            salt+=2;
            salt+=4;
            salt++;
            salt++;            
            return first + second + salt;
        }
    }
}