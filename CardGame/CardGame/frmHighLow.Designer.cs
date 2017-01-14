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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserCard
            // 
            this.lblUserCard.AutoSize = true;
            this.lblUserCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUserCard.Location = new System.Drawing.Point(212, 341);
            this.lblUserCard.Name = "lblUserCard";
            this.lblUserCard.Size = new System.Drawing.Size(51, 13);
            this.lblUserCard.TabIndex = 0;
            this.lblUserCard.Text = "UserCard";
            // 
            // lblOtherCard
            // 
            this.lblOtherCard.AutoSize = true;
            this.lblOtherCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOtherCard.Location = new System.Drawing.Point(212, 124);
            this.lblOtherCard.Name = "lblOtherCard";
            this.lblOtherCard.Size = new System.Drawing.Size(55, 13);
            this.lblOtherCard.TabIndex = 1;
            this.lblOtherCard.Text = "OtherCard";
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDeck.Location = new System.Drawing.Point(385, 230);
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
            this.lblScore.Size = new System.Drawing.Size(47, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmHighLow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.lblOtherCard);
            this.Controls.Add(this.lblUserCard);
            this.Name = "frmHighLow";
            this.Text = "HighLow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCard;
        private System.Windows.Forms.Label lblOtherCard;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}