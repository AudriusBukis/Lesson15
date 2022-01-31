using System;
using Xunit;

namespace Lesson15.UnitTests
{
    public class ProgramTests
    {
        [Fact]
        public void Test_If_Input_Of_Command_Works_Correct_When_You_Enter_Not_Number()
        {
            string temp = "";
            if (Int32.TryParse("5fe", out int inputNumber))
            {
                
            }
            else
            {
                temp = "You entered not the number, press enter to continue";
                
            }

            Assert.Equal("You entered not the number, press enter to continue", temp);
        }
    }
}
