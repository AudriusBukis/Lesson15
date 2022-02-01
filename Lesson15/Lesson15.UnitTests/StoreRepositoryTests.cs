using System;
using Xunit;

namespace Lesson15.UnitTests
{
    public class StoreRepositoryTests
    {
        [Fact]

        public void Test_If_Input_Of_Command_Works_Correct_When_You_Enter_Exit_Command()
        {
            bool testBool = false;
            //"if you want exit the list perss y "
            string inputString = " Y ".ToLower().Trim();
            if (inputString == "y")
            {
                testBool = true;
            }
            else if (Int32.TryParse(inputString, out int indexNumber))
            {
                testBool = false;
            }
            else
            {
                testBool = false;
            }

            Assert.True(testBool);
        }  
        
        [Fact]
        public void Test_If_Function_Returns_Corect_Values()
        {
            bool heveMoney = false;
            double walletSize = 0;
            // public (bool HeveMoney, double WalletSize) WelcomToStore()
            // {

            ///    Console.Clear();
            //     Console.WriteLine("Welcome to store");
            //     Console.WriteLine("Enter how much money do you have ? ");
            if (Double.TryParse("-63.58", out double result))
                {
                //return (true, result);
                heveMoney = true;
                walletSize = result;
            }
            else
            {
                // Console.WriteLine("You entered not a number, press enter to continue");
                // Console.ReadKey();
                // return (false, 0);
                heveMoney = false;
                walletSize = 0;
            }
            //}
            Assert.True(heveMoney);
            Assert.Equal(-63.58, walletSize);


        }
      

    }
}
