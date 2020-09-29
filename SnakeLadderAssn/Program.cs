using System;

namespace SnakeLadder
{
    class Program
    {

        const int NO_Play = 0;
        const int Ladder = 1;
        const int Snake = 2;

        public static int PlayGame(String player, int prev_postion)
        {
            // variables

            int position = prev_postion;
            int next_position = 0;
            int play_option = 0;
            bool ladder = true;

            // while ladder is true player continues the game 
            // or he quits

            while (ladder == true)
            {
                next_position = GetPositon(0, 7);

                play_option = GetPositon(0, 3);

                switch (play_option)
                {
                    case NO_Play:
                        Console.Out.WriteLine(player + " NO_PLAY, ur postion is " + position);
                        ladder = false;
                        break;
                    case Ladder:
                        position += next_position;
                        ladder = true;
                        if (position <= 100)
                        {
                            Console.Out.WriteLine(player + " Moved forward to " + position);

                            break;
                        }
                        else
                        {
                            position -= next_position;
                            Console.Out.WriteLine(player + " Moved forward to " + position);
                        }
                        break;
                    case Snake:
                        position -= next_position;
                        if (position <= 0)
                        {
                            position = 0;

                        }
                        Console.Out.WriteLine(player + " Moved backward to " + position);
                        ladder = false;
                        break;
                    default:
                        ladder = false;
                        break;
                }
            }

            return position;
        }
        public static int GetPositon(int start, int end)
        {
            Random rand = new Random();

            return rand.Next(start, end);
        }
        static void Main(string[] args)
        {
            String player1 = "Player1";
            String player2 = "Player2";


            //variables

            int position1 = 0;

            int position2 = 0;


            while ((position1 != 100) || (position2 != 100))
            {
                position1 = PlayGame(player1, position1);

                if (position1 == 100)
                {
                    break;
                }
                position2 = PlayGame(player2, position2);
            }

            if (position1 == 100)
            {
                Console.Out.WriteLine("Player1 won the game");
            }
            else
            {
                Console.Out.WriteLine("Player2 won the game");
            }

        }
    }
}