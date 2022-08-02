namespace KRJellyBelly
{
    partial class CategoryCount
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
            this.CategoryListView = new System.Windows.Forms.ListView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryListView
            // 
            this.CategoryListView.HideSelection = false;
            this.CategoryListView.Location = new System.Drawing.Point(12, 12);
            this.CategoryListView.Name = "CategoryListView";
            this.CategoryListView.Size = new System.Drawing.Size(431, 404);
            this.CategoryListView.TabIndex = 0;
            this.CategoryListView.UseCompatibleStateImageBehavior = false;
            this.CategoryListView.View = System.Windows.Forms.View.Details;
            this.CategoryListView.SelectedIndexChanged += new System.EventHandler(this.CategoryListView_SelectedIndexChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(58, 442);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(330, 75);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CategoryCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(455, 556);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CategoryListView);
            this.Name = "CategoryCount";
            this.Text = "CategoryCount";
            this.Load += new System.EventHandler(this.CategoryCount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CategoryListView;
        private System.Windows.Forms.Button BtnClose;
    }
}