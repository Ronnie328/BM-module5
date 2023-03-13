namespace BelarminoModule5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Gender = String.Empty;
            string PreferredProg = String.Empty;
            string City = String.Empty;
            string CivilStatus = String.Empty;

            // condition for gender
            if (rbnMale.Checked == true)
            {
                Gender = " Male";
            }
            else if (rbnFemale.Checked == true)
            {
                Gender = " Female";
            }

            if (chkC.Checked == true)
            {
                PreferredProg = PreferredProg + "\n" + "C";
            }
            if (chkCSharp.Checked == true)
            {
                PreferredProg = PreferredProg + "\n" + "CSharp";
            }
            if (chkJava.Checked == true)
            {
                PreferredProg = PreferredProg + "\n" + "Java";
            }
            if (chkPython.Checked == true)
            {
                PreferredProg = PreferredProg + "\n" + "Python";
            }
            if (chkPHP.Checked == true)
            {
                PreferredProg = PreferredProg + "\n" + "PHP";
            }
            if (chkC.Checked == false && chkCSharp.Checked == false && chkJava.Checked == false && chkPython.Checked == false && chkPHP.Checked == false)
            {
                PreferredProg = PreferredProg + "none";
            }


            City = cboCity.Text;
            CivilStatus = lstCivilStatus.Text;

            MessageBox.Show("Full name: " + txtFirstName.Text + " " + txtLastName.Text + Environment.NewLine
            + "Age: " + txtAge.Text + Environment.NewLine
            + "Gender: " + Gender + Environment.NewLine
            + "Contact No: " + txtContactNo.Text + Environment.NewLine
            + "City: " + City + Environment.NewLine
            + "Civil Status: " + CivilStatus + Environment.NewLine
            + "Preferred Programming Language: " + PreferredProg, "Personal Info Summary");

        }
    }
}