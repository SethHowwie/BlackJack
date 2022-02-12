using System; 

namespace BlackJack
{
    public enum Suit
    {
        Hearts,
        Clubs,
        Spades,
        Diamonds
    }
    public enum Face
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public class Card
    {
        public Suit Suit {get; }
        public Face Face {get; }
        public int Value {get; set; }
        public char Symbol {get;}

        public Card (Suit suit, Face face)
        {
            Suit = suit;
            Face = face;

            switch (Suit)
            {
                case Suit.Clubs:
                Symbol = '♣';
                break;

                case Suit.Spades:
                Symbol = '♠';
                break;
                case Suit.Diamonds:
                Symbol = '♦';
                break;
                case Suit.Hearts:
                Symbol = '♥';
                break;
            }
            switch (Face)
            {
                case Face.Ten:
                Value = 10;
                break;
                case Face.Jack:
                Value = 10;
                break;
                case Face.Queen:
                Value = 10;
                break;
                case Face.King:
                Value = 10;
                break;
                //learned about this on stackexchange wasn't covered in Sololearn course
                //very handy
                default:
                    Value = (int)Face + 1;
                    break; 

            }
        }
        public void WriteCard()
        {
            if (Suit == Suit.Diamonds || Suit == Suit.Hearts)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else{
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (Face == Face.Ace)
            {
                if (Value == 11)
                {
                    Console.WriteLine(Symbol + " High " + Face + " of " + Suit);

                }
                else
                {
                    Console.WriteLine(Symbol + " Low " + Face + " of " + Suit);

                }
            }
            else
            {
                Console.WriteLine(Symbol + " " + Face + " of " + Suit);
            }
            
        }
    }
}