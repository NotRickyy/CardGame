using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class frmHighLow : Form
    {
        //test variables
        Card[] testDeck;
        String cardImage;
        int currentCard;
        //end test variables

        public frmHighLow()
        {
            InitializeComponent();

            //test
            currentCard = 0;
            testDeck = new Card[52];
            int suit = 1;
            int value = 1; 
            for (int i=0; i < testDeck.Length; i++) {
                testDeck[i] = new Card(suit, value);
                value++;
                if (value == 14)
                {
                    value = 1;
                    suit++;
                }
            }
            cardImage = testDeck[currentCard].getCardIdentifier();
            lblUserCard.Text = cardImage;
            picUserCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardImage);
            picUserCard.Refresh();
            //end test
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCardGame cardGame = new frmCardGame();
            cardGame.Show();

        }

        //testing 
        private void picUserCard_Click(object sender, EventArgs e)
        {
            if (currentCard > testDeck.Length-1 )
            {
                currentCard = 0;
            }
            cardImage = testDeck[currentCard].getCardIdentifier();
            lblUserCard.Text = cardImage;
            picUserCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardImage);
            picUserCard.Refresh();
            currentCard++;
        }
        //end testing
    }
}
