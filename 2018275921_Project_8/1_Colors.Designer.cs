namespace _2018275921_Project_8
{
    partial class Colors
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
            this.btnSpawnObserver = new System.Windows.Forms.Button();
            this.btnRedColor = new System.Windows.Forms.Button();
            this.btnBlueColor = new System.Windows.Forms.Button();
            this.btnGreenColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpawnObserver
            // 
            this.btnSpawnObserver.Location = new System.Drawing.Point(12, 12);
            this.btnSpawnObserver.Name = "btnSpawnObserver";
            this.btnSpawnObserver.Size = new System.Drawing.Size(161, 63);
            this.btnSpawnObserver.TabIndex = 0;
            this.btnSpawnObserver.Text = "Spawn Observer";
            this.btnSpawnObserver.UseVisualStyleBackColor = true;
            this.btnSpawnObserver.Click += new System.EventHandler(this.btnSpawnObserver_Click);
            // 
            // btnRedColor
            // 
            this.btnRedColor.BackColor = System.Drawing.Color.Red;
            this.btnRedColor.Location = new System.Drawing.Point(12, 81);
            this.btnRedColor.Name = "btnRedColor";
            this.btnRedColor.Size = new System.Drawing.Size(161, 41);
            this.btnRedColor.TabIndex = 1;
            this.btnRedColor.UseVisualStyleBackColor = false;
            this.btnRedColor.Click += new System.EventHandler(this.btnRedColor_Click);
            // 
            // btnBlueColor
            // 
            this.btnBlueColor.BackColor = System.Drawing.Color.Blue;
            this.btnBlueColor.Location = new System.Drawing.Point(12, 169);
            this.btnBlueColor.Name = "btnBlueColor";
            this.btnBlueColor.Size = new System.Drawing.Size(161, 38);
            this.btnBlueColor.TabIndex = 2;
            this.btnBlueColor.UseVisualStyleBackColor = false;
            this.btnBlueColor.Click += new System.EventHandler(this.btnBlueColor_Click);
            // 
            // btnGreenColor
            // 
            this.btnGreenColor.BackColor = System.Drawing.Color.Lime;
            this.btnGreenColor.Location = new System.Drawing.Point(12, 128);
            this.btnGreenColor.Name = "btnGreenColor";
            this.btnGreenColor.Size = new System.Drawing.Size(161, 35);
            this.btnGreenColor.TabIndex = 3;
            this.btnGreenColor.UseVisualStyleBackColor = false;
            this.btnGreenColor.Click += new System.EventHandler(this.btnGreenColor_Click);
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 219);
            this.Controls.Add(this.btnGreenColor);
            this.Controls.Add(this.btnBlueColor);
            this.Controls.Add(this.btnRedColor);
            this.Controls.Add(this.btnSpawnObserver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Colors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUBLISHER";
            this.Load += new System.EventHandler(this.Publisher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpawnObserver;
        private System.Windows.Forms.Button btnRedColor;
        private System.Windows.Forms.Button btnBlueColor;
        private System.Windows.Forms.Button btnGreenColor;
    }
}

