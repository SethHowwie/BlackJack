using System;

namespace BlackJack
{
    //Dictionary<int, Player> PlayerDict = new Dictionary<int, Player>();
    public class Player
    {
        public static int minimumBet = 10; 

        //check if BlackJack
        public static bool IsBlackJack (List<Card> hand)
        {
            if (hand.Count == 2){
                if (hand[0].Face == Face.Ace && hand[1].Value == 10){
                    return true;
                } 
                else if (hand[1].Face == Face.Ace && hand[0].Value == 10)
                {
                    return true;
                }
            }
            return false;
        }
        // in PlayerHand, game will automatically give player 500 chips, keep track of completed hands and wins, as well as give the player
        // their literal hand. 
        public class PlayerHand 
        {
            public int Chips {get; set;} = 500;
            public int Bet {get; set;}
            public int Wins {get; set;}
            public int HandCompleted {get; set;} = 1;
            public List<Card> hand {get; set;}

        
        public void addBet(int bet)
        {
            Bet += bet;
            Chips -= bet;
        }
        public void ClearBet()
        {
            Bet = 0;
        }
        public void CancelBet()
        {
            Chips += Bet;
            ClearBet();
        }
        //my hope is that this can be used for more than just the player, and can be used for the dealer as well. However, the dealers
        // calculations will be different, taking just whatever was bet from the player(s), I intend to make this game multiplayer.

        //WinBet will also update players chips with correct amounts. return to be used for "You win this amount: WinBet()" etc...
        public int WinBet(bool blackjack)
        {
            int chipsWon;
            if(blackjack)
            {
                chipsWon = (int) Math.Floor(Bet * 1.5);

            }
            else{
                chipsWon = Bet;
            }
            Chips = chipsWon + Bet;
            ClearBet();
            return chipsWon;
            
        }

        }
        public class dealer
        {
            public static List<Card> deck {get; set; } = new List<Card>();
            public static List<Card> dealHand {get; set; } = new List<Card>();

//typical blackJack will have the dealer flip the first card after dealing to everyone, dealer will also check for black jack in 
//this case
            public static void RevealCard()
            {
                dealHand.Add(deck[0]);
                deck.RemoveAt(0);


            }

        }
        

    
    }
}