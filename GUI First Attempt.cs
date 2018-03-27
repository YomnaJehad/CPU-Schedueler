using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
  //  std::string ScheduelerType; 
    
    public partial class Form1 : Form
    {
        string SchedulerType="FCFS";
        int noTasks = 0;
        double quantum = 2;
        List<double> arrTime;
        List<double> needTime;
        List<int> Priority;
        public Form1()
        {
            InitializeComponent();
        
        }

        //First The COMBOBOX YOHOOO
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchedulerType = SchedulerType_comboBox1.GetItemText(this.SchedulerType_comboBox1.SelectedItem);
             if (SchedulerType== "RoundRobin")
                RRBurstTime_textBox4.Visible = true;
             else
                 RRBurstTime_textBox4.Visible = false;
             if (SchedulerType.Contains("Priority"))
                 Priority_textBox3.Visible = true;
             else
                 Priority_textBox3.Visible = false;
            
        }

        //NOW LET'S CODE THE TEXT BOXES 

        // TEXT CHANGE EVENTS 
        private void textBox3_TextChanged(object sender, EventArgs e) //The priority TextBox
        {
        }

        private void RRBurstTime_textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ArrivalTime_textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TimeNeeded_textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void NumberTaskstextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        //ENTER EVENTS

        private void ArrivalTime_textBox1_Enter(object sender, EventArgs e)
        {
            ArrivalTime_textBox1.Text = "";
            if (arrTime.Count == noTasks) ArrivalTime_textBox1.Enabled = false;
            else arrTime.Add(Convert.ToDouble(ArrivalTime_textBox1.Text));

        }

        private void TimeNeeded_textBox2_Enter(object sender, EventArgs e)
        {
            TimeNeeded_textBox2.Text = "";
            if (needTime.Count == noTasks) TimeNeeded_textBox2.Enabled = false;
            else needTime.Add(Convert.ToDouble(TimeNeeded_textBox2.Text));

        }

        private void Priority_textBox3_Enter(object sender, EventArgs e)
        {
            Priority_textBox3.Text = "";
            if (Priority.Count == noTasks) Priority_textBox3.Enabled = false;
            else Priority.Add(Convert.ToInt32(Priority_textBox3.Text));

        }

        private void NumberTaskstextBox1_Enter(object sender, EventArgs e)
        {
            noTasks = Convert.ToInt32(NumberTaskstextBox1.Text);
        }

    }
 
}
