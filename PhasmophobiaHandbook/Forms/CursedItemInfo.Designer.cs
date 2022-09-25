namespace PhasmophobiaHandbook.Forms
{
    partial class CursedItemInfo
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
            this.ImgItem = new System.Windows.Forms.PictureBox();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(328, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(123, 25);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Item Name";
            // 
            // ImgItem
            // 
            this.ImgItem.Location = new System.Drawing.Point(412, 72);
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.Size = new System.Drawing.Size(376, 346);
            this.ImgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgItem.TabIndex = 3;
            this.ImgItem.TabStop = false;
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotes.Location = new System.Drawing.Point(22, 72);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ReadOnly = true;
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(373, 346);
            this.TxtNotes.TabIndex = 13;
            // 
            // CursedItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.ImgItem);
            this.Controls.Add(this.LblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CursedItemInfo";
            this.Text = "CursedItemInfo";
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox ImgItem;
        private System.Windows.Forms.TextBox TxtNotes;
    }
}