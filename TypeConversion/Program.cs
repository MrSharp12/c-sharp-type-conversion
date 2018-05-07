using System;

namespace TypeConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //byte b = 1; //byte is only 1 byte
            //int i = b; //an integer is 4 bytes
            //Console.WriteLine(i);

            //int i = 1;
            //byte b = (byte) i; //this is an example of casting, maximum number of bytes is 255
            //Console.WriteLine(b);

            //string number = "1234";
            //int i = Convert.ToInt32(number);
            //need to use Convert method in order to change a string into an integer
            //Console.WriteLine(i);


            //try //code in the try block will be monitored
            //{
            //    var number = "1234";
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)//if an exception happens, this block will be executed preventing app crash
            //{
            //    Console.WriteLine("The number could not be converted to a byte.");
            //}

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

            }

        }
    }
}
