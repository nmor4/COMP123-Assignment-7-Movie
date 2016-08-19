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
    /* Author: Nick Morin-300654901
 * Description: COMP123-Assignment 7 - Movie Bonanaza - Selection Form
 * Date last modified: 2016-08-18
 */
    public partial class SelectionForm : Form
    {
        Image image_Selection;
        public SelectionForm()
        {
            InitializeComponent();
        }
        public Image Image_Selection

        {

            get { return image_Selection; }

            set { image_Selection = value; }

        }

        //Event Handlers --------------------------------
        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void MovieDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MovieDropdownList.Text)
            {
                case "Cedar Rapids":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Comedy";
                    SelectCostBox.Text = "1.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.cedarrapids );
                    SelectionNextButton.Enabled = true;
                    break;

                case "The Green Hornet":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Action";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.thegreenhornet);
                    SelectionNextButton.Enabled = true;
                    break;

                case "The Dilemna":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Comedy";
                    SelectCostBox.Text = "1.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.thedilemma);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Death Race 2":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Action";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.deathrace2);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Season of the Witch":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Sci-Fi";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.seasonofthewitch);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Company Men":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Drama";
                    SelectCostBox.Text = "1.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.companymen);
                    SelectionNextButton.Enabled = true;
                    break;

                case "No Strings Attached":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Comedy";
                    SelectCostBox.Text = "1.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.nostringsattached);
                    SelectionNextButton.Enabled = true;
                    break;

                case "The Way Back":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Drama";
                    SelectCostBox.Text = "1.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.thewayback);
                    SelectionNextButton.Enabled = true;
                    break;

                case "The Mechanic":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Action";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.themechanic);
                    SelectionNextButton.Enabled = true;
                    break;

                case "The Rite":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Horror";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.therite);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Sanctum":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Action";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.sanctum);
                    SelectionNextButton.Enabled = true;
                    break;

                case "The Other Woman":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Action";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.theotherwoman);
                    SelectionNextButton.Enabled = true;
                    break;

                case "The Roomate":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Thriller";
                    SelectCostBox.Text = "1.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.theroommate);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Waiting for Forever":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Drama";
                    SelectCostBox.Text = "1.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.waitingforever);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Gnomeo and Juliet":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Family";
                    SelectCostBox.Text = "0.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.gnomeoandjuliet);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Just Go With It":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Comedy";
                    SelectCostBox.Text = "1.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.justgowithit);
                    SelectionNextButton.Enabled = true;
                    break;

                case "The Eagle":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Action";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.theeagle);
                    SelectionNextButton.Enabled = true;
                    break;

                case "I am Number Four":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "Sci-Fi";
                    SelectCostBox.Text = "2.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.iamnumberfour);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Footloose":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "New Release";
                    SelectCostBox.Text = "4.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.footloose);
                    SelectionNextButton.Enabled = true;
                    break;

                case "Real Steel":
                    SelectTitleBox.Text = MovieDropdownList.Text;
                    SelectCategoryBox.Text = "New Release";
                    SelectCostBox.Text = "4.99";
                    SelectionPicture.Image = (Assignment_7.Properties.Resources.realsteel);
                    SelectionNextButton.Enabled = true;
                    break;

                default:
                    break;
            }

        }

        private void SelectionNextButton_Click(object sender, EventArgs e)
        {
            Movie movie = Program.movie;

            movie.Title = SelectTitleBox.Text;
            movie.Category = SelectCategoryBox.Text;
            movie.Cost = Convert.ToDouble(SelectCostBox.Text);
            
            

            this.Hide();
            OrderForm orderForm = new OrderForm(SelectionPicture.Image);
            orderForm.previousForm = this;
            orderForm.Show();
        }
    }
}
