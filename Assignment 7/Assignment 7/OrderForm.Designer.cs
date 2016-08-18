namespace Assignment_7
{
    partial class OrderForm
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
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderStreamButton = new System.Windows.Forms.Button();
            this.OrderBackButton = new System.Windows.Forms.Button();
            this.OrderCancelButton = new System.Windows.Forms.Button();
            this.OrderMovieBox = new System.Windows.Forms.GroupBox();
            this.OrderOrderBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovieCostBox = new System.Windows.Forms.TextBox();
            this.SubtotalBox = new System.Windows.Forms.TextBox();
            this.MovieBuyBox = new System.Windows.Forms.TextBox();
            this.SalestaxBox = new System.Windows.Forms.TextBox();
            this.GrandTotalBox = new System.Windows.Forms.TextBox();
            this.MovieCostLabel = new System.Windows.Forms.Label();
            this.BuyMovieLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.SalestaxLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.BuyMovieCheckbox = new System.Windows.Forms.CheckBox();
            this.OrderMenuStrip.SuspendLayout();
            this.OrderMovieBox.SuspendLayout();
            this.OrderOrderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(557, 28);
            this.OrderMenuStrip.TabIndex = 0;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // OrderStreamButton
            // 
            this.OrderStreamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderStreamButton.Location = new System.Drawing.Point(236, 454);
            this.OrderStreamButton.Name = "OrderStreamButton";
            this.OrderStreamButton.Size = new System.Drawing.Size(106, 37);
            this.OrderStreamButton.TabIndex = 1;
            this.OrderStreamButton.Text = "Stream";
            this.OrderStreamButton.UseVisualStyleBackColor = true;
            // 
            // OrderBackButton
            // 
            this.OrderBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBackButton.Location = new System.Drawing.Point(124, 454);
            this.OrderBackButton.Name = "OrderBackButton";
            this.OrderBackButton.Size = new System.Drawing.Size(106, 37);
            this.OrderBackButton.TabIndex = 2;
            this.OrderBackButton.Text = "Back";
            this.OrderBackButton.UseVisualStyleBackColor = true;
            // 
            // OrderCancelButton
            // 
            this.OrderCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCancelButton.Location = new System.Drawing.Point(12, 454);
            this.OrderCancelButton.Name = "OrderCancelButton";
            this.OrderCancelButton.Size = new System.Drawing.Size(106, 37);
            this.OrderCancelButton.TabIndex = 3;
            this.OrderCancelButton.Text = "Cancel";
            this.OrderCancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderMovieBox
            // 
            this.OrderMovieBox.Controls.Add(this.pictureBox1);
            this.OrderMovieBox.Controls.Add(this.textBox2);
            this.OrderMovieBox.Controls.Add(this.textBox1);
            this.OrderMovieBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderMovieBox.Location = new System.Drawing.Point(12, 54);
            this.OrderMovieBox.Name = "OrderMovieBox";
            this.OrderMovieBox.Size = new System.Drawing.Size(252, 372);
            this.OrderMovieBox.TabIndex = 4;
            this.OrderMovieBox.TabStop = false;
            this.OrderMovieBox.Text = "Movie Selected";
            // 
            // OrderOrderBox
            // 
            this.OrderOrderBox.Controls.Add(this.BuyMovieCheckbox);
            this.OrderOrderBox.Controls.Add(this.GrandTotalLabel);
            this.OrderOrderBox.Controls.Add(this.SalestaxLabel);
            this.OrderOrderBox.Controls.Add(this.SubtotalLabel);
            this.OrderOrderBox.Controls.Add(this.BuyMovieLabel);
            this.OrderOrderBox.Controls.Add(this.MovieCostLabel);
            this.OrderOrderBox.Controls.Add(this.GrandTotalBox);
            this.OrderOrderBox.Controls.Add(this.SalestaxBox);
            this.OrderOrderBox.Controls.Add(this.MovieBuyBox);
            this.OrderOrderBox.Controls.Add(this.SubtotalBox);
            this.OrderOrderBox.Controls.Add(this.MovieCostBox);
            this.OrderOrderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderOrderBox.Location = new System.Drawing.Point(280, 54);
            this.OrderOrderBox.Name = "OrderOrderBox";
            this.OrderOrderBox.Size = new System.Drawing.Size(265, 372);
            this.OrderOrderBox.TabIndex = 5;
            this.OrderOrderBox.TabStop = false;
            this.OrderOrderBox.Text = "Your Order";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 24);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 24);
            this.textBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 257);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MovieCostBox
            // 
            this.MovieCostBox.Location = new System.Drawing.Point(15, 56);
            this.MovieCostBox.Name = "MovieCostBox";
            this.MovieCostBox.ReadOnly = true;
            this.MovieCostBox.Size = new System.Drawing.Size(119, 24);
            this.MovieCostBox.TabIndex = 1;
            // 
            // SubtotalBox
            // 
            this.SubtotalBox.Location = new System.Drawing.Point(15, 177);
            this.SubtotalBox.Name = "SubtotalBox";
            this.SubtotalBox.ReadOnly = true;
            this.SubtotalBox.Size = new System.Drawing.Size(119, 24);
            this.SubtotalBox.TabIndex = 2;
            // 
            // MovieBuyBox
            // 
            this.MovieBuyBox.Location = new System.Drawing.Point(15, 109);
            this.MovieBuyBox.Name = "MovieBuyBox";
            this.MovieBuyBox.ReadOnly = true;
            this.MovieBuyBox.Size = new System.Drawing.Size(119, 24);
            this.MovieBuyBox.TabIndex = 3;
            this.MovieBuyBox.Visible = false;
            // 
            // SalestaxBox
            // 
            this.SalestaxBox.Location = new System.Drawing.Point(15, 241);
            this.SalestaxBox.Name = "SalestaxBox";
            this.SalestaxBox.ReadOnly = true;
            this.SalestaxBox.Size = new System.Drawing.Size(119, 24);
            this.SalestaxBox.TabIndex = 4;
            // 
            // GrandTotalBox
            // 
            this.GrandTotalBox.Location = new System.Drawing.Point(15, 305);
            this.GrandTotalBox.Name = "GrandTotalBox";
            this.GrandTotalBox.ReadOnly = true;
            this.GrandTotalBox.Size = new System.Drawing.Size(119, 24);
            this.GrandTotalBox.TabIndex = 5;
            // 
            // MovieCostLabel
            // 
            this.MovieCostLabel.AutoSize = true;
            this.MovieCostLabel.Location = new System.Drawing.Point(15, 35);
            this.MovieCostLabel.Name = "MovieCostLabel";
            this.MovieCostLabel.Size = new System.Drawing.Size(114, 18);
            this.MovieCostLabel.TabIndex = 6;
            this.MovieCostLabel.Text = "Cost of Movie";
            // 
            // BuyMovieLabel
            // 
            this.BuyMovieLabel.AutoSize = true;
            this.BuyMovieLabel.Location = new System.Drawing.Point(15, 85);
            this.BuyMovieLabel.Name = "BuyMovieLabel";
            this.BuyMovieLabel.Size = new System.Drawing.Size(86, 18);
            this.BuyMovieLabel.TabIndex = 7;
            this.BuyMovieLabel.Text = "Buy Movie";
            this.BuyMovieLabel.Visible = false;
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(15, 156);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(70, 18);
            this.SubtotalLabel.TabIndex = 8;
            this.SubtotalLabel.Text = "Subtotal";
            // 
            // SalestaxLabel
            // 
            this.SalestaxLabel.AutoSize = true;
            this.SalestaxLabel.Location = new System.Drawing.Point(15, 220);
            this.SalestaxLabel.Name = "SalestaxLabel";
            this.SalestaxLabel.Size = new System.Drawing.Size(82, 18);
            this.SalestaxLabel.TabIndex = 9;
            this.SalestaxLabel.Text = "Sales Tax";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(15, 284);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(97, 18);
            this.GrandTotalLabel.TabIndex = 10;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // BuyMovieCheckbox
            // 
            this.BuyMovieCheckbox.AutoSize = true;
            this.BuyMovieCheckbox.Location = new System.Drawing.Point(140, 56);
            this.BuyMovieCheckbox.Name = "BuyMovieCheckbox";
            this.BuyMovieCheckbox.Size = new System.Drawing.Size(117, 22);
            this.BuyMovieCheckbox.TabIndex = 11;
            this.BuyMovieCheckbox.Text = "Buy Movie?";
            this.BuyMovieCheckbox.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 503);
            this.ControlBox = false;
            this.Controls.Add(this.OrderOrderBox);
            this.Controls.Add(this.OrderMovieBox);
            this.Controls.Add(this.OrderCancelButton);
            this.Controls.Add(this.OrderBackButton);
            this.Controls.Add(this.OrderStreamButton);
            this.Controls.Add(this.OrderMenuStrip);
            this.MainMenuStrip = this.OrderMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.OrderMovieBox.ResumeLayout(false);
            this.OrderMovieBox.PerformLayout();
            this.OrderOrderBox.ResumeLayout(false);
            this.OrderOrderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button OrderStreamButton;
        private System.Windows.Forms.Button OrderBackButton;
        private System.Windows.Forms.Button OrderCancelButton;
        private System.Windows.Forms.GroupBox OrderMovieBox;
        private System.Windows.Forms.GroupBox OrderOrderBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox BuyMovieCheckbox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label SalestaxLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label BuyMovieLabel;
        private System.Windows.Forms.Label MovieCostLabel;
        private System.Windows.Forms.TextBox GrandTotalBox;
        private System.Windows.Forms.TextBox SalestaxBox;
        private System.Windows.Forms.TextBox MovieBuyBox;
        private System.Windows.Forms.TextBox SubtotalBox;
        private System.Windows.Forms.TextBox MovieCostBox;
    }
}