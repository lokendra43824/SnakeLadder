using System;

namespace SnakeLadder
{
    class Program
    {

        public static int GetPositon()
        {
            Random rand = new Random();

            return rand.Next(0, 7);
        }
        static void Main(string[] args)
        {


            //Constants

            const int INITIAL_POS = 0;

            //variables

            int position = 0;


            Console.Out.WriteLine("Start position is: " + INITIAL_POS);

            position = INITIAL_POS + GetPositon();

            Console.Out.WriteLine("After the first roll: " + position);



        }
    }
}