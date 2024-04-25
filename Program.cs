
// Team Name: The C# Coder 


//  Team Member: Max Dyson



using OOPProjectMaxDyson;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace OOPProjectMaxDyson
{

    using System.ComponentModel.Design;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices.Marshalling;
    using System.Security.Cryptography.X509Certificates;
    using System.Transactions;


    // The Game controller 



    class GameController
    {

        public static bool Connect4Game()

        {

            // Create 2 player objects 

            Player player1 = new UserPlayer("Player1", "X");
            Player player2 = new UserPlayer("Player2", "0");

            // Display the board 

            Model.Board();

            // Display  the buttons for each column 

            Controller();


            while (true)
            {

                int column = player1.GetNextMove() +1;

                // Drop the disc in the selected column 

                if (!Model.DropDisc(column, player1.Disc)) {

                    Interaction.Error();

                    continue;


                }


                 column = player2.GetNextMove() + 1;

                if (!Model.DropDisc(column, player2.Disc))
                {

                    Interaction.Error();

                    continue;


                }

            }
        }

        public static void Controller()
        {


            // Create a list of buttons for each column 


            List<string> ButtonsList = new List<string>();


            ButtonsList.Add(" " + " " + " " + "1");
            ButtonsList.Add("2");
            ButtonsList.Add("3");
            ButtonsList.Add("4");
            ButtonsList.Add("5");
            ButtonsList.Add("6");
            ButtonsList.Add("7");

            foreach (string buttons in ButtonsList)
            {

                Console.Write(buttons + " ");


            }

        }
    }





    // Holds information of the  game 


    class Model
    {




        public static void Board()
        {



            // seven-column, six-row vertically suspended grid

            // Counting by index: 7-column, 5-row vertically suspended grid

            //Empty disc symbol  #

            // Updating the gameboard that is created by a multidimensial array;


            String[,] gameBoardarray = {

           /* 0 */     {  "[", "#", "#", "#", "#", "#", "#", "#", "]", "\n"},
          /* 1  */     {  "[", "#", "#", "#", "#", "#", "#", "#", "]", "\n"},
          /* 2  */     {  "[", "#", "#", "#", "#", "#", "#", "#", "]" , "\n"},
          /* 3 */      {  "[", "#", "#", "#", "#", "#", "#", "#", "]" , "\n"},
          /*  4 */     {  "[", "#", "#", "#", "#", "#", "#", "#", "]" , "\n"},
          /* 5 */      {  "[", "#", "#", "#", "#", "#", "#", "#", "]" , "\n"}

        };                   //    1    2    3    4    5    6    7


            foreach (string gameBoard in gameBoardarray)
            {

                Console.Write(" " + gameBoard);

            }


        }



        public static bool DropDisc(int column, string disc)
        {


            String[,] gameBoardarray = {

          /* 0 */     {  "[", "#", "#", "#", "#", "#", "#", "#", "]", "\n"},
         /* 1  */     {  "[", "#", "#", "#", "#", "#", "#", "#", "]", "\n"},
         /* 2  */     {  "[", "#", "#", "#", "#", "#", "#", "#", "]" , "\n"},
         /* 3 */      {  "[", "#", "#", "#", "#", "#", "#", "#", "]" , "\n"},
         /*  4 */     {  "[", "#", "#", "#", "#", "#", "#", "#", "]" , "\n"},
           /* 5 */    {  "[", "#", "#", "#", "#", "#", "#", "#", "]" , "\n"}

        };           //    1    2    3    4    5    6    7

            
       


            // Iterates from the bottom row to the top row depending on what column you picked

            for (int row = gameBoardarray.GetLength(0) - 1; row > 0; row--)
            {

                if (gameBoardarray[row, column - 1] == "#")
                {


                    // Drops a disc that is empty 

                    gameBoardarray[row, column] = disc;

                    return true;

                }

            }

            // Column is full 

            return false;

        }

    }


    abstract class Player
    {


        public string Name { get; set; }
        public string Disc { get; set; }


        protected Player(string name, string disc)
        {

            Name = name;
            Disc = disc;

        }

        public abstract int GetNextMove();


    }

    // 1 or 2 players 
    class UserPlayer : Player
    {

        // Variables 


        public UserPlayer(string name, string disc) : base(name, disc)
        {




        }

        public override int GetNextMove()
        {

            int column = -1;
            bool Isvalidinput = false;

            while (!Isvalidinput)
            {

                Console.WriteLine( "\n" + $"{Name},  enter column number (1-7):");
                string input = Console.ReadLine();


                //  Select a column 

                if (input.Length == 1 && input[0] >= '1' && input[0] <= '7')
                {

                    column = input[0] - '1';

                    Isvalidinput = true;
                }

                else
                {
                    Interaction.Error();
                }


            }


            return column;
        }

    }


    class Interaction
    {





        public static void NeedHelp()
        {

            Console.WriteLine("\n\n Connect 4 rules:  ");
            Console.WriteLine("\n\n In Connect 4 their are two players that can pick their two symbols (X or O) as thier discs.\n ");
            Console.WriteLine("Players take turns by dropping their discs in the Connect 4 game board.\n ");
            Console.WriteLine("To win Connect 4 you must get a 4 in a row and it could be diagionial or horizontal or verticial.");
        }

        public void exitGame()
        {

            Console.WriteLine("You have exited the game");

        }

        public static void Error()
        {

            Console.WriteLine("Error, please type a number between 1 to 7;");

        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" Welcome to the Connect 4 Game: ");
            Console.WriteLine("\n Type Help to look at how to play Connect 4 \n\n Type Start to start the game \n");



            var input = Console.ReadLine();




            // Help on how to play connect 4 


            if (input == "Help")
            {


                Interaction.NeedHelp();


            }

            // Start the game

            else if (input == "Start")
            {


                // GameController object 

                GameController.Connect4Game();



            }



            // Exit the game 

            else if (input == "Exit")
            {

                var Exit = new Interaction();
                Exit.exitGame();
            }




        }
    }
}


