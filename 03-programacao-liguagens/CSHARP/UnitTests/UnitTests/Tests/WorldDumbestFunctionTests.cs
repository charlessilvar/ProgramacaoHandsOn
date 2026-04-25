using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class WorldDumbestFunctionTests
    {
        //Naming Convention - ClassName_MethodName_ExpectedResult
        public static void WorldDumbestFunction_ReturnSuccessIfZero_ReturnString()
        {
            try
            {
                //Arrange - Go get your variables whatever you need, your classes go get functions
                int num = 0;
                WorldDumbestFunction func = new WorldDumbestFunction();

                //Act - Execute this function
                string result = func.ReturnSuccessIfZero(num);

                //Assert - Whatever ever is returned is it what you want
                if (result != null && result == "Success")
                {
                    Console.WriteLine("PASSED: WorldDumbestFunction.ReturnSuccessIfZero_ReturnString");
                }else
                {
                    Console.WriteLine("FAILED: WorldDumbestFunction.ReturnSuccessIfZero_ReturnString");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
