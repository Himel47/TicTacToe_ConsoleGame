using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToe
{
    class Program
    {

        //Create Play Field
        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;


            

            //Run while the program runs
            do
            {

                if (player == 2)
                {
                    player = 1;
                    enterInput('O',input);
                }
                else if(player == 1)
                {
                    player = 2;
                    enterInput('X',input);
                }

                SetField();

                #region

                //Check winning Comdition
                char[] playerChars = {'X', 'O'};
                foreach (char playerChar in playerChars)
                {
                    if (playField[0, 0] == playField[0,1] && playField[0, 1] == playField[0,2] && playField[0, 0] == playerChar
                        || playField[1, 0] == playField[1, 1] && playField[1, 1] == playField[1, 2] && playField[1, 2] == playerChar
                        || playField[2, 0] == playField[2, 1] && playField[2, 1] == playField[2, 2] && playField[2, 2] == playerChar
                        || playField[0, 0] == playField[1, 1] && playField[2, 2] == playField[0, 0] && playField[0, 0] == playerChar
                        || playField[0, 0] == playField[1, 0] && playField[2, 0] == playField[0, 0] && playField[0, 0] == playerChar
                        || playField[0, 1] == playField[1, 1] && playField[2, 1] == playField[0, 1] && playField[0, 1] == playerChar
                        || playField[0, 2] == playField[1, 2] && playField[2, 2] == playField[0, 2] && playField[0, 2] == playerChar
                        || playField[0, 2] == playField[1, 1] && playField[2, 0] == playField[0, 2] && playField[0, 2] == playerChar
                        )
                    {
                        if(playerChar=='X')
                        {
                            Console.WriteLine("\nPlayer 2 has Won!");
                        }
                        else if(playerChar == 'O')
                        {
                            Console.WriteLine("\nPlayer 1 has Won!");
                        }

                        //RESet the Field
                        Console.WriteLine("Press any Key to Play Again.");
                        Console.ReadKey();
                        resetField();

                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\"DRAW\"  We Have No Winner!!!");
                        Console.WriteLine("Press any Key to Play Again.");
                        Console.ReadKey();
                        resetField();
                        break;
                    }
                }

                #endregion


                #region
                //test if field is already taken

                do
                {
                    Console.Write($"\nPlayer {player}, Choose your Field: ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a Number!");
                    }

                    if(input ==1 && playField[0,0] == '1')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 2 && playField[0, 1] == '2')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 3 && playField[0, 2] == '3')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 4 && playField[1, 0] == '4')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 5 && playField[1, 1] == '5')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 6 && playField[1, 2] == '6')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 7 && playField[2, 0] == '7')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 8 && playField[2, 1] == '8')
                    {
                        inputCorrect = true;
                    }
                    else if (input == 9 && playField[2, 2] == '9')
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input! Please Insert Correct Input.");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);

                #endregion

            } while (true);


        }


        public static void resetField()
        {
            char[,] playFieldInitial =
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
            };


            playField = playFieldInitial;
            SetField();
            turns = 0;
        }


        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine(" _______________________");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine($"|   {playField[0,0]}   |   {playField[0, 1]}   |   {playField[0, 2]}   |");
            Console.WriteLine("|_______|_______|_______|");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine($"|   {playField[1, 0]}   |   {playField[1, 1]}   |   {playField[1, 2]}   |");
            Console.WriteLine("|_______|_______|_______|");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine($"|   {playField[2, 0]}   |   {playField[2, 1]}   |   {playField[2, 2]}   |");
            Console.WriteLine("|_______|_______|_______|");

            turns++;
        }


        public static void enterInput(char playerSign, int input)
        {
            switch (input)
            {
                case 1:
                    playField[0, 0] = playerSign; break;
                case 2:
                    playField[0, 1] = playerSign; break;
                case 3:
                    playField[0, 2] = playerSign; break;
                case 4:
                    playField[1, 0] = playerSign; break;
                case 5:
                    playField[1, 1] = playerSign; break;
                case 6:
                    playField[1, 2] = playerSign; break;
                case 7:
                    playField[2, 0] = playerSign; break;
                case 8:
                    playField[2, 1] = playerSign; break;
                case 9:
                    playField[2, 2] = playerSign; break;

            }

        }
    }
}