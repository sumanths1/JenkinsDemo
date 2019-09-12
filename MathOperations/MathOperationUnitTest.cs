using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathOperations
{
    public class MathOperationUnitTest
    {
        [Fact]
        public void Task_Add_TwoNumbers()
        {
            var num1 = 2;
            var num2 = 4;
            var ExpectedValue = 6;
            var Res = Operations.ADD(num1, num2);
            Assert.Equal(ExpectedValue, Res, 1);
        }

        [Fact]
        public void Task_Sub_TwoNumbers()
        {
            var num1 = 4;
            var num2 = 2;
            var ExpectedValue = 2;
            var Res = Operations.SUB(num1, num2);
            Assert.Equal(ExpectedValue, Res, 1);
        }

        [Fact]
        public void Task_Multiply_TwoNumbers()
        {
            var num1 = 4;
            var num2 = 2;
            var ExpectedValue = 8;
            var Res = Operations.MUL(num1, num2);
            Assert.Equal(ExpectedValue, Res, 1);
        }

        [Fact]
        public void Task_Divide_TwoNumbers()
        {
            var num1 = 4;
            var num2 = 2;
            var ExpectedValue = 2;
            var Res = Operations.DIV(num1, num2);
            Assert.Equal(ExpectedValue, Res, 1);
        }

    }
}
