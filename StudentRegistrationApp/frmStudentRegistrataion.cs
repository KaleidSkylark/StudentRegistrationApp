namespace StudentRegistrationApp
{
    public partial class StudentRegistration : Form
    {

        String rb;
        public StudentRegistration()
        {
            InitializeComponent();
            //DOB Section
            int day, month, year;
            for (day = 1; day <= 31; day++)
            {
                cmb_Day.Items.Add(day);
            }
            for (month = 1; month <= 12; month++)
            { 
                cmb_Month.Items.Add(month);
            }
            for (year = 1900; year <= 2022; year++)
            {
                cmb_Year.Items.Add(year);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            String Lname, Fname, Mname, Phone, Email, day, month, year;
            Lname = txtB_Lname.Text;
            Fname = txtB_Fname.Text;
            Mname = txtB_Mname.Text;
            Phone = txtB_Phone.Text;
            Email = txtB_Email.Text;
            day = cmb_Day.Text.ToString();
            month = cmb_Month.Text.ToString();
            year = cmb_Year.Text.ToString();

            //Validation Section

            if (string.IsNullOrEmpty(Lname))
            {
                MessageBox.Show("Please input your last name.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Lname, "^[a-zA-Z]"))
            {
                MessageBox.Show("alphabetic characters only.");

            }

            else if(string.IsNullOrEmpty(Fname))
            {
                MessageBox.Show("Please input your first name.");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(Fname, "^[a-zA-Z]"))
            {
                MessageBox.Show("alphabetic characters only.");
            }

            else if(string.IsNullOrEmpty(Mname))
            {
                MessageBox.Show("Please input your middle name.");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(Mname, "^[a-zA-Z]"))
            {
                MessageBox.Show("alphabetic characters only.");
            }

            else if(string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Please input your contact number.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Phone, "^[0-9]"))
            {
                MessageBox.Show("Numeric characters only.");
            }
            else if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Please input your email address.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(Email, "[@]"))
            {
                MessageBox.Show("invalid email.");
            }

            else if(!rb_Male.Checked && !rb_Female.Checked)
            {
                MessageBox.Show("Please select gender.");
            }
            else if(cmb_Day.SelectedIndex == -1 || cmb_Month.SelectedIndex == -1 || cmb_Year.SelectedIndex == -1)
            {
                MessageBox.Show("Please select date of birth.");
            }


            else
            {
                MessageBox.Show("Student Name: " + Fname + " " + Mname + " " + Lname + 
                    "\nContact Number: " + Phone + "\nEmail: " + Email + "\nGender: " + rb + "\nDate of Birth: " 
                    + day + "/" + month + "/" + year);
            }
        }

            private void btn_Reset_Click(object sender, EventArgs e)
            {
                txtB_Lname.Text = "";
                txtB_Fname.Text = "";
                txtB_Mname.Text = "";
                txtB_Email.Text = "";
                txtB_Phone.Text = "";
                rb_Male.Checked = false;
                rb_Female.Checked = false;
                cmb_Day.SelectedIndex = -1;
                cmb_Month.SelectedIndex = -1;
                cmb_Year.SelectedIndex = -1;
            }

            private void rb_Male_CheckedChanged(object sender, EventArgs e)
            {
                rb = "Male";
            }

            private void rb_Female_CheckedChanged(object sender, EventArgs e)
            {
                rb = "Female";
            }
    }
}
