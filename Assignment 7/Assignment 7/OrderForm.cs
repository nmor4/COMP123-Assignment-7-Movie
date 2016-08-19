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
        string streamtitle;
        string streamgrandtotal;
        
        public OrderForm(Image SelectedImage)
        {
            Image image = SelectedImage;
            InitializeComponent();
            
            OrderedPictureBox.Image = image;
        }

        //Private Method ----------------------

            //CaluculatePrice() - Fills the text boxes in the right group box with approriate values
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
                SalestaxBox.Text = "$" + Convert.ToString((Program.movie.Cost * 0.13));
                GrandTotalBox.Text = "$" + Convert.ToString((Program.movie.Cost * 0.13) + Program.movie.Cost);
            }
        }

        //Event Handlers ------------------------------
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

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();

        }

        private void OrderStreamButton_Click(object sender, EventArgs e)
        {
            streamtitle = OrderedMovieBox.Text;
            streamgrandtotal=GrandTotalBox.Text;
            this.Hide();
            StreamForm streamForm = new StreamForm(streamtitle,streamgrandtotal);
            streamForm.Show();
            
        }

        private void OrdermenuPrintButton_Click(object sender, EventArgs e)
        { MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string yesno = "Confirm Printing";
            string message = "Confirm printing?";
            MessageBox.Show(message,yesno,buttons);
        }

        private void OrderBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }
    }
}
