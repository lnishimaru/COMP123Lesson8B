using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123Lesson8B
{
    public partial class Lab8 : Form
    {
        // Class Properties
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// Constructor for Lab8Form
        /// </summary>
        public Lab8()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for SubmitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            UserAge = float.Parse(AgeTextBox.Text); // or Convert.ToSingle
            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();
        }
        private void ClearForm()
        {
            // option A 
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
            // option B - NameTextBox.Text = string.Empty; // or ""
        }
        /// <summary>
        /// Event handler for the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            // simple input validation
                try
                {
                    float.Parse(AgeTextBox.Text);
                    SubmitButton.Enabled = true;
                }
                catch
                {
                    SubmitButton.Enabled = false;
                }
        }
        /// <summary>
        /// Event Handler for Lab08Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// Event handler the for NameTextBox TextChanged Event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
                SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
