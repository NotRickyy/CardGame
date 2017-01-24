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
        Card[] deck;
        String cardImage;

        Random rndUser = new Random();
        int userCard, dealerCard;
        int lives, score;
        Boolean dealt;

        public frmHighLow()
        {
            InitializeComponent();

            dealt = false;
            score = 0;
            lives = 3;
            update();

            deck = new Card[52];
            int suit = 1;
            int value = 1; 
            for (int i=0; i < deck.Length; i++) {
                deck[i] = new Card(suit, value);
                value++;
                if (value == 14)
                {
                    value = 1;
                    suit++;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCardGame cardGame = new frmCardGame();
            cardGame.Show();
            Close();

        }

        private void btnHigher_Click(object sender, EventArgs e)
        {
            if (dealt == true)
            {
                showCard(picDealer, dealerCard, lblDealerCard);
                if (deck[userCard].compare(deck[dealerCard]).Equals("Higher"))
                {
                    MessageBox.Show("The card was higher, you win!");
                    score += 100;
                }
                else
                {
                    MessageBox.Show("The card was lower, you lose!");
                    lives--;
                }

                update();
                dealt = false;
            }
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            if (dealt == true)
            {
                showCard(picDealer, dealerCard, lblDealerCard);
                if (deck[userCard].compare(deck[dealerCard]).Equals("Higher"))
                {
                    MessageBox.Show("The card was higher, you lose!");
                    lives--;
                }
                else
                {
                    MessageBox.Show("The card was lower, you win!");
                    score += 100;
                }

                update();
                dealt = false;
            }
        }

        private void picDeck_Click(object sender, EventArgs e)
        {
            if (dealt == false)
            {
                picDealer.Image = (Image)Properties.Resources.ResourceManager.GetObject("Back1");
                userCard = rndUser.Next(deck.Length);
                //cardImage = deck[userCard].getCardIdentifier();
                //lblUserCard.Text = cardImage;
                //picUserCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardImage);
                showCard(picUserCard, userCard, lblUserCard);

                dealerCard = rndUser.Next(deck.Length);
                while (userCard == dealerCard)
                {
                    dealerCard = rndUser.Next(deck.Length);
                }
                update();
                dealt = true;
            }
            //cardImage = deck[otherCard].getCardIdentifier();
            //lblOtherCard.Text = cardImage;
            //picDealer.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardImage);

            //if (userCard == otherCard)
            //{
            //    otherCard = rndUser.Next(deck.Length);
            //    MessageBox.Show("Dupe! image");
            //}

        }
       
        public void showCard(PictureBox pic, int cardIndex, Label label)
        {
            cardImage = deck[cardIndex].getCardIdentifier();
            label.Text = cardImage;
            pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardImage);
        }

        public void update()
        {
            lblLivesNum.Text = "" + lives;
            lblScoreNum.Text = "" + score;
            if (lives < 1)
            {
                MessageBox.Show("YOU LOSE \nFINAL SCORE: " + score);
                btnBack.PerformClick();
            }
        }
    }
}
