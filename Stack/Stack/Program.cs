using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                OtusDictionary otusDictionary = new OtusDictionary(32);

                otusDictionary.Add(0, "111");
                otusDictionary.Add(1, "222");
                otusDictionary.Add(2, null);

                Console.WriteLine($"{otusDictionary.Get(3)}");

                otusDictionary.Resize(40);

               
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);            
            }


        }
    }
}
