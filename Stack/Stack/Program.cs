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
                otusDictionary.Add(26, "222");
                
                
                otusDictionary.Add(2234, "1");
                //otusDictionary.Add(2235, null);
                otusDictionary[50] = "555";

                Console.WriteLine($"{otusDictionary.Get(26)}");

                Console.WriteLine($"{otusDictionary[26]}");
                Console.WriteLine($"{otusDictionary[50]}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);            
            }


        }
    }
}
