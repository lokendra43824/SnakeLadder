using System;

namespace SnakeLadder
{
    class Program
    {

        public static int GetPositon(int start, int end)
        {
            Random rand = new Random();

            return rand.Next(start, end);
        }
        static void Main(string[] args)
        {
            String player1 = "Player1";

            //Constants

            const int NO_Play = 0;
            const int Ladder = 1;
            const int Snake = 2;


            //variables


            int position = 0;
            int next_position = 0;
            int play_option = 0;


            next_position = GetPositon(0, 7);

            play_option = GetPositon(0, 3);


            switch (play_option)
            {
                case NO_Play:
                    Console.Out.WriteLine("NO_PLAY, ur postion is " + position);
                    break;
                case Ladder:
                    position += next_position;
                    Console.Out.WriteLine("Moved forward to " + position);
                    break;
                case Snake:
                    position -= next_position;
                    if (position <= 0)
                    {
                        position = 0;
                    }
                    Console.Out.WriteLine("Moved backward to " + position);
                    break;
                default:
                    break;
            }

        }
    }
}





