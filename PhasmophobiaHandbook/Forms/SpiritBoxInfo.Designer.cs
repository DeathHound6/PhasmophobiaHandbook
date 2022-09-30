namespace PhasmophobiaHandbook.Forms
{
    partial class SpiritBoxInfo
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
            this.ImgItem = new System.Windows.Forms.PictureBox();
            this.LstQuestions = new System.Windows.Forms.ListBox();
            this.TxtQuestions = new System.Windows.Forms.TextBox();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblStarter = new System.Windows.Forms.Label();
            this.LblLimit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgItem
            // 
            this.ImgItem.Location = new System.Drawing.Point(12, 279);
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.Size = new System.Drawing.Size(478, 229);
            this.ImgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgItem.TabIndex = 23;
            this.ImgItem.TabStop = false;
            // 
            // LstQuestions
            // 
            this.LstQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LstQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstQuestions.FormattingEnabled = true;
            this.LstQuestions.ItemHeight = 24;
            this.LstQuestions.Location = new System.Drawing.Point(497, 57);
            this.LstQuestions.Name = "LstQuestions";
            this.LstQuestions.Size = new System.Drawing.Size(298, 76);
            this.LstQuestions.TabIndex = 21;
            this.LstQuestions.SelectedIndexChanged += new System.EventHandler(this.LstQuestions_SelectedIndexChanged);
            // 
            // TxtQuestions
            // 
            this.TxtQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestions.Location = new System.Drawing.Point(496, 139);
            this.TxtQuestions.Multiline = true;
            this.TxtQuestions.Name = "TxtQuestions";
            this.TxtQuestions.ReadOnly = true;
            this.TxtQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtQuestions.Size = new System.Drawing.Size(299, 369);
            this.TxtQuestions.TabIndex = 20;
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotes.Location = new System.Drawing.Point(180, 57);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ReadOnly = true;
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(310, 216);
            this.TxtNotes.TabIndex = 19;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(259, 6);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(114, 25);
            this.LblName.TabIndex = 18;
            this.LblName.Text = "Spirit Box";
            // 
            // LblStarter
            // 
            this.LblStarter.AutoSize = true;
            this.LblStarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStarter.Location = new System.Drawing.Point(23, 236);
            this.LblStarter.Name = "LblStarter";
            this.LblStarter.Size = new System.Drawing.Size(51, 20);
            this.LblStarter.TabIndex = 31;
            this.LblStarter.Text = "label2";
            // 
            // LblLimit
            // 
            this.LblLimit.AutoSize = true;
            this.LblLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimit.Location = new System.Drawing.Point(23, 163);
            this.LblLimit.Name = "LblLimit";
            this.LblLimit.Size = new System.Drawing.Size(51, 20);
            this.LblLimit.TabIndex = 30;
            this.LblLimit.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Starter Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Limit per Contract";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(21, 93);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(51, 20);
            this.LblPrice.TabIndex = 27;
            this.LblPrice.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Price per item";
            // 
            // SpiritBoxInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 520);
            this.Controls.Add(this.LblStarter);
            this.Controls.Add(this.LblLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImgItem);
            this.Controls.Add(this.LstQuestions);
            this.Controls.Add(this.TxtQuestions);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.LblName);
            this.Name = "SpiritBoxInfo";
            this.Text = "SpiritBoxInfo";
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgItem;
        private System.Windows.Forms.ListBox LstQuestions;
        private System.Windows.Forms.TextBox TxtQuestions;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblStarter;
        private System.Windows.Forms.Label LblLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label1;
    }
}