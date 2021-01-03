using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management
{
    public partial class viewAppointments : Form
    {
        public viewAppointments()
        {
            InitializeComponent();
        }

        private void viewAppointments_Load(object sender, EventArgs e)
        {

            service serve = new service();
            dataGridView1.DataSource = serve.GetListOfAppointment();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            appointment a = new appointment();
            a.Show();
            this.Hide();
        }
    }
}
