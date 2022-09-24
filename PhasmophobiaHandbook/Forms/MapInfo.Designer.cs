namespace PhasmophobiaHandbook.Forms
{
    partial class MapInfo
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
            this.ImgMapOne = new System.Windows.Forms.PictureBox();
            this.LblSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMapOne)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgMapOne
            // 
            this.ImgMapOne.Location = new System.Drawing.Point(0, 0);
            this.ImgMapOne.Name = "ImgMapOne";
            this.ImgMapOne.Size = new System.Drawing.Size(485, 271);
            this.ImgMapOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgMapOne.TabIndex = 3;
            this.ImgMapOne.TabStop = false;
            // 
            // LblSize
            // 
            this.LblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSize.AutoSize = true;
            this.LblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblSize.Location = new System.Drawing.Point(12, 9);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(57, 20);
            this.LblSize.TabIndex = 4;
            this.LblSize.Text = "label1";
            // 
            // MapInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.ImgMapOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MapInfo";
            this.Text = "MapInfo";
            ((System.ComponentModel.ISupportInitialize)(this.ImgMapOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ImgMapOne;
        private System.Windows.Forms.Label LblSize;
    }
}