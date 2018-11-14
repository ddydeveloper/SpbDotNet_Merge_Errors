namespace Calculations
{
    public class Calculator
    {
        public int SaltedSumm(int first, int second)
        {
            var salt = 10;
//features/salted_2
            salt++;
            salt+=2;
            salt+=4;
            salt++;
            salt++;            

            salt++;       
            salt = salt + 2;
            salt += 1;
            salt++;
// master
            return first + second + salt;
        }
    }
}