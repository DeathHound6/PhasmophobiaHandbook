namespace PhasmophobiaHandbook.Forms
{
    partial class AllCursedItems
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
            this.BtnMusic = new System.Windows.Forms.Button();
            this.BtnOujia = new System.Windows.Forms.Button();
            this.BtnTarots = new System.Windows.Forms.Button();
            this.BtnMirror = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.BtnDoll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(107, 19);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(184, 25);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "All Cursed Items";
            // 
            // BtnMusic
            // 
            this.BtnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMusic.Location = new System.Drawing.Point(45, 70);
            this.BtnMusic.Name = "BtnMusic";
            this.BtnMusic.Size = new System.Drawing.Size(123, 73);
            this.BtnMusic.TabIndex = 8;
            this.BtnMusic.Text = "Music Box";
            this.BtnMusic.UseVisualStyleBackColor = true;
            this.BtnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // BtnOujia
            // 
            this.BtnOujia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOujia.Location = new System.Drawing.Point(45, 167);
            this.BtnOujia.Name = "BtnOujia";
            this.BtnOujia.Size = new System.Drawing.Size(123, 73);
            this.BtnOujia.TabIndex = 9;
            this.BtnOujia.Text = "Oujia Board";
            this.BtnOujia.UseVisualStyleBackColor = true;
            this.BtnOujia.Click += new System.EventHandler(this.BtnOujia_Click);
            // 
            // BtnTarots
            // 
            this.BtnTarots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarots.Location = new System.Drawing.Point(45, 259);
            this.BtnTarots.Name = "BtnTarots";
            this.BtnTarots.Size = new System.Drawing.Size(123, 73);
            this.BtnTarots.TabIndex = 10;
            this.BtnTarots.Text = "Tarot Cards";
            this.BtnTarots.UseVisualStyleBackColor = true;
            this.BtnTarots.Click += new System.EventHandler(this.BtnTarots_Click);
            // 
            // BtnMirror
            // 
            this.BtnMirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMirror.Location = new System.Drawing.Point(205, 70);
            this.BtnMirror.Name = "BtnMirror";
            this.BtnMirror.Size = new System.Drawing.Size(123, 73);
            this.BtnMirror.TabIndex = 11;
            this.BtnMirror.Text = "Haunted Mirror";
            this.BtnMirror.UseVisualStyleBackColor = true;
            this.BtnMirror.Click += new System.EventHandler(this.BtnMirror_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCircle.Location = new System.Drawing.Point(205, 167);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(123, 73);
            this.BtnCircle.TabIndex = 12;
            this.BtnCircle.Text = "Summoning Circle";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // BtnDoll
            // 
            this.BtnDoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoll.Location = new System.Drawing.Point(205, 259);
            this.BtnDoll.Name = "BtnDoll";
            this.BtnDoll.Size = new System.Drawing.Size(123, 73);
            this.BtnDoll.TabIndex = 13;
            this.BtnDoll.Text = "Voodoo Doll";
            this.BtnDoll.UseVisualStyleBackColor = true;
            this.BtnDoll.Click += new System.EventHandler(this.BtnDoll_Click);
            // 
            // AllCursedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 362);
            this.Controls.Add(this.BtnDoll);
            this.Controls.Add(this.BtnCircle);
            this.Controls.Add(this.BtnMirror);
            this.Controls.Add(this.BtnTarots);
            this.Controls.Add(this.BtnOujia);
            this.Controls.Add(this.BtnMusic);
            this.Controls.Add(this.LblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AllCursedItems";
            this.Text = "AllCursedItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnMusic;
        private System.Windows.Forms.Button BtnOujia;
        private System.Windows.Forms.Button BtnTarots;
        private System.Windows.Forms.Button BtnMirror;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.Button BtnDoll;
    }
}