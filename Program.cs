
// Team Name: The C# Coder 


//  Team Member: Max Dyson



using System.ComponentModel.Design;

namespace OOPProjectMaxDyson
{

    using System.ComponentModel.Design;
    using System.Runtime.InteropServices.Marshalling;
    using System.Security.Cryptography.X509Certificates;
    using System.Transactions;



    // The Game controller 

    // The Model class and the Player abstract class should  should communicate with the world via an object that is created in your controller class.

    class Gamecontroller {

        Gamecontroller player1;


      


        public static void Connect4Game() {


          Console.WriteLine("\n  Enter (1-7):  ");


          Console.ReadLine();




        }


        public static void Controller(string buttons) {

           Console.Write(buttons + " ");
        
        

        }






}



    // Holds information of the  game 

                                                                                                                                                                                            
   class Model: Gamecontroller {


        public Model()    {



        }

          public static void Board() {




            // seven-column, six-row vertically suspended grid
            // Counting by index: 6-column, 5-row vertically suspended grid

            // Create the gameboa

            //Empty disc symbol  #


            // Updating the gameboard that is created by a multidimensial array;





            String[,] gameBoardarray = { 
 
                {  "[", "#", "#", "#", "#", "#", "#",  "#", "]", "\n"}  ,
                {  "[", "#", "#", "#", "#", "#", "#",  "#", "]", "\n"}  ,
                {  "[", "#", "#", "#", "#", "#", "#",  "#", "]" , "\n"} ,
                {  "[", "#", "#", "#", "#", "#", "#",  "#", "]" , "\n"} ,
                {  "[", "#", "#", "#", "#", "#", "#",  "#", "]" , "\n"} ,
                {  "[", "#", "#", "#", "#", "#", "#",  "#", "]" , "\n"} ,
                {  "[", "#", "#", "#", "#", "#", "#",  "#", "]" , "\n"} 
            };



            foreach(string gameBoard in gameBoardarray  ) {

                
                Console.Write( " " + gameBoard);

            }




    }



    }


    abstract class Player: Gamecontroller {
        
        public string Player1;

        public string Player2;




        public Player() {



     }




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
        static void Main(string[] args) {


            Console.WriteLine(" Welcome to the Connect 4 Game: ");
              Console.WriteLine("\n Type Help to look at how to play Connect 4 \n\n Type Start to start the game \n");



            // Using a list to create the buttons for the game board
            // 7 buttons


            var input = Console.ReadLine();




            // Help on how to play connect 4 


            if (input == "Help") {


                Interaction.NeedHelp();


            }

            // Start the game
         
            else if (input == "Start") {



                Model.Board();


                // Using a list to create the buttons for the game board
                // 7 buttons

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
               
                    Gamecontroller.Controller(buttons);

                }


                Gamecontroller.Connect4Game();

            }


            // Exit the game 

            else if (input == "Exit")  {

                var Exit = new Interaction();
                Exit.exitGame();
            }

           
        
        }
    }
}
