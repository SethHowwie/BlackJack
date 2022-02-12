// using System;
// using System.Linq;
// namespace BlackJack
// {
//     public class Hand 
//     {
//         public class HandToPlay 
//         {
//             public int Chips {get; set;} = 500;
//             public int Bet {get; set;}
//             public int Wins {get; set;}
//             public int HandCompleted {get; set;} = 1;
//             public List<Card> hand {get; set;}

        
//         public void addBet(int bet)
//         {
//             Bet += bet;
//             Chips -= bet;
//         }
//         public void ClearBet()
//         {
//             Bet = 0;
//         }
//         public void CancelBet()
//         {
//             Chips += Bet;
//             ClearBet();
//         }
//         //my hope is that this can be used for more than just the player, and can be used for the dealer as well. However, the dealers
//         // calculations will be different, taking just whatever was bet from the player(s), I intend to make this game multiplayer.

//         //WinBet will also update players chips with correct amounts. return to be used for "You win this amount: WinBet()" etc...
//         public int WinBet(bool blackjack)
//         {
//             int chipsWon;
//             if(blackjack)
//             {
//                 chipsWon = (int) Math.Floor(Bet * 1.5);

//             }
//             else{
//                 chipsWon = Bet;
//             }
//             Chips = chipsWon + Bet;
//             ClearBet();
//             return chipsWon;
            
//         }

//         }
//     }
// }


//I ended up abandoning this idea of a hand class, I feel as though player should be able to handle things just fine. With no cost 
// to efficiency. 