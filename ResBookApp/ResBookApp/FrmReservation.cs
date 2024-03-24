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
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resvation Submitted");
            if (txtHN.Text == "")
            {
                MessageBox.Show("please enter HostName");
                ActiveControl = txtHN;
            }
            else if (txtPN.Text == "")
            {
                MessageBox.Show("please enter PhoneNumber");
                ActiveControl = txtPN;
            }
            else if (txtRN.Text == "")
            {
                MessageBox.Show("please enter the RestaurantName");
                ActiveControl = txtRN;
            }
            else if (dtpDT.Text == "")
            {
                MessageBox.Show("please enter DateTime");
                ActiveControl = dtpDT;
            }
            else if (txtPS.Text == "")
            {
                MessageBox.Show("Enter PartySize");
                ActiveControl = txtPS;
            }
            else if (cboDA.Text == "")
            {
                MessageBox.Show("Please Select DennyArea");
                ActiveControl = cboDA;
            }
            else if (cboO.Text == "")
            {
                MessageBox.Show("Please Select Occasion");
                ActiveControl = cboO;
            }
            else
            {
                Reservation reservation = new Reservation();
                reservation.HostName = txtHN.Text;
                reservation.PhoneNumber = Convert.ToInt32(txtPN.Text);
                reservation.ResturantName = txtRN.Text;
                reservation.Datetime = dtpDT.Text;
                reservation.PartySize = txtPS.Text;
                reservation.DennyArea = cboDA.Text;
                reservation.Occasion = cboO.Text;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resvation cancel");
        }
    }
}
