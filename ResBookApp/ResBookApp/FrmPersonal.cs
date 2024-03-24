using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResBookAppLibrary1;

namespace ResBookApp
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome");

            if (txtName.Text == "")
            {
                MessageBox.Show("please enter Name");
                ActiveControl = txtName;
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("please enter Age");
                ActiveControl = txtAge;
            }
            else if (dtpBD.Text == "")
            {
                MessageBox.Show("please enter the Birthday");
                ActiveControl = dtpBD;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("please enter  Email");
                ActiveControl = txtEmail;
            }
            else if (txtP.Text == "")
            {
                MessageBox.Show("Enter Password");
                ActiveControl = txtP;
            }
            else
            {

                personal personal = new personal();
                personal.Name = txtName.Text;
                personal.Age = Convert.ToInt32(txtAge.Text);
                personal.Birthday = dtpBD.Text;
                personal.Email = txtEmail.Text;
                personal.Password = txtP.Text;
            }
        }
    }
}
