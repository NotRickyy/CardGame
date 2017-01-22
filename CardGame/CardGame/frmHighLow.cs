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
            //cardImage = testDeck[currentCard].getCardIdentifier();
            //lblUserCard.Text = cardImage;
            //picUserCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardImage);
            //picUserCard.Refresh();
            //end test
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCardGame cardGame = new frmCardGame();
            cardGame.Show();
            Close();

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

        private void lblDeck_Click(object sender, EventArgs e)
        {

        }

        private void btnHigher_Click(object sender, EventArgs e)
        {

        }

        private void btnLower_Click(object sender, EventArgs e)
        {

        }

        private void picDeck_Click(object sender, EventArgs e)
        {

            Random rndUser = new Random();
            //if (currentCard > testDeck.Length - 1)
            //{
            //    currentCard = 0;
            //}

            if (picUserCard.Image == picDealer.Image)
            {
                MessageBox.Show("Dupe! image");
                currentCard = rndUser.Next(testDeck.Length);
            }

            if (lblUserCard.Text.Equals(lblOtherCard.Text))
            {
                MessageBox.Show("Dupe! label");
                currentCard = rndUser.Next(testDeck.Length);
            }


            cardImage = testDeck[currentCard].getCardIdentifier();
            lblUserCard.Text = cardImage;
            picUserCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardImage);
            
            currentCard = rndUser.Next(testDeck.Length);


            cardImage = testDeck[currentCard].getCardIdentifier();
            lblOtherCard.Text = cardImage;
            picDealer.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardImage);
            
            currentCard = rndUser.Next(testDeck.Length);

        }
        //end testing
    }
}
