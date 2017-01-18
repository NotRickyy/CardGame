using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        private int suit;//4=hearts, 3=diamonds, 2=clubs, 1=spades.  Order can be changed if needed.
        private int value;

        public int Suit
        {
            get
            {
                return suit;
            }

            set
            {
                suit = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public String getCardName()
        {
            String suit = "";
            switch (this.suit)
            {
                case 1:
                    suit = "Hearts";
                    break;
                case 2:
                    suit = "Diamonds";
                    break;
                case 3:
                    suit = "Clubs";
                    break;
                case 4:
                    suit = "Spades";
                    break;
                default:
                    suit = "Error";
                    break;
            }
            String value = this.Value.ToString();
            switch (value)
            {
                case "1":
                    value = "Ace";
                    break;
                case "11":
                    value = "Jack";
                    break;
                case "12":
                    value = "Queen";
                    break;
                case "13":
                    value = "King";
                    break;
                default:
                    break;
            }
            return value + " of " + suit;
        }

        //compare card, set chkSuit to true to compare the suits as well
        public String compare(Card card, Boolean chkSuit)
        {
            if (card.value > this.value)
            {
                return "Higher";
            }
            else if (card.value < this.value)
            {
                return "Lower";
            }
            else if (card.value == this.value)
            {
                if (chkSuit == true)
                {
                    if (card.suit > this.suit)
                    {
                        return "Higher";
                    }
                    else if (card.suit < this.suit)
                    {
                        return "Lower";
                    }
                }
                //Can add to check suit to see which is higher here.
                return "Equal";
            }
            return "Error";
        }
    }
}
