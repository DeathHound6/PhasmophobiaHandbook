namespace PhasmophobiaHandbook
{
    partial class Menu
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
            this.BtnGhosts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMaps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGhosts
            // 
            this.BtnGhosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGhosts.Location = new System.Drawing.Point(158, 84);
            this.BtnGhosts.Name = "BtnGhosts";
            this.BtnGhosts.Size = new System.Drawing.Size(109, 68);
            this.BtnGhosts.TabIndex = 0;
            this.BtnGhosts.Text = "Ghosts";
            this.BtnGhosts.UseVisualStyleBackColor = true;
            this.BtnGhosts.Click += new System.EventHandler(this.BtnGhosts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phasmophobia Handbook";
            // 
            // BtnMaps
            // 
            this.BtnMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaps.Location = new System.Drawing.Point(319, 84);
            this.BtnMaps.Name = "BtnMaps";
            this.BtnMaps.Size = new System.Drawing.Size(109, 68);
            this.BtnMaps.TabIndex = 2;
            this.BtnMaps.Text = "Maps";
            this.BtnMaps.UseVisualStyleBackColor = true;
            this.BtnMaps.Click += new System.EventHandler(this.BtnMaps_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMaps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGhosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGhosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMaps;
    }
}

