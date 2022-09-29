namespace PhasmophobiaHandbook.Forms
{
    partial class ItemInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLimit = new System.Windows.Forms.Label();
            this.LblStarter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(185, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(141, 25);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Ghost Name";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotes.Location = new System.Drawing.Point(311, 75);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ReadOnly = true;
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(319, 404);
            this.TxtNotes.TabIndex = 13;
            // 
            // ImgItem
            // 
            this.ImgItem.Location = new System.Drawing.Point(18, 296);
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.Size = new System.Drawing.Size(265, 183);
            this.ImgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgItem.TabIndex = 19;
            this.ImgItem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Price per item";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(12, 108);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(51, 20);
            this.LblPrice.TabIndex = 21;
            this.LblPrice.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Limit per Contract";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Starter Item";
            // 
            // LblLimit
            // 
            this.LblLimit.AutoSize = true;
            this.LblLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimit.Location = new System.Drawing.Point(14, 178);
            this.LblLimit.Name = "LblLimit";
            this.LblLimit.Size = new System.Drawing.Size(51, 20);
            this.LblLimit.TabIndex = 24;
            this.LblLimit.Text = "label2";
            // 
            // LblStarter
            // 
            this.LblStarter.AutoSize = true;
            this.LblStarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStarter.Location = new System.Drawing.Point(14, 251);
            this.LblStarter.Name = "LblStarter";
            this.LblStarter.Size = new System.Drawing.Size(51, 20);
            this.LblStarter.TabIndex = 25;
            this.LblStarter.Text = "label2";
            // 
            // ItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 524);
            this.Controls.Add(this.LblStarter);
            this.Controls.Add(this.LblLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImgItem);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.LblName);
            this.Name = "ItemInfo";
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.PictureBox ImgItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblLimit;
        private System.Windows.Forms.Label LblStarter;
    }
}