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

        public frmHighLow()
        {
            InitializeComponent();

            //test
            currentCard = 0;
            testDeck = new Card[13];
            for (int i=0; i < testDeck.Length; i++) {
                testDeck[i] = new Card(3, i + 1);
            }
            cardImage = testDeck[0].getCardIdentifier();
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
    }
}
