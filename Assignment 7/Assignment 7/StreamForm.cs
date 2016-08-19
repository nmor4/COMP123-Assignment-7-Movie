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
 * Description: COMP123-Assignment 7-Movie Bonanaza - StreamForm
 * Date last modified: 2016-08-19
 */
    public partial class StreamForm : Form
    {
       
        
        public StreamForm(string streamTitle,string grandTotal)
        {
            InitializeComponent();
            StreamLabel.Text = streamTitle + " will begin streaming in a minute.";
            GrandTotalLabel.Text = "Your credit card has been billed for " + grandTotal + ".";

        }

        //OK button closes application
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}
