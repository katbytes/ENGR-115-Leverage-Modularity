/*********
Author: Katherine Bell
Date: October 2, 2015

**********/

using System;
using System.Windows.Forms;

class Bell_M5_RockPaperScissors{
   static string player2;
   public static void Main(string[] args){
   string response;
   
   Console.Write("Would you like to play a game of Rock, Paper, Scissors? Yes/No. ");
   response = Console.ReadLine();
   response = response.ToUpper();//This allows for any variation of spelling to be input, as it will be changed to all upper case letters.
   while(response == "YES"){ //This is the beginning of my loop.
	 ComSelect();
	 
	Console.Write("\nWould you like to play another game of Rock, Paper, Scissors? Yes/No. ");
    response = Console.ReadLine();
    response = response.ToUpper();
        } // This is the end of the loop.
	Console.WriteLine("\nHave a nice day!");
	} 
   
   public static void ComSelect(){
     Random RPS = new Random();
     int number = RPS.Next (1,4); //Lines 19 and 20 allow for the randomization of the cases.
	 
     switch(number){
	     case 1:
		     Console.WriteLine("\nPlayer 1 <Computer> has selected: Rock.");
			 PlayerSelect();
             JudgeRock();
			 break;
			 
	     case 2:
		     Console.WriteLine("\nPlayer 1 <Computer> has selected: Paper.");
			 PlayerSelect();
			 JudgePaper();
			 break;
			 
	     case 3:
		     Console.WriteLine("\nPlayer 1 <Computer> has selected: Scissors.");
			 PlayerSelect();
             JudgeScissors();
			 break;
			 }
   }
   
   public static void PlayerSelect(){
     Console.Write("Player 2, please make a selection: Rock, Paper, or Scissors. ");
     player2 = Console.ReadLine();
     player2 = player2.ToUpper();
   }
   
   public static void JudgeRock(){
     if(player2 == "ROCK")
	   Console.WriteLine("\nRocks are friends! Draw!");
	 if(player2 == "PAPER")
	   Console.WriteLine("\nPaper covers rock! Player 2 Wins!");
	 if(player2 == "SCISSORS")
	   Console.WriteLine("\nRock crushes Scissors! Computer Wins!");
	 if(!(player2 == "ROCK" || player2 == "PAPER" || player2 == "SCISSORS")){ 
	   Console.WriteLine("\nPlease enter one of the 3 options only!");
	   Environment.Exit(0);
	   }
	}
	
   public static void JudgePaper(){
     if(player2 == "ROCK")
	   Console.WriteLine("\nPaper covers rock! Computer Wins!");
	 if(player2 == "PAPER")
	   Console.WriteLine("\nPapers are friends! Draw!");
	 if(player2 == "SCISSORS")
	   Console.WriteLine("\nScissors cut Paper! Player 2 Wins!");
	 if(!(player2 == "ROCK" || player2 == "PAPER" || player2 == "SCISSORS")){
	   Console.WriteLine("\nPlease enter one of the 3 options only!");
	   Environment.Exit(0);
	   }
	}
   
   public static void JudgeScissors(){
     if(player2 == "ROCK")
	   Console.WriteLine("\nRocks crushes Scissors! Player 2 Wins!");
	 if(player2 == "PAPER")
	   Console.WriteLine("\nScissors cuts Paper! Computer Wins!");
	 if(player2 == "SCISSORS")
	   Console.WriteLine("\nScissors are friends! Draw!");
	 if(!(player2 == "ROCK" || player2 == "PAPER" || player2 == "SCISSORS")){
	   Console.WriteLine("\nPlease enter one of the 3 options only!");
	   Environment.Exit(0);
	   }
    }
}