using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonal personal = new FrmPersonal();
            personal.MdiParent = this;
            personal.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservation reservation = new FrmReservation();
            reservation.MdiParent = this;
            reservation.Show();
        }
    }
}
