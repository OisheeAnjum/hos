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
    public partial class finance : Form
    {
        int serial = 0;
        public finance()
        {
            InitializeComponent();
            button1.Click += this.RefreshGridView;
 
        }

        void RefreshGridView(object sender, EventArgs e)
        {
            service serve = new service();
            dataGridView1.DataSource = serve.GetListOfBill();
        }

        private void finance_Load(object sender, EventArgs e)
        {
            service serve = new service();
            dataGridView1.DataSource = serve.GetListOfBill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            appointment a = new appointment();
            a.Show();
            this.Hide();
        }

        private void searchPatient_TextChanged(object sender, EventArgs e)
        {
            service serve = new service();
            dataGridView1.DataSource = serve.Getlistofbill(searchPatienttextBox.Text);
        }

        private void updatebutton1_Click(object sender, EventArgs e)
        {
            service serve = new service();
            int result = serve.UpdateBill(serial,da.Text,pa.Text);
            if (result > 0)
            {
                MessageBox.Show("finance updated successfully");
            }
            else
            {
                MessageBox.Show("Error in updating finance");
            }

        }

        private void pa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serial = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            pa.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            da.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
