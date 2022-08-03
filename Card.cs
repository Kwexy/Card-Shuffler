using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Shuffler {
    public class Card {
        public enum Suite {Spade = 1, Club = 2, Heart = 3, Diamond = 4};
        public enum Value {Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13}

        private Suite suite;
        private Value value;

        public Card(Suite s, Value v) {
            suite = s;
            value = v;
        }

        public Suite getsuite() {
            return suite;
        }

        public Value getValue() {
            return value;
        }

        public static string getCardName(Card c) {
            return c.value + " of " + c.suite + "s.";
        }
    }
}
