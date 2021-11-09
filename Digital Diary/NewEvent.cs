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
    public partial class NewEvent : Form
    {
        //int loggedId;
        public int id;
        Diary diary;

        public NewEvent()
        {
            InitializeComponent();
            
        }
        public NewEvent(Diary diary)
        {
            InitializeComponent();
            //this.loggedId = loggedId;
            this.diary = diary;
        }

        

        private void Raeset()
        {
            textBox.Text = "";
            comboBox.Text = "";
           
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0 || comboBox.Text.Length == 0)
            {
                MessageBox.Show("All Fields are Mandatory");
            }
            else
            {
                Event evnt = new Event();
                evnt.Id = id;
                evnt.Description = textBox.Text;
                evnt.Date = datePicker.Value.ToString();
                evnt.Importance = comboBox.Text;
               
                if (evnt.UpdateEvent() > 0)
                {
                    MessageBox.Show("Event Updated Successfully");
                    this.Hide();
                    diary.UpdateData();
                    diary.Show();
                }
                else
                {
                    MessageBox.Show("Something Wrong");
                    Raeset();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0 || comboBox.Text.Length == 0)
            {
                MessageBox.Show("All Fields are Mandatory");
            }
            else
            {
                Event evnt = new Event();
                evnt.Description = textBox.Text;
                evnt.Date = datePicker.Value.ToString();
                evnt.Importance = comboBox.Text;
                evnt.PersonId = diary.log.loggedId;
                if (evnt.AddEvent() > 0)
                {
                    MessageBox.Show("Event Added Successfully");
                    diary.UpdateData();
                    Raeset();
                }
                else
                {
                    MessageBox.Show("Something Wrong");
                    Raeset();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raeset();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            diary.Show();
        }

        private void NewEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            diary.Show();
        }
    }
}
