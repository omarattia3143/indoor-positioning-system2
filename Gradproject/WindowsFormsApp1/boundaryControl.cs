using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class boundaryControl : UserControl {
        public boundaryControl() {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e) {
            //datagridview.CurrentCell.RowIndex
            //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            Boundary_Config myForm = new Boundary_Config();
            string myindex = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            int index = Int32.Parse(myindex);
            myForm.initializeBoundary(index);
            //this.Hide();
            myForm.ShowDialog();
            initializeBoundary();
            //this.Show();
        }

        private void newButton_Click(object sender, EventArgs e) {
            Boundary_Config myForm = new Boundary_Config();
            myForm.initializeBoundary();
            //this.Hide();
            myForm.ShowDialog();
            initializeBoundary();
            //this.Show();
        }

        public void initializeBoundary() {
            using (var dbContext = new DatabaseEntities1()) {
                BindingSource bi = new BindingSource();
                bi.DataSource = (from c in dbContext.Boundaries select c).Select(o => new {
                    ID = o.boundary_id,
                    Name = o.boundary_name,
                    From = o.boundary_from,
                    To = o.boundary_to,
                    Enabled = o.boundary_enabled
                }).ToList();
                dataGridView1.DataSource = bi;
                dataGridView1.Refresh();
            }
        }
    }
}
