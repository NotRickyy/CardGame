namespace CardGame
{
    partial class frmHighLow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserCard = new System.Windows.Forms.Label();
            this.lblDealerCard = new System.Windows.Forms.Label();
            this.lblDeck = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.lblScoreNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblLivesNum = new System.Windows.Forms.Label();
            this.picDeck = new System.Windows.Forms.PictureBox();
            this.picDealer = new System.Windows.Forms.PictureBox();
            this.picUserCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserCard
            // 
            this.lblUserCard.AutoSize = true;
            this.lblUserCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUserCard.Location = new System.Drawing.Point(215, 330);
            this.lblUserCard.Name = "lblUserCard";
            this.lblUserCard.Size = new System.Drawing.Size(51, 13);
            this.lblUserCard.TabIndex = 0;
            this.lblUserCard.Text = "UserCard";
            // 
            // lblDealerCard
            // 
            this.lblDealerCard.AutoSize = true;
            this.lblDealerCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDealerCard.Location = new System.Drawing.Point(211, 30);
            this.lblDealerCard.Name = "lblDealerCard";
            this.lblDealerCard.Size = new System.Drawing.Size(60, 13);
            this.lblDealerCard.TabIndex = 1;
            this.lblDealerCard.Text = "DealerCard";
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDeck.Location = new System.Drawing.Point(384, 242);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(33, 13);
            this.lblDeck.TabIndex = 2;
            this.lblDeck.Text = "Deck";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.Location = new System.Drawing.Point(12, 25);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // btnHigher
            // 
            this.btnHigher.Location = new System.Drawing.Point(12, 120);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(75, 23);
            this.btnHigher.TabIndex = 4;
            this.btnHigher.Text = "Higher";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.btnHigher_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(12, 230);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(75, 23);
            this.btnLower.TabIndex = 5;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // lblScoreNum
            // 
            this.lblScoreNum.AutoSize = true;
            this.lblScoreNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScoreNum.Location = new System.Drawing.Point(56, 25);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(13, 13);
            this.lblScoreNum.TabIndex = 6;
            this.lblScoreNum.Text = "0";
            // 
            // btnBack
            // 
            this.btnBack.CausesValidation = false;
            this.btnBack.Location = new System.Drawing.Point(15, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLives.Location = new System.Drawing.Point(12, 46);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(35, 13);
            this.lblLives.TabIndex = 11;
            this.lblLives.Text = "Lives:";
            // 
            // lblLivesNum
            // 
            this.lblLivesNum.AutoSize = true;
            this.lblLivesNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLivesNum.Location = new System.Drawing.Point(54, 46);
            this.lblLivesNum.Name = "lblLivesNum";
            this.lblLivesNum.Size = new System.Drawing.Size(28, 13);
            this.lblLivesNum.TabIndex = 12;
            this.lblLivesNum.Text = "lives";
            // 
            // picDeck
            // 
            this.picDeck.Image = global::CardGame.Properties.Resources.Back1;
            this.picDeck.ImageLocation = "";
            this.picDeck.Location = new System.Drawing.Point(367, 142);
            this.picDeck.Name = "picDeck";
            this.picDeck.Size = new System.Drawing.Size(72, 97);
            this.picDeck.TabIndex = 10;
            this.picDeck.TabStop = false;
            this.picDeck.Click += new System.EventHandler(this.picDeck_Click);
            // 
            // picDealer
            // 
            this.picDealer.Image = global::CardGame.Properties.Resources.Back1;
            this.picDealer.Location = new System.Drawing.Point(204, 46);
            this.picDealer.Name = "picDealer";
            this.picDealer.Size = new System.Drawing.Size(72, 97);
            this.picDealer.TabIndex = 9;
            this.picDealer.TabStop = false;
            // 
            // picUserCard
            // 
            this.picUserCard.Image = global::CardGame.Properties.Resources.Back1;
            this.picUserCard.Location = new System.Drawing.Point(204, 230);
            this.picUserCard.Name = "picUserCard";
            this.picUserCard.Size = new System.Drawing.Size(72, 97);
            this.picUserCard.TabIndex = 8;
            this.picUserCard.TabStop = false;
            // 
            // frmHighLow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblLivesNum);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.picDeck);
            this.Controls.Add(this.picDealer);
            this.Controls.Add(this.picUserCard);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblScoreNum);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.lblDealerCard);
            this.Controls.Add(this.lblUserCard);
            this.Name = "frmHighLow";
            this.Text = "HighLow";
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCard;
        private System.Windows.Forms.Label lblDealerCard;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Label lblScoreNum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picUserCard;
        private System.Windows.Forms.PictureBox picDealer;
        private System.Windows.Forms.PictureBox picDeck;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblLivesNum;
    }
}