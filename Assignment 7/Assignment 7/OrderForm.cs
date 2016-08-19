using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;
        public OrderForm(Image SelectedImage)
        {
            
            InitializeComponent();
            Image image = SelectedImage;
            OrderedPictureBox.Image = image;
        }

        private void CalculatePrice()
        {
            MovieCostBox.Text = "$" + Convert.ToString(Program.movie.Cost);
            if (BuyMovieCheckbox.Checked==true)
            {
                SubtotalBox.Text = "$" + Convert.ToString(Program.movie.Cost + 10);
                SalestaxBox.Text = "$" + Convert.ToString((Program.movie.Cost + 10) * 0.13);
                GrandTotalBox.Text = "$" + Convert.ToString(((Program.movie.Cost + 10) * 0.13)+ Program.movie.Cost + 10);
            }
            else
            {
                SubtotalBox.Text = "$" + Convert.ToString(Program.movie.Cost);
                SalestaxBox.Text = "$" + Convert.ToString(Program.movie.Cost * 0.13);
                GrandTotalBox.Text = "$" + Convert.ToString((Program.movie.Cost * 0.13) + Program.movie.Cost);
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            OrderedMovieBox.Text = Program.movie.Title;
            OrderedCategoryBox.Text = Program.movie.Category;

            CalculatePrice();

            
        }

        private void BuyMovieCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
            
            if (BuyMovieCheckbox.Checked==true)
            {
                BuyMovieLabel.Visible = true;
                MovieBuyBox.Visible = true;
            }
            else
            {
                BuyMovieLabel.Visible = false;
                MovieBuyBox.Visible = false;
            }
        }

        private void OrdermenuAboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
    }
}
