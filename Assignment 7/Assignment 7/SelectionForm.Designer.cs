namespace Assignment_7
{
    partial class SelectionForm
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
            this.MovieDropdownList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectTitleBox = new System.Windows.Forms.TextBox();
            this.SelectCategoryBox = new System.Windows.Forms.TextBox();
            this.SelectCostBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.SelectionPicture = new System.Windows.Forms.PictureBox();
            this.SelectionNextButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieDropdownList
            // 
            this.MovieDropdownList.AccessibleName = "Movie dropdown list";
            this.MovieDropdownList.DropDownWidth = 130;
            this.MovieDropdownList.FormattingEnabled = true;
            this.MovieDropdownList.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemna",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roomate",
            "The Way Back",
            "Waiting for Forever"});
            this.MovieDropdownList.Location = new System.Drawing.Point(24, 92);
            this.MovieDropdownList.MaxDropDownItems = 20;
            this.MovieDropdownList.Name = "MovieDropdownList";
            this.MovieDropdownList.Size = new System.Drawing.Size(121, 26);
            this.MovieDropdownList.Sorted = true;
            this.MovieDropdownList.TabIndex = 0;
            this.MovieDropdownList.SelectedIndexChanged += new System.EventHandler(this.MovieDropdownList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectionPicture);
            this.groupBox1.Controls.Add(this.CostLabel);
            this.groupBox1.Controls.Add(this.CategoryLabel);
            this.groupBox1.Controls.Add(this.TitleLabel);
            this.groupBox1.Controls.Add(this.SelectCostBox);
            this.groupBox1.Controls.Add(this.SelectCategoryBox);
            this.groupBox1.Controls.Add(this.SelectTitleBox);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(182, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Selection";
            // 
            // SelectTitleBox
            // 
            this.SelectTitleBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTitleBox.Location = new System.Drawing.Point(21, 68);
            this.SelectTitleBox.Name = "SelectTitleBox";
            this.SelectTitleBox.ReadOnly = true;
            this.SelectTitleBox.Size = new System.Drawing.Size(147, 32);
            this.SelectTitleBox.TabIndex = 0;
            // 
            // SelectCategoryBox
            // 
            this.SelectCategoryBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategoryBox.Location = new System.Drawing.Point(195, 68);
            this.SelectCategoryBox.Name = "SelectCategoryBox";
            this.SelectCategoryBox.ReadOnly = true;
            this.SelectCategoryBox.Size = new System.Drawing.Size(147, 32);
            this.SelectCategoryBox.TabIndex = 1;
            // 
            // SelectCostBox
            // 
            this.SelectCostBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCostBox.Location = new System.Drawing.Point(21, 145);
            this.SelectCostBox.Name = "SelectCostBox";
            this.SelectCostBox.ReadOnly = true;
            this.SelectCostBox.Size = new System.Drawing.Size(147, 32);
            this.SelectCostBox.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(17, 41);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(47, 24);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(191, 41);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(84, 24);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Category";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(17, 118);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(166, 24);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Download Cost ($)";
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLabel.Location = new System.Drawing.Point(19, 41);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(157, 29);
            this.SelectLabel.TabIndex = 2;
            this.SelectLabel.Text = "Select a Movie";
            // 
            // SelectionPicture
            // 
            this.SelectionPicture.InitialImage = null;
            this.SelectionPicture.Location = new System.Drawing.Point(53, 183);
            this.SelectionPicture.Name = "SelectionPicture";
            this.SelectionPicture.Size = new System.Drawing.Size(252, 273);
            this.SelectionPicture.TabIndex = 6;
            this.SelectionPicture.TabStop = false;
            // 
            // SelectionNextButton
            // 
            this.SelectionNextButton.Enabled = false;
            this.SelectionNextButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionNextButton.Location = new System.Drawing.Point(24, 453);
            this.SelectionNextButton.Name = "SelectionNextButton";
            this.SelectionNextButton.Size = new System.Drawing.Size(100, 38);
            this.SelectionNextButton.TabIndex = 3;
            this.SelectionNextButton.Text = "Next";
            this.SelectionNextButton.UseVisualStyleBackColor = true;
            this.SelectionNextButton.Click += new System.EventHandler(this.SelectionNextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 503);
            this.ControlBox = false;
            this.Controls.Add(this.SelectionNextButton);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MovieDropdownList);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Form";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MovieDropdownList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SelectCostBox;
        private System.Windows.Forms.TextBox SelectCategoryBox;
        private System.Windows.Forms.TextBox SelectTitleBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.PictureBox SelectionPicture;
        private System.Windows.Forms.Button SelectionNextButton;
    }
}

