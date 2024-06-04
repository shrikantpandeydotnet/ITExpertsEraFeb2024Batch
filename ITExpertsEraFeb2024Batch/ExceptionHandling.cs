using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class ExceptionHandling
    {
        public void TestMethod(int value1)
        {
            try
            {
                
                int i = 100;
                int j = 10;

                // throw new Exception.
                try
                {
                    int k = 100000;

                    int l = 0;

                    int m = k / l;

                    Console.WriteLine(m);
                }
                catch (DivideByZeroException ex)
                {

                    throw ex;
                }

                if (value1 < 10)
                {
                    throw new ArgumentException("Value is less than 10");
                }


                int result = i / j;

                Console.WriteLine(result);
                Console.WriteLine("oh balle balle");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("This is Argument exception");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("This is divide by zero exception");
            }

            catch (Exception ex)
            {
                Console.WriteLine("An generic exception occured. Please contact system administrator." + ex.Message + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("This code will be executed irrespective of exception.");
            }
        }
    }
}
