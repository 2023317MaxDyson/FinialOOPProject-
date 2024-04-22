

//  Team Member: Max Dyson



namespace OOPProjectMaxDyson
{

    using System.ComponentModel.Design;






class Gamecontroller {

        


}


 class Model { 
        
        
      // seven-column, six-row vertically suspended grid


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
       
    public void NeedHelp() { 

     Console.WriteLine( "\n\n Connect 4 rules:  ");
     Console.WriteLine("\n\n In Connect 4 their are two players that can pick their two symbols (X or O) as thier discs.\n ");
     Console.WriteLine("Players take turns by dropping their discs in the Connect 4 game board.\n ");
     Console.WriteLine("To win Connect 4 you must get a 4 in a row and it could be diagionial or horizontal or verticial.");
  
       

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

            if (input == "Help") {

                // Implemment a Interaction class object

                var Interact = new Interaction();

                Interact.NeedHelp();



            }



            // Start the game 

            else if (input == "Start") {

                

                }


        }
    }
}
