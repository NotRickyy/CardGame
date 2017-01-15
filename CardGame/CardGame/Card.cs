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

        public String getSuitString()
        {
            switch (this.suit)
            {
                case 1:
                    return "Hearts";
                    break;
                case 2:
                    return "Diamonds";
                    break;
                case 3:
                    return "Clubs";
                    break;
                case 4:
                    return "Spades";
                    break;
                default:
                    return "Error";
                    break;
            }
        }

        //compare card, set chkSuit to true to compare the suits as well
        public String compare(Card card, Boolean chkSuit)
        {
            if (card.value > this.value)
            {
                return "Higher";
            }else if (card.value < this.value)
            {
                return "Lower";
            }else if (card.value == this.value)
            {
                return "Equal";
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
            }
        }
    }
}
