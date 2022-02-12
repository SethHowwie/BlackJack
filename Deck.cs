// See https://aka.ms/new-console-template for more information
using System;

namespace BlackJack 
{
   public class Deck{
       private List<Card> cards;

       public Deck(){
           Initialize();
       }
       public List<Card> GetOrgDeck()
       //Creates a new deck organized by suit and face.
       {
           List<Card> orgDeck = new List<Card>();

           for (int i = 0; i < 13; i++)
           {
               for (int j = 0; j < 4; j++)
               {
                   orgDeck.Add(new Card((Suit)j,(Face)i));
               }
           }
           return orgDeck;
       }
       //Deal will pull top two cards off deck, turn it into a list.
       public List<Card> DealInit()
       {
           List<Card> hand = new List<Card>();
           hand.Add(cards[0]);
           hand.Add(cards[1]);


           cards.RemoveRange(0, 2);

           return hand;
       }
//Draw draws the next card on top of deck, and returns it.
       public Card Draw()
       {
           Card card = cards[0];
           cards.Remove(card);

           return card;
       }
       //shuffle does just that, randomizes cards in deck.
       // I struggled here greatly in my initial attempt, had to get help online.
       public void Shuffle()
       {
           Random rng = new Random();

           int n = cards.Count;

           while (n > 1)
           {
               n--;
               int k = rng.Next(n + 1);
               Card card = cards[k];
               cards[k] = cards[n];
               cards[n] = card;
           }

       }
       public void Initialize()
       {
           cards = GetOrgDeck();
           Shuffle();
       }

    }
}
