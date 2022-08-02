namespace KRJellyBelly
{
    partial class SearchJellyBeans
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
            this.DgvJellyBellies = new System.Windows.Forms.DataGridView();
            this.LblSearch = new System.Windows.Forms.Label();
            this.LblFilterByCategory = new System.Windows.Forms.Label();
            this.TxtJellySearch = new System.Windows.Forms.TextBox();
            this.CboFilterByCategory = new System.Windows.Forms.ComboBox();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJellyBellies)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvJellyBellies
            // 
            this.DgvJellyBellies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJellyBellies.Location = new System.Drawing.Point(21, 12);
            this.DgvJellyBellies.Name = "DgvJellyBellies";
            this.DgvJellyBellies.RowHeadersWidth = 51;
            this.DgvJellyBellies.RowTemplate.Height = 24;
            this.DgvJellyBellies.Size = new System.Drawing.Size(747, 361);
            this.DgvJellyBellies.TabIndex = 0;
            this.DgvJellyBellies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJellyBellies_CellContentClick);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.BackColor = System.Drawing.Color.PeachPuff;
            this.LblSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(153, 414);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(88, 25);
            this.LblSearch.TabIndex = 1;
            this.LblSearch.Text = "Search:";
            // 
            // LblFilterByCategory
            // 
            this.LblFilterByCategory.AutoSize = true;
            this.LblFilterByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilterByCategory.Location = new System.Drawing.Point(51, 473);
            this.LblFilterByCategory.Name = "LblFilterByCategory";
            this.LblFilterByCategory.Size = new System.Drawing.Size(190, 25);
            this.LblFilterByCategory.TabIndex = 2;
            this.LblFilterByCategory.Text = "Filter by Category:";
            // 
            // TxtJellySearch
            // 
            this.TxtJellySearch.Location = new System.Drawing.Point(263, 418);
            this.TxtJellySearch.Multiline = true;
            this.TxtJellySearch.Name = "TxtJellySearch";
            this.TxtJellySearch.Size = new System.Drawing.Size(283, 35);
            this.TxtJellySearch.TabIndex = 3;
            this.TxtJellySearch.TextChanged += new System.EventHandler(this.TxtJellySearch_TextChanged);
            // 
            // CboFilterByCategory
            // 
            this.CboFilterByCategory.FormattingEnabled = true;
            this.CboFilterByCategory.Location = new System.Drawing.Point(263, 477);
            this.CboFilterByCategory.Name = "CboFilterByCategory";
            this.CboFilterByCategory.Size = new System.Drawing.Size(283, 24);
            this.CboFilterByCategory.TabIndex = 4;
            this.CboFilterByCategory.SelectedIndexChanged += new System.EventHandler(this.CboFilterByCategory_SelectedIndexChanged);
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.BackColor = System.Drawing.Color.IndianRed;
            this.BtnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowAll.Location = new System.Drawing.Point(600, 414);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(136, 42);
            this.BtnShowAll.TabIndex = 5;
            this.BtnShowAll.Text = "Show All";
            this.BtnShowAll.UseVisualStyleBackColor = false;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(600, 473);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(136, 42);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // SearchJellyBeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnShowAll);
            this.Controls.Add(this.CboFilterByCategory);
            this.Controls.Add(this.TxtJellySearch);
            this.Controls.Add(this.LblFilterByCategory);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.DgvJellyBellies);
            this.Name = "SearchJellyBeans";
            this.Text = "SearchJellyBeans";
            this.Load += new System.EventHandler(this.SearchJellyBeans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJellyBellies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvJellyBellies;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Label LblFilterByCategory;
        private System.Windows.Forms.TextBox TxtJellySearch;
        private System.Windows.Forms.ComboBox CboFilterByCategory;
        private System.Windows.Forms.Button BtnShowAll;
        private System.Windows.Forms.Button BtnClose;
    }
}