

//  Team Member: Max Dyson



using System.ComponentModel.Design;

namespace OOPProjectMaxDyson
{

    using System.ComponentModel.Design;
    using System.Runtime.InteropServices.Marshalling;
    using System.Security.Cryptography.X509Certificates;

    class Gamecontroller {

 
    }



    // Holds information about the game 


   class Model
    {





        //  discs 





        //   public string gameBoard() {


        // seven-column, six-row vertically suspended grid
        // Counting by index: 6-column, 5-row vertically suspended grid



        //  }




        //    public bool startGame() {





        //  }



    }


    abstract class Player { 

  






}

// 1 or 2 players 
class Players : Player {





}




    // Computer Player 

    /*
    class ComputerPlayer : Player
    {

    }

    */

    class Interaction {


        public Interaction() {


        }


        public static void NeedHelp() {

            Console.WriteLine("\n\n Connect 4 rules:  ");
            Console.WriteLine("\n\n In Connect 4 their are two players that can pick their two symbols (X or O) as thier discs.\n ");
            Console.WriteLine("Players take turns by dropping their discs in the Connect 4 game board.\n ");
            Console.WriteLine("To win Connect 4 you must get a 4 in a row and it could be diagionial or horizontal or verticial.");
        }

       public void exitGame()   {

            Console.WriteLine("You have exited the game");

            }

    
    


}




    internal class Program
    {
        static void Main(string[] args)
       
        {
            Console.WriteLine(" Welcome to the Connect 4 Game: ");
            Console.WriteLine("\n Type Help to look at how to play Connect 4 \n\n Type Start to start the game \n");

            var input = Console.ReadLine();



         string[,] gameBoard = new string[7, 6];





            // Help on how to play connect 4 


            if (input == "Help")   {


                Interaction.NeedHelp();



            }

            // Start the game 

            else if (input == "Start") {


                for (int i = 0; i <= 7; i++)  {

         
                    for (int j = 0; j <= 6; j++) {

                        gameBoard[i, j] = "#";


                        Console.WriteLine("\n" + gameBoard[i, j]);

                    }

                    Console.WriteLine();

                }
              
            }


            // Exit the game 

            else if (input == "Exit")  {

                var Exit = new Interaction();
                Exit.exitGame();
            }

        
        }
    }
}
