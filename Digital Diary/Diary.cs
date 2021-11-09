using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary
{
    public partial class Diary : Form
    {
        public Login log;
        Event evnt;
        int id;
        string description;
        string importance;
        string date;

        public Diary()
        {
            InitializeComponent();
        }

        public Diary(Login Log)
        {
            evnt = new Event();
            InitializeComponent();
            this.log = Log;
        }

        private void Diary_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            log.Show();
        }

        private void Diary_Load(object sender, EventArgs e)
        {

            UpdateData();
            //dataGridView.Height = 35;
        }

        public void UpdateData()
        {
            dataGridView.DataSource = evnt.GetAllById(log.loggedId);
            dataGridView.Columns.Remove("PersonId");
            dataGridView.Columns.Remove("Title");
            dataGridView.Columns[0].Width = 35;
            dataGridView.Columns[1].Width = 248;
            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[3].Width = 94;
            dataGridView.Columns[3].Width = 94;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            description = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            importance = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            date = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dresult == DialogResult.Yes)
            {
                
                int result = evnt.DeleteEvent(id);
                if (result > 0)
                {
                    MessageBox.Show("Event deleted successfully.");
                    UpdateData();
                    
                }
                else
                {
                    MessageBox.Show("Error occured..");
                    
                }
            }
            else { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new NewEvent(this).Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewEvent ne = new NewEvent(this);
            ne.id = id;
            ne.textBox.Text = description;
            ne.comboBox.SelectedItem = importance;
            ne.btnUpdate.Visible = true;
            ne.btnAdd.Visible = false;
            //ne.datePicker.Select. = date;
            this.Hide();
            ne.Show();

        }
    }
}
