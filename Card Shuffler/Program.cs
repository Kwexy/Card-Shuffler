using System;
using System.Collections;
namespace Card_Shuffler {
    public class Program {

        public static List<Card> deck = new List<Card>();
        public static List<Card> tempShuffleDeck = new List<Card>();

        public Program() {
            populateDeck(deck);
            shuffle();
            printDeck();
            
            }

        public void populateDeck(List<Card> list) {
            for (int s = 1; s <= 4; s++) {
                for (int v = 1; v <= 13; v++) {
                    deck.Add(new Card((Card.Suite)s, (Card.Value)v));
                    //Console.WriteLine();
                }
            }
        }

        public void printDeck () {
            for (int i = 0; i < 52; i++) {
                switch(deck[i].getsuite()) {
                    case Card.Suite.Spade:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Card.Suite.Club:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Card.Suite.Heart:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Card.Suite.Diamond:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default: Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }

             
                Console.WriteLine(Card.getCardName(deck[i]));
            }
        } 

        public void shuffle() {
            Random rand = new Random();
            for (int deckSize = 52; deckSize > 0; deckSize--) {
                int r = rand.Next(deckSize);
                tempShuffleDeck.Add(deck[r]);
                deck.RemoveAt(r);
            }
            deck = tempShuffleDeck;
        }

        public static void Main(string[] args) {
            new Program();
        }
    }
}
