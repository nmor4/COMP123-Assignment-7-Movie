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
    public partial class StreamForm : Form
    {
       
        public StreamForm(string streamTitle,string grandTotal)
        {
            InitializeComponent();
            StreamLabel.Text = streamTitle + " will begin streaming in a minute.";
            GrandTotalLabel.Text = "Your credit card has been billed for " + grandTotal + ".";

        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
             
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}
