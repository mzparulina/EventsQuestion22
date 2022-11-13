using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsQuestion22
{

    // subtract two numbers then check the result if its odd.
    class Program
    {
        static void Main(string[] args)
        {
            MinusTwoNums a = new MinusTwoNums();
            //Event gets binded with delegates
            a.e_OddNumber += new MinusTwoNums.OddNumber(Message);
            a.Minus();
            Console.ReadKey();
        }

        //Delegates calls this method when event raised.  
        static void Message()
        {
            Console.WriteLine("This is Odd Number");
        }
    }

    class MinusTwoNums
    {
        public delegate void OddNumber(); //Declared Delegate     
        public event OddNumber e_OddNumber; //Declared Events

        public void Minus()
        {
            int result;
            result = 10 - 3;
            Console.WriteLine(result.ToString());

            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (e_OddNumber != null))
            {
                e_OddNumber(); //Raised Event
            }
        }
    }
}