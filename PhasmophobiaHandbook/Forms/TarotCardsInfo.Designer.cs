namespace PhasmophobiaHandbook.Forms
{
    partial class TarotCardsInfo
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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.ImgItem = new System.Windows.Forms.PictureBox();
            this.ImgCard = new System.Windows.Forms.PictureBox();
            this.LstCards = new System.Windows.Forms.ListBox();
            this.TxtCardDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCard)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(210, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(141, 25);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Ghost Name";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotes.Location = new System.Drawing.Point(12, 298);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ReadOnly = true;
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(220, 271);
            this.TxtNotes.TabIndex = 14;
            // 
            // ImgItem
            // 
            this.ImgItem.Location = new System.Drawing.Point(12, 49);
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.Size = new System.Drawing.Size(220, 243);
            this.ImgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgItem.TabIndex = 18;
            this.ImgItem.TabStop = false;
            // 
            // ImgCard
            // 
            this.ImgCard.Location = new System.Drawing.Point(238, 266);
            this.ImgCard.Name = "ImgCard";
            this.ImgCard.Size = new System.Drawing.Size(250, 303);
            this.ImgCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCard.TabIndex = 19;
            this.ImgCard.TabStop = false;
            // 
            // LstCards
            // 
            this.LstCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LstCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstCards.FormattingEnabled = true;
            this.LstCards.ItemHeight = 24;
            this.LstCards.Location = new System.Drawing.Point(238, 49);
            this.LstCards.Name = "LstCards";
            this.LstCards.Size = new System.Drawing.Size(250, 76);
            this.LstCards.TabIndex = 20;
            this.LstCards.SelectedIndexChanged += new System.EventHandler(this.LstCards_SelectedIndexChanged);
            // 
            // TxtCardDescription
            // 
            this.TxtCardDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCardDescription.ForeColor = System.Drawing.Color.Black;
            this.TxtCardDescription.Location = new System.Drawing.Point(238, 131);
            this.TxtCardDescription.Multiline = true;
            this.TxtCardDescription.Name = "TxtCardDescription";
            this.TxtCardDescription.ReadOnly = true;
            this.TxtCardDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtCardDescription.Size = new System.Drawing.Size(250, 129);
            this.TxtCardDescription.TabIndex = 21;
            // 
            // TarotCardsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 581);
            this.Controls.Add(this.TxtCardDescription);
            this.Controls.Add(this.LstCards);
            this.Controls.Add(this.ImgCard);
            this.Controls.Add(this.ImgItem);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.LblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TarotCardsInfo";
            this.Text = "TarotCardsInfo";
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.PictureBox ImgItem;
        private System.Windows.Forms.PictureBox ImgCard;
        private System.Windows.Forms.ListBox LstCards;
        private System.Windows.Forms.TextBox TxtCardDescription;
    }
}