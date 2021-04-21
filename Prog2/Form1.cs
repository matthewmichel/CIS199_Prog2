/*
 * GRADING ID: A9391
 * PROGRAM NUMBER: 02
 * DUE DATE: 16 October 2018
 * COURSE SECTION: 01
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This logic is run whenever the button is clicked. It determines the day and time of registration given the lastName and gradeLevel variables
        private void checkRegistrationBtn_Click(object sender, EventArgs e)
        {
            char lastName; // stores the user inputted FIRST LETTER of their LAST NAME
            int gradeLevel; // is determined by which radio box is selected
            string day = "INVALID"; // will be used when showing the MessageBox. Set to INVALID as default
            string time = "INVALID"; // will be used when showing the MessageBox. Set to INVALID as default.


            // determines the gradeLevel based on the radio boxes
            if (freshmanRadio.Checked == true)
                gradeLevel = 1;
            else if (sophomoreRadio.Checked == true)
                gradeLevel = 2;
            else if (juniorRadio.Checked == true)
                gradeLevel = 3;
            else if (seniorRadio.Checked == true)
                gradeLevel = 4;
            else {
                gradeLevel = 0;
                MessageBox.Show("You must select a grade level.");
            }

            // turns the lastNameTxtBox.Text value into a char data type
            if (lastNameTxtBox.Text.Length == 1)
                char.TryParse(lastNameTxtBox.Text, out lastName);
            else
            {
                MessageBox.Show("Please only enter the FIRST LETTER of your LAST NAME");
                lastName = 'a';
            }

            // makes all lastName chars lower case
            lastName = char.ToLower(lastName);

            // determines day and time if a Junior or Senior
            if (gradeLevel == 4 || gradeLevel == 3)
            {
                if (gradeLevel == 4)
                    day = "November 2nd";
                else if (gradeLevel == 3)
                    day = "November 5th";

                if (lastName <= 'd')
                    time = "4:00 PM";
                else if (lastName <= 'i')
                    time = "8:30 AM";
                else if (lastName <= 'o')
                    time = "10:00 AM";
                else if (lastName <= 's')
                    time = "11:30 AM";
                else if (lastName <= 'z')
                    time = "2:00 PM";
            }
            else if (gradeLevel == 2) // determines day and time if a sophomore
            {

                if (lastName <= 'b')
                {
                    day = "November 7th";
                    time = "2:00 PM";
                }
                else if (lastName <= 'd')
                {
                    day = "November 7th";
                    time = "4:00 PM";
                }
                else if (lastName <= 'f')
                {
                    day = "November 6th";
                    time = "8:30 AM";
                }
                else if (lastName <= 'i')
                {
                    day = "November 6th";
                    time = "10:00 AM";
                }
                else if (lastName <= 'l')
                {
                    day = "November 6th";
                    time = "11:30 AM";
                }
                else if (lastName <= 'o')
                {
                    day = "November 6th";
                    time = "2:00 PM";
                }
                else if (lastName <= 'q')
                {
                    day = "November 6th";
                    time = "4:00 PM";
                }
                else if (lastName <= 's')
                {
                    day = "November 7th";
                    time = "8:30 AM";
                }
                else if (lastName <= 'v')
                {
                    day = "November 7th";
                    time = "10:00 AM";
                }
                else if (lastName <= 'z')
                {
                    day = "November 7th";
                    time = "11:30 AM";
                }
            }
            else if (gradeLevel == 1) // determines day and time if a freshman
            {

                if (lastName <= 'b')
                {
                    day = "November 9th";
                    time = "2:00 PM";
                }
                else if (lastName <= 'd')
                {
                    day = "November 9th";
                    time = "4:00 PM";
                }
                else if (lastName <= 'f')
                {
                    day = "November 8th";
                    time = "8:30 AM";
                }
                else if (lastName <= 'i')
                {
                    day = "November 8th";
                    time = "10:00 AM";
                }
                else if (lastName <= 'l')
                {
                    day = "November 8th";
                    time = "11:30 AM";
                }
                else if (lastName <= 'o')
                {
                    day = "November 8th";
                    time = "2:00 PM";
                }
                else if (lastName <= 'q')
                {
                    day = "November 8th";
                    time = "4:00 PM";
                }
                else if (lastName <= 's')
                {
                    day = "November 9th";
                    time = "8:30 AM";
                }
                else if (lastName <= 'v')
                {
                    day = "November 9th";
                    time = "10:00 AM";
                }
                else if (lastName <= 'z')
                {
                    day = "November 9th";
                    time = "11:30 AM";
                }
            }

            // shows the final message box displaying the day and time of registration
            MessageBox.Show($"You are able to register on {day} at {time}");

        }
    }
}
