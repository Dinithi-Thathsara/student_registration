namespace Student_Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text;
            string studentID = txtStudentID.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string department = cmbDepartment.SelectedItem?.ToString() ?? "Not Selected";

            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            else if (rbOther.Checked)
            {
                gender = "Other";
            }

            lblDetails.Text = $"Student Name: {studentName}\n" +
                               $"Student ID: {studentID}\n" +
                               $"Email: {email}\n" +
                               $"Phone Number: {phoneNumber}\n" +
                               $"Gender: {gender}\n" +
                               $"Department: {department}";
        }
    }
}
