namespace KRJellyBelly
{
    partial class LandingForm 
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
            this.BtnShowJBFlavors = new System.Windows.Forms.Button();
            this.BtnShowCategories = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowJBFlavors
            // 
            this.BtnShowJBFlavors.BackColor = System.Drawing.Color.IndianRed;
            this.BtnShowJBFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowJBFlavors.Location = new System.Drawing.Point(134, 422);
            this.BtnShowJBFlavors.Name = "BtnShowJBFlavors";
            this.BtnShowJBFlavors.Size = new System.Drawing.Size(198, 93);
            this.BtnShowJBFlavors.TabIndex = 1;
            this.BtnShowJBFlavors.Text = "Show Jelly Bean Flavors";
            this.BtnShowJBFlavors.UseVisualStyleBackColor = false;
            this.BtnShowJBFlavors.Click += new System.EventHandler(this.BtnShowJBFlavors_Click);
            // 
            // BtnShowCategories
            // 
            this.BtnShowCategories.BackColor = System.Drawing.Color.IndianRed;
            this.BtnShowCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowCategories.Location = new System.Drawing.Point(479, 422);
            this.BtnShowCategories.Name = "BtnShowCategories";
            this.BtnShowCategories.Size = new System.Drawing.Size(197, 93);
            this.BtnShowCategories.TabIndex = 2;
            this.BtnShowCategories.Text = "Show Categories";
            this.BtnShowCategories.UseVisualStyleBackColor = false;
            this.BtnShowCategories.Click += new System.EventHandler(this.BtnShowCategories_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KRJellyBelly.Properties.Resources.jellybellyPic;
            this.pictureBox1.Location = new System.Drawing.Point(57, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(854, 527);
            this.Controls.Add(this.BtnShowCategories);
            this.Controls.Add(this.BtnShowJBFlavors);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LandingForm";
            this.Text = "Landing Form";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnShowJBFlavors;
        private System.Windows.Forms.Button BtnShowCategories;
    }
}

