using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessRenderer.Render();
                throw new CustomException("sdcbahsdbckjasdkjc");
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}
