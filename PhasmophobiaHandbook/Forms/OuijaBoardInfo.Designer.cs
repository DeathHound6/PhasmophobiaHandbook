namespace PhasmophobiaHandbook.Forms
{
    partial class OuijaBoardInfo
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
            this.TxtQuestions = new System.Windows.Forms.TextBox();
            this.LstQuestions = new System.Windows.Forms.ListBox();
            this.TxtQuestionDescription = new System.Windows.Forms.TextBox();
            this.ImgItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(257, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(141, 25);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Ghost Name";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotes.Location = new System.Drawing.Point(12, 190);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ReadOnly = true;
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(310, 315);
            this.TxtNotes.TabIndex = 13;
            // 
            // TxtQuestions
            // 
            this.TxtQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestions.Location = new System.Drawing.Point(328, 271);
            this.TxtQuestions.Multiline = true;
            this.TxtQuestions.Name = "TxtQuestions";
            this.TxtQuestions.ReadOnly = true;
            this.TxtQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtQuestions.Size = new System.Drawing.Size(299, 234);
            this.TxtQuestions.TabIndex = 14;
            // 
            // LstQuestions
            // 
            this.LstQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LstQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstQuestions.FormattingEnabled = true;
            this.LstQuestions.ItemHeight = 24;
            this.LstQuestions.Location = new System.Drawing.Point(329, 54);
            this.LstQuestions.Name = "LstQuestions";
            this.LstQuestions.Size = new System.Drawing.Size(298, 76);
            this.LstQuestions.TabIndex = 15;
            this.LstQuestions.SelectedIndexChanged += new System.EventHandler(this.LstQuestions_SelectedIndexChanged);
            // 
            // TxtQuestionDescription
            // 
            this.TxtQuestionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestionDescription.Location = new System.Drawing.Point(328, 136);
            this.TxtQuestionDescription.Multiline = true;
            this.TxtQuestionDescription.Name = "TxtQuestionDescription";
            this.TxtQuestionDescription.ReadOnly = true;
            this.TxtQuestionDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtQuestionDescription.Size = new System.Drawing.Size(298, 129);
            this.TxtQuestionDescription.TabIndex = 16;
            // 
            // ImgItem
            // 
            this.ImgItem.Location = new System.Drawing.Point(12, 54);
            this.ImgItem.Name = "ImgItem";
            this.ImgItem.Size = new System.Drawing.Size(310, 130);
            this.ImgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgItem.TabIndex = 17;
            this.ImgItem.TabStop = false;
            // 
            // OuijaBoardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 517);
            this.Controls.Add(this.ImgItem);
            this.Controls.Add(this.TxtQuestionDescription);
            this.Controls.Add(this.LstQuestions);
            this.Controls.Add(this.TxtQuestions);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.LblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OuijaBoardInfo";
            this.Text = "OuijaBoardInfo";
            ((System.ComponentModel.ISupportInitialize)(this.ImgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.TextBox TxtQuestions;
        private System.Windows.Forms.ListBox LstQuestions;
        private System.Windows.Forms.TextBox TxtQuestionDescription;
        private System.Windows.Forms.PictureBox ImgItem;
    }
}