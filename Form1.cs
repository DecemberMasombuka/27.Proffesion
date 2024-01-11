namespace _27.Proffesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {


                if (rbFemale.Checked)
                {
                    lblResult.Text = "Name: " + txtName.Text + " Gender: Female " + " Proffesion: " + cB.SelectedItem.ToString();
                }
                else if (rbMale.Checked)
                {
                    lblResult.Text = "Name: " + txtName.Text + " Gender :  Male  " + " Proffesion: " + cB.SelectedItem.ToString();
                }
                else
                {
                    lblResult.Text = " Name: " + txtName.Text + " Gender: Other  " + " Proffesion: " + cB.SelectedItem.ToString();
                }

            }
            else
            {
                MessageBox.Show("Name cannot be Empty, Please Enter Your Name");
            }
        }
    }
}