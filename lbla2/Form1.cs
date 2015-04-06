using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lbla2
{
    public partial class Lbla : Form
    {
        public Process p = null;
        public Lbla()
        {
            InitializeComponent();
            p = new Process();
        }

        private void bnButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                tbResult.Text = openFileDialog1.FileName;
                // Open the selected file to read.
                string textValue = p.readFile(tbResult.Text);
                const string caption = "Form Closing";
                var result = MessageBox.Show(textValue, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            }
        }
    }

    public class Process
    {
        public string readFile(string path)
        {
            string textValue = System.IO.File.ReadAllText(path);
            return textValue;

        }
    }
}
