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
            this.lblOtherCard = new System.Windows.Forms.Label();
            this.lblDeck = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.lblScoreNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.picUserCard = new System.Windows.Forms.PictureBox();
            this.picDealer = new System.Windows.Forms.PictureBox();
            this.picDeck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).BeginInit();
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
            // lblOtherCard
            // 
            this.lblOtherCard.AutoSize = true;
            this.lblOtherCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOtherCard.Location = new System.Drawing.Point(211, 30);
            this.lblOtherCard.Name = "lblOtherCard";
            this.lblOtherCard.Size = new System.Drawing.Size(55, 13);
            this.lblOtherCard.TabIndex = 1;
            this.lblOtherCard.Text = "OtherCard";
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
            this.lblDeck.Click += new System.EventHandler(this.lblDeck_Click);
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
            // picUserCard
            // 
            this.picUserCard.Image = global::CardGame.Properties.Resources.Back;
            this.picUserCard.Location = new System.Drawing.Point(204, 230);
            this.picUserCard.Name = "picUserCard";
            this.picUserCard.Size = new System.Drawing.Size(72, 97);
            this.picUserCard.TabIndex = 8;
            this.picUserCard.TabStop = false;
            this.picUserCard.Click += new System.EventHandler(this.picUserCard_Click);
            // 
            // picDealer
            // 
            this.picDealer.Image = global::CardGame.Properties.Resources.Back;
            this.picDealer.Location = new System.Drawing.Point(204, 46);
            this.picDealer.Name = "picDealer";
            this.picDealer.Size = new System.Drawing.Size(72, 97);
            this.picDealer.TabIndex = 9;
            this.picDealer.TabStop = false;
            // 
            // picDeck
            // 
            this.picDeck.Image = global::CardGame.Properties.Resources.Back;
            this.picDeck.ImageLocation = "";
            this.picDeck.Location = new System.Drawing.Point(367, 142);
            this.picDeck.Name = "picDeck";
            this.picDeck.Size = new System.Drawing.Size(72, 97);
            this.picDeck.TabIndex = 10;
            this.picDeck.TabStop = false;
            this.picDeck.Click += new System.EventHandler(this.picDeck_Click);
            // 
            // frmHighLow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.picDeck);
            this.Controls.Add(this.picDealer);
            this.Controls.Add(this.picUserCard);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblScoreNum);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.lblOtherCard);
            this.Controls.Add(this.lblUserCard);
            this.Name = "frmHighLow";
            this.Text = "HighLow";
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCard;
        private System.Windows.Forms.Label lblOtherCard;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Label lblScoreNum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picUserCard;
        private System.Windows.Forms.PictureBox picDealer;
        private System.Windows.Forms.PictureBox picDeck;
    }
}