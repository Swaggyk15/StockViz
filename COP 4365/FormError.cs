using System;
using System.Windows.Forms;

namespace COP_4365
{
    public partial class FormError : Form
    {       
        // Default constructor
        
        public FormError()
        {
            InitializeComponent();
        }


        // Closes the dialog window
        // Parameters:
        // - sender: The source of the event
        // - e: Event arguments associated with the action

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}