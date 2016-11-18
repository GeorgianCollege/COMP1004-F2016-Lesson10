using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Required for File IO
using System.IO;
using System.Diagnostics;

namespace COMP1004_F2016_Lesson10
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

            try
            {
               

                // Step 1 - Create a StreamReader Object
                StreamReader reader = new StreamReader("Names.txt");

                // Step 2 - Use ReadLine method to read the data
                while (reader.Peek() != -1)
                {
                    string FullNameString = reader.ReadLine();
                    FullNamesListBox.Items.Add(FullNameString);
                }

                // Step 3 - Close the Stream
                reader.Close();

                /*
                string[] linestring = FullNameString.Split(' ');

                FirstNameTextBox.Text = linestring[0];
                LastNameTextBox.Text = linestring[1];
                */

                /*
                int spaceIndex = FullNameString.IndexOf(' '); // find the space in the string

                FirstNameTextBox.Text = FullNameString.Substring(0, spaceIndex); 
                LastNameTextBox.Text = FullNameString.Substring(spaceIndex + 1);
                */
                
                
            }
            catch 
            {

                MessageBox.Show("Some Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
