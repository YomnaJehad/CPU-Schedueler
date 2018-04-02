using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;



namespace WindowsFormsApplication2
{
 
    
    public partial class Form1 : Form
    {

        schedular sch = new schedular();
        string SchedulerType="FCFS";
       // int readyToScheduel = 0;
        int noTasks = 0;
        double quantum = 2;
        List<int> arrTime= new List<int>() ;
        List<int> needTime= new List <int>();
        List<int> Priority= new List<int>();
        List<process> finishedlife = new List<process>();

        

        List<Process_trial> Processes=new List<Process_trial>();

        //List<Process>Processes= new List<Process>();

    
        //ALGORITHM HANDLEING
        List<int> processIndexToPrint=new List<int>();
        List<int> timeListToPrint = new List<int>();

        
        //_________


        public Form1()
        {
            InitializeComponent();
           // label2.Text = "Type in Values\n and press ENTER";
        
        }
        
        //First The COMBOBOX YOHOOO
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchedulerType = SchedulerType_comboBox1.GetItemText(this.SchedulerType_comboBox1.SelectedItem);
            if (SchedulerType == "RoundRobin")
            {
                RRBurstTime_textBox4.Visible = true;
                Quantum_label1.Visible = true;
            }
            else
            {
                RRBurstTime_textBox4.Visible = false;
                Quantum_label1.Visible = false;

            }
            if (SchedulerType.Contains("Priority"))
            {
                Priority_textBox3.Visible = true;
                Priority_label5.Visible = true;

            }
            else
            {
                Priority_textBox3.Visible = false;
                Priority_label5.Visible = false;

            }
            
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

        }

        private void TimeNeeded_textBox2_Enter(object sender, EventArgs e)
        {
        }

        private void Priority_textBox3_Enter(object sender, EventArgs e)
        {
        }

        private void NumberTaskstextBox1_Enter(object sender, EventArgs e)
        {
        }

        private void RRBurstTime_textBox4_Enter(object sender, EventArgs e)
        {
        }


        //KEYS EVENTS YARAB
        private void NumberTaskstextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    noTasks = Convert.ToInt32(NumberTaskstextBox1.Text);
                }
                catch
                {
                    NumberTaskstextBox1.Text = "";
                }
                debug_label1.Text = Convert.ToString(noTasks);
            }
        }

        private void RRBurstTime_textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    quantum = Convert.ToDouble(RRBurstTime_textBox4.Text);
                    debug_label1.Text = Convert.ToString(quantum);
                }
                catch
                {
                    RRBurstTime_textBox4.Text = "";
                }
            }
        }

        private void ArrivalTime_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
                
                
                    arrTime.Add(Convert.ToInt32(ArrivalTime_textBox1.Text));
                    //ArrivalTime_textBox1.Text = "";
                    debug_label1.Text = ArrivalTime_textBox1.Text;
                    arrivalTime_label2.Visible = true;
                    arrivalTime_label2.Text+="\n"+ArrivalTime_textBox1.Text;
                    if (arrTime.Count == noTasks)
                    {
                        ArrivalTime_textBox1.Enabled = false;
                        ArrivalTime_textBox1.Text = "";
                    }
                
               // for(int i=0; i<arrTime.Count ; i++)
                  //  debug_label1.Text = debug_label1.Text+ "    "+Convert.ToString(arrTime[i]);
            }
         }

       private void TimeNeeded_textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
                
                    needTime.Add(Convert.ToInt32(TimeNeeded_textBox2.Text));
                    //TimeNeeded_textBox2.Text = "";
                    debug_label1.Text = TimeNeeded_textBox2.Text;
                    Burst_label3.Visible = true;
                    Burst_label3.Text += "\n" + TimeNeeded_textBox2.Text;

                    if (needTime.Count == noTasks)
                    {
                        TimeNeeded_textBox2.Enabled = false;
                        TimeNeeded_textBox2.Text = "";
                    }
            }
        }

        private void Priority_textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    
                    
                        Priority.Add(Convert.ToInt32(Priority_textBox3.Text));
                       // Priority_textBox3.Text = "";
                        debug_label1.Text = Priority_textBox3.Text;

                        Priority_label4.Visible = true;
                        Priority_label4.Text += "\n" + Priority_textBox3.Text;
                        if (Priority.Count == noTasks )
                        {
                            Priority_textBox3.Enabled = false;
                            Priority_textBox3.Text = "";
                        }
                    

                }
                catch { }

            }
        }

       

        private void Restart(object sender, EventArgs e)
        {

        }

        private void Restart_button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void StartSim_button1_Click(object sender, EventArgs e)
        {

           //Processes = new List<Process>(arrTime.Count);
            List<Process_trial> copy_List = new List<Process_trial>(arrTime.Count);
            for (int i = 0; i < arrTime.Count; i++) 
            {
                Process_trial P = new Process_trial("P" + i, arrTime[i], needTime[i], (SchedulerType.Contains("Priority"))?Priority[i]:0);
               // debug_label1.Text = Convert.ToString(i);
                Processes.Add(P);
                copy_List.Add(P);
                
            }

            List<process> yarab = new List<process>();
            for (int i = 0; i < Processes.Count; i++)
            {
                process P=new process();
                
                P.arrival_time = Processes[i].arrivalTime;
                P.duration = Processes[i].brust;
                P.name = Processes[i].name;
                P.remaining_time = Processes[i].brust;
                if (SchedulerType.Contains("Priority"))
                {
                    P.priority = Processes[i].priority;
                }
                yarab.Add(P);
                //debug_label1.Text = "hello i added P"+Convert.ToString(i)+"\n";


            }

            //schedular sch = new schedular();
            sch.tasks = yarab;
            chart1.Series.Add("Process");
            chart1.Series["Process"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            chart1.Series["Process"].ChartArea = "ChartArea1";
           // chart1.Series.Add("white");
           // chart1.Series["white"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            //chart1.Series["white"].ChartArea = "ChartArea1";
            //chart1.Series["white"].Color=
            try
            {
            //debug_label1.Text = "SIZE IS"+Convert.ToString(arrTime.Count);
                if (SchedulerType == "FCFS")
                {
                    /*
                    Process temp;
                    for (int k = 0; k < Processes.Count; k++)
                    {
                        for (int i = k + 1; i < Processes.Count; i++)
                        {
                            if (Processes[k].arrivalTime > Processes[i].arrivalTime || (Processes[k].arrivalTime == Processes[i].arrivalTime && Processes[k].brust > Processes[i].brust))
                            {
                                temp = Processes[i];
                                Processes[i] = Processes[k];
                                Processes[k] = temp;
                            }
                        }
                    }

                    int clock = 0, totalwait = 0, totalturnAround = 0;
                    for (int i = 0; i < Processes.Count; i++)
                    {
                        if (Processes[i].arrivalTime > clock)
                        {
                            Processes[i].start = Processes[i].arrivalTime;
                            clock += Processes[i].start - Processes[i].arrivalTime;
                            clock += Processes[i].brust;

                        }
                        else
                        {
                            if (i > 0)
                                Processes[i].start = Processes[i - 1].end;
                            clock += Processes[i].brust;
                        }
                        if (Processes[i].start > Processes[i].arrivalTime)
                            Processes[i].wait = Processes[i].start - Processes[i].arrivalTime;
                        else Processes[i].wait = 0;
                        Processes[i].end =Processes[i].start + Processes[i].brust;
                        Processes[i].turnAround = Processes[i].wait + Processes[i].brust;
                        totalwait += Processes[i].wait;
                        totalturnAround += Processes[i].turnAround;
                    }
                   
                    double att = 0, awt = 0;
                    awt = (double)totalwait / (double)Processes.Count;
                    att = (double)totalturnAround / (double)Processes.Count;

                    avgWaitingTime_label2.Text = Convert.ToString(awt);
                    int from , to ;
                    for (int i = 0; i < arrTime.Count; i++)
                    {
                        from = Processes[i].start;
                        to = Processes[i].end;
                        String s = "P"+i;
                        debug_label1.Text = s;
                        //chart1.Series.Add(Convert.ToString(arrTime[i]));
                        
                        chart1.Series["Process"].Points.AddXY(s,from,to);
                        
                        

                    }*/


                    sch.mode = "FCFS";
                    sch.run_process();
                    sch.ave_wating_time();

                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {
                        chart1.Series["Process"].Points.AddXY(sch.finished_tasks[i].name, ((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time), sch.finished_tasks[i].finish_time);

                    }

                    avgWaitingTime_label2.Text = Convert.ToString(sch.Ave_wating_time);


                
                }
                if (SchedulerType == "SJF-Preempitive")
                {
                    /*
                    //Sort According to Arrival Time mn el so3'ayar lel kber and if 2 are equal then choose the smallest burst
                    Process temp;
                    for (int k = 0; k < Processes.Count-1; k++)
                    {
                        for (int i = k + 1; i < Processes.Count; i++)
                        {
                            if (Processes[k].arrivalTime > Processes[i].arrivalTime || (Processes[k].arrivalTime == Processes[i].arrivalTime && Processes[k].brust > Processes[i].brust))
                            {
                                temp = Processes[i];
                                Processes[i] = Processes[k];
                                Processes[k] = temp;
                            }
                        }
                    }

                    //__ habd

                    chart1.Series.Add("Process");
                    chart1.Series["Process"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
                    chart1.Series["Process"].ChartArea = "ChartArea1";


                    int time = 0, from=0,to=0;
                    while (true) { 

                        List <Process> existing_now=new List <Process> ();
                        for (int i = 0; i < Processes.Count; i++) {
                            if (Processes[i].arrivalTime <= time)
                            {
                                existing_now.Add(Processes[i]);
                                //debug_label1.Text += "at time" + Convert.ToString(time) + "Existing process"+ existing_now[i].name+"\n";
                            }
                        }
                        //Arrange according to burst Time
                        /*for (int k = 0; k < existing_now.Count-1; k++)
                        {
                            for (int i = k + 1; i < existing_now.Count; i++)
                            {
                                if (existing_now[k].brust > existing_now[i].brust)
                                {
                                    temp = existing_now[i];
                                    existing_now[i] = existing_now[k];
                                    existing_now[k] = temp;
                                }
                                else if (existing_now[k].brust == existing_now[i].brust) 
                                {
                                    if (existing_now[k].arrivalTime > existing_now[i].arrivalTime)
                                    {
                                        temp = existing_now[i];
                                        existing_now[i] = existing_now[k];
                                        existing_now[k] = temp;
                                    }
   
                                }
                            }
                        }*/
                        //Actually i only need to get the minimum burst so..
                     /*   Process min_brust_process = existing_now[0];
                        for (int i = 0; i < existing_now.Count; i++) 
                        {
                            if(existing_now[i].brust<min_brust_process.brust)
                                min_brust_process=existing_now[i];
                        }




                        chart1.Series["Process"].Points.AddXY(min_brust_process.name, time, time+1);

                        for (int i = 0; i < Processes.Count; i++) 
                        {
                            if (min_brust_process.name == Processes[i].name)
                            {   Processes[i].brust -= 1;

                                if (Processes[i].brust == 0)
                                Processes.Remove(Processes[i]);

                                break;
                            }
                            


                        }
                        time++;
                        if (Processes.Count == 0) break;


                    
                    
                    } //The while true bracket closes

                    */




                    sch.mode = "SJF-Preemptive";
                    sch.run_process();
                    sch.ave_wating_time();
                    debug_label1.Text = "There you go SJF \n";
                    for (int i = 0; i < sch.tasks.Count; i++)
                    {
                        debug_label1.Text += sch.tasks[i].name + "\t";
                        debug_label1.Text += Convert.ToString(sch.tasks[i].arrival_time) + "\t";
                        debug_label1.Text += Convert.ToString(sch.tasks[i].duration);
                        debug_label1.Text += "\n";


                    }

                    debug_label1.Text += "__________________ \n";
                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {

                        debug_label1.Text += sch.finished_tasks[i].name + "\t";
                        debug_label1.Text += Convert.ToString(sch.finished_tasks[i].start_time)+"\t";
                        debug_label1.Text += Convert.ToString(sch.finished_tasks[i].finish_time);
                        debug_label1.Text += "\n";


                    }

                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {

                        chart1.Series["Process"].Points.AddXY(sch.finished_tasks[i].name, sch.finished_tasks[i].start_time, sch.finished_tasks[i].finish_time);
                       // chart1.Series["white"].Points.AddXY(sch.finished_tasks[i].name, sch.finished_tasks[i].arrival_time, sch.finished_tasks[i].start_time);
                       // chart1.Series["Process"].Points[i].Label = Convert.ToString(sch.finished_tasks[i].name);


                    }

                    avgWaitingTime_label2.Text = Convert.ToString(sch.Ave_wating_time);

                   
                }
                if (SchedulerType == "SJF-Nonpreempitive")
                {
                    sch.mode = "SJF";
                    

                    debug_label1.Text = "There you go SJF NON \n";
                    for (int i = 0; i < sch.tasks.Count; i++)
                    {
                        debug_label1.Text += sch.tasks[i].name + "\t";
                        debug_label1.Text += Convert.ToString(sch.tasks[i].arrival_time) + "\t";
                        debug_label1.Text += Convert.ToString(sch.tasks[i].duration);
                        debug_label1.Text += "\n";


                    }
                    sch.run_process();
                    sch.ave_wating_time();
                    /*
                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {
                        debug_label1.Text += sch.finished_tasks[i].name + "\t";
                        debug_label1.Text += Convert.ToString((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time) + "\t";
                        debug_label1.Text += Convert.ToString(sch.finished_tasks[i].finish_time);
                        debug_label1.Text += "\n";


                    }*/
                    for (int i = 0; i < sch.finished_tasks.Count; i++) 
                    {
                        chart1.Series["Process"].Points.AddXY(sch.finished_tasks[i].name, ((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time), sch.finished_tasks[i].finish_time);
                    
                    }

                    avgWaitingTime_label2.Text = Convert.ToString(sch.Ave_wating_time);


                }
                if (SchedulerType == "Priority-Preempitive")
                {
                    sch.mode = "Priority-Preemptive";
                    sch.run_process();
                    sch.ave_wating_time();
                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {
                        debug_label1.Text += sch.finished_tasks[i].name + "\t";
                        debug_label1.Text += Convert.ToString((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time) + "\t";
                        debug_label1.Text += Convert.ToString(sch.finished_tasks[i].finish_time);
                        debug_label1.Text += "\n";


                    }
                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {
                        chart1.Series["Process"].Points.AddXY(sch.finished_tasks[i].name, ((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time), sch.finished_tasks[i].finish_time);

                    }

                    avgWaitingTime_label2.Text = Convert.ToString(sch.Ave_wating_time);


                }
                if (SchedulerType == "Priority-Nonpreempitive")
                {
                    sch.mode = "Priority";
                    sch.run_process();
                    sch.ave_wating_time();

                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {
                        debug_label1.Text += sch.finished_tasks[i].name + "\t";
                        debug_label1.Text += Convert.ToString((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time) + "\t";
                        debug_label1.Text += Convert.ToString(sch.finished_tasks[i].finish_time);
                        debug_label1.Text += "\n";


                    }



                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {
                        chart1.Series["Process"].Points.AddXY(sch.finished_tasks[i].name,  ((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time), sch.finished_tasks[i].finish_time);

                    }
                    avgWaitingTime_label2.Text = Convert.ToString(sch.Ave_wating_time);

                }
                if (SchedulerType == "RoundRobin")
                {
                    sch.mode = "Round_Robin";
                    sch.burst = (float)quantum;
                    
                    sch.run_process();
                    sch.ave_wating_time();

                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {
                        debug_label1.Text += sch.finished_tasks[i].name + "\t";
                        debug_label1.Text += Convert.ToString((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time) + "\t";
                        debug_label1.Text += Convert.ToString(sch.finished_tasks[i].finish_time);
                        debug_label1.Text += "\n";


                    }
                    for (int i = 0; i < sch.finished_tasks.Count; i++)
                    {
                       chart1.Series["Process"].Points.AddXY(sch.finished_tasks[i].name, ((i == 0) ? 0 : sch.finished_tasks[i - 1].finish_time), sch.finished_tasks[i].finish_time);
                   }
                    avgWaitingTime_label2.Text = Convert.ToString(sch.Ave_wating_time);

                }

              avgWaitingTime_label2.Text = Convert.ToString(sch.Ave_wating_time);
              inst_label2.Visible = false;
                chart1.Visible = true;
                avgWaitingTime_label2.Visible = true;
                label1.Visible = true;
            }
            catch {
              //  debug_label1.Text = "Something Went Wrong, RESTART and Check your inputs again.";
                inst_label2.Visible = true;
                inst_label2.Text = "Something Went Wrong, RESTART and Check your inputs again.";
            }
        }
   
 

    }

     


   

    //____PROCESS CLASS
    public class Process_trial
    {
        public Process_trial(string name, int arrivalTime, int brust = 0, int priority = 0,int finished=0)
        {
            this.name = name;
            this.arrivalTime = arrivalTime;
            this.brust = brust;
            this.priority = priority;
            this.finished = finished;
            
        }
        public Process_trial()
        {

        }
       // public bool sortFCFSByArrival(const FCFS &lhs, const FCFS &rhs) { return lhs.arrival < rhs.arrival; }
        public string name;
        public int arrivalTime;
        public int brust;
        public int priority;
        public int wait;
        public int end;
        public int start;
        public int turnAround;
        public int timeLeft;
        public int finished;
        public int departure;
    }

    //________________
    class process : IComparable<process>
    {
        public float duration, arrival_time, remaining_time, finish_time, start_time;

        public int priority;
        public bool finished;

        public string name;

        public process(float duration = 0, float arrival_time = 0, int priority = 0, string name = "noname")
        {
            this.arrival_time = arrival_time;
            this.duration = duration;
            this.name = name;
            this.priority = priority;
            this.remaining_time = duration;
            this.finished = false;
            start_time = arrival_time;
        }
        public process(process t)
        {
            this.arrival_time = t.arrival_time;
            this.duration = t.duration;
            this.name = t.name;
            this.priority = t.priority;
            this.remaining_time = t.remaining_time;
            this.finished = t.finished;
            this.finish_time = t.finish_time;
            this.start_time = t.start_time;
        }
        static public process fill_task(string name, int priority, float arrival_time, float duration)
        {
            process t = new process();
            t.name = name;
            t.priority = priority;
            t.arrival_time = arrival_time;
            t.duration = duration;
            return t;

        }
        public int CompareTo(process other)
        {
            if (schedular.sort_by == "remaining_time")
            {
                if (this.remaining_time > other.remaining_time)
                    return 1;
                else if (this.remaining_time == other.remaining_time)
                {
                    if (this.arrival_time > other.arrival_time)
                    {
                        return 1;
                    }
                    else
                        return -1;
                }
                else
                    return -1;
            }
            else if (schedular.sort_by == "priority")
            {
                if (this.priority > other.priority)
                    return 1;

                else if (this.priority == other.priority)
                {
                    if (this.arrival_time > other.arrival_time)
                    {
                        return 1;
                    }
                    else
                        return -1;
                }
                else
                    return -1;
            }
            else if (schedular.sort_by == "arrival_time")
            {

                if (this.arrival_time > other.arrival_time)
                {
                    return 1;
                }
                else
                    return -1;
            }
            else
                return 1;
        }


    }

    class schedular
    {
        public int no_tasks;
        public float Timer;
        public float Ave_wating_time;
        process running_task;
        public string mode;
        public static string sort_by;
        public List<process> tasks;
        private List<process> current_tasks;
        public List<process> finished_tasks;
        private Dictionary<float, List<process>> tasks_map;
        private Queue<process> round_robin_queue;
        public float burst;
        //---------------------------------------------------------------------//constructor
        public schedular()//constructor
        {
            sort_by = "arrival_time";
            no_tasks = 0;
            Timer = 0;
            tasks = new List<process>();
            current_tasks = new List<process>();
            finished_tasks = new List<process>();
            tasks_map = new Dictionary<float, List<process>>();
            running_task = new process();
            round_robin_queue = new Queue<process>();
            burst = 5;
            mode = "FCFS";
            Ave_wating_time = 0;

        }
        public void sort()
        {
            tasks.Sort();
        }
        private void fill_tasks_map()
        {
            sort_by = "arrival_time";//so Sort function will sort according the arrival time 
            tasks.Sort();
            foreach (var t in tasks)
            {
                if (!tasks_map.ContainsKey(t.arrival_time))
                {
                    List<process> temp = new List<process> { t };
                    tasks_map.Add(t.arrival_time, temp);
                }
                else
                    tasks_map[t.arrival_time].Add(t);
            }
            if (mode == "SJF" || mode == "SJF-Preemptive")
                sort_by = "remaining_time";
            else if (mode == "priority" || mode == "Priority-Preemptive")
                sort_by = "priority";
            else
                sort_by = "arrival_time";


            foreach (var i in tasks_map)
            {
                i.Value.Sort();
            }
        }
        private void run_task_non_pre(process running)
        {
            if (running.arrival_time > Timer)
                Timer = running.arrival_time;
            running.start_time = Timer;

            bool fi_task_gya_w_enta_48al = false;

            do//lw fi task gya w enta 43'al
            {
                if (tasks_map.Count != 0)
                {
                    if (Timer + running.duration >= tasks_map.First().Key)
                    {
                        fi_task_gya_w_enta_48al = true;
                        update_current_tasks();
                    }
                    else
                        fi_task_gya_w_enta_48al = false;
                }
                else
                    break;
            } while (fi_task_gya_w_enta_48al);

            Timer += running.duration;
            running.finish_time = Timer;
            running.finished = true;
            process temp = new process(running);
            finished_tasks.Add(temp);
            //finishedlife.Add(temp);
        }
        private void update_current_tasks()
        {
            float First_key = tasks_map.Keys.First();
            current_tasks.AddRange(tasks_map[First_key]);//append the map List to current_tasks List
            if (mode == "SJF-Preemptive" || mode == "SJF")
                sort_by = "remaining_time";
            else
                sort_by = "priority";

            current_tasks.Sort();
            tasks_map.Remove(First_key);
        }
        private void preempt()
        {
            bool eli_geh_ahm = false;
            bool fi_task_gya_w_hya_48ala = true;
            // for(int i=0;i<tasks_map.Count;i++)
            while (fi_task_gya_w_hya_48ala)
            {
                if (tasks_map.Count != 0)
                {
                    if (mode == "SJF-Preemptive")
                    {
                        if (tasks_map.First().Value.First().remaining_time < (running_task.remaining_time - tasks_map.First().Key))
                            eli_geh_ahm = true;
                    }
                    else// (mode == "Priority-Preemptive")
                    {
                        if (tasks_map.First().Value.First().priority < running_task.priority)
                            eli_geh_ahm = true;
                    }

                    if (eli_geh_ahm)//lw eli geh 2at3
                    {
                        eli_geh_ahm = false;
                        float First_key = tasks_map.Keys.First();
                        running_task.start_time = Timer;
                        Timer = First_key;//running the current task till the new one come
                        running_task.finish_time = Timer;
                        running_task.remaining_time = running_task.remaining_time - (Timer - running_task.start_time);//set remaining time

                        if (running_task.remaining_time == 0)//lw 5lst matrg3ha4 le el current_tasks
                        {
                            running_task.finished = true;
                            process Temp = new process(running_task);
                            finished_tasks.Add(Temp);
                        }
                        else
                        {
                            process temp2 = new process(running_task);
                            current_tasks.Add(temp2);
                            process Temp = new process(running_task);
                            finished_tasks.Add(Temp);
                        }
                        update_current_tasks();
                        return;
                    }
                    else//lw eli geh ma2t34
                    {
                        //eli_geh_ma2t34 = true;
                        update_current_tasks();
                        if (tasks_map.Count != 0)
                        {
                            if (Timer + running_task.remaining_time < tasks_map.First().Key)
                                fi_task_gya_w_hya_48ala = false;
                        }
                        else
                            fi_task_gya_w_hya_48ala = false;

                        running_task.start_time = Timer;
                    }
                }
                else
                    break;//ya3ni mafi4 7aga gya tani w enta 43'al
            }
            //kda yeb2a el task 5lst w mfi4 7aga gat aham
            running_task.start_time = Timer;
            Timer = Timer + running_task.remaining_time;
            running_task.finish_time = Timer;
            running_task.finished = true;
            running_task.remaining_time = 0;
            process temp = new process(running_task);
            finished_tasks.Add(temp);
        }
        private void run_preemptive()
        {
            if (running_task.arrival_time > Timer)
                Timer = running_task.arrival_time;

            running_task.start_time = Timer;
            if (tasks_map.Count != 0)
            {
                running_task.start_time = Timer;

                if (tasks_map.First().Key <= (Timer + running_task.remaining_time))//lw fi task gya w hya 43'ala
                    preempt();
                else
                {
                    running_task.start_time = Timer;
                    Timer = Timer + running_task.remaining_time;
                    running_task.finish_time = Timer;
                    running_task.finished = true;
                    process temp = new process(running_task);
                    finished_tasks.Add(temp);
                }
            }

            else//ya3ni mafi4 7ad hyege gded 4a3'al eli 3ndk beltartib bta3k
            {

                Timer = Timer + running_task.remaining_time;
                running_task.finish_time = Timer;
                running_task.finished = true;
                process temp = new process(running_task);
                finished_tasks.Add(temp);
            }
        }
        private void run_round()
        {
            running_task.start_time = Timer;
            if ((running_task.remaining_time - burst) <= 0)//
            {
                if (running_task.arrival_time > Timer)
                    Timer = running_task.arrival_time;
                running_task.start_time = Timer;
                Timer = Timer + running_task.remaining_time;
                running_task.finish_time = Timer;
                running_task.finished = true;
                process temp = new process(running_task);
                finished_tasks.Add(temp);
                if (tasks_map.Count != 0)
                {
                    if (Timer > tasks_map.First().Key)
                        update_queue();
                }

            }
            else
            {
                if (running_task.arrival_time > Timer)
                    Timer = running_task.arrival_time;
                running_task.start_time = Timer;
                Timer = Timer + burst;
                running_task.remaining_time = running_task.remaining_time - burst;
                running_task.finish_time = Timer;
                process temp = new process(running_task);
                process temp2 = new process(running_task);
                finished_tasks.Add(temp);

                if (tasks_map.Count != 0)
                {
                    if (Timer > tasks_map.First().Key)
                        update_queue();
                }
                round_robin_queue.Enqueue(temp2);
            }
        }
        public void update_queue()
        {
            if (tasks_map.Count != 0)
            {
                float First_key = tasks_map.Keys.First();
                for (int i = 0; i < tasks_map[First_key].Count; i++)
                {
                    round_robin_queue.Enqueue(tasks_map[First_key][i]);
                }

                tasks_map.Remove(First_key);
            }
        }
        public void ave_wating_time()
        {
            foreach (process t in finished_tasks)
            {
                if (t.finished)
                {
                    Ave_wating_time += (t.finish_time - t.arrival_time - t.duration);
                }

            }
            Ave_wating_time = Ave_wating_time / tasks.Count;
        }
        public void run_process()
        {
            no_tasks = tasks.Count;
            if (mode == "FCFS")
            {
                sort_by = "arrival_time";//so Sort function will sort according the arrival time 
                tasks.Sort();

                foreach (process t in tasks)
                {
                    if (t.arrival_time > Timer)
                        Timer = t.arrival_time;
                    t.start_time = Timer;
                    Timer += t.duration;
                    t.finish_time = Timer;
                    t.finished = true;
                    finished_tasks.Add(t);
                    //finishedlife.Add(t);
                }
            }
            if (mode == "SJF")
            {
                fill_tasks_map();
                float First_key = tasks_map.Keys.First();
                // current_tasks = tasks_map[First_key];
                //tasks_map.Remove(First_key);
                update_current_tasks();
                if (tasks_map.Count != 0)
                    First_key = tasks_map.Keys.First();
                while (current_tasks.Count != 0)
                {
                    if (tasks_map.Count != 0)
                        First_key = tasks_map.Keys.First();

                    running_task = current_tasks.First();
                    current_tasks.RemoveAt(0);
                    run_task_non_pre(running_task);
                    if ((current_tasks.Count == 0) && (tasks_map.Count != 0))
                    {
                        update_current_tasks();
                    }
                }
            }
            if (mode == "Priority")
            {
                fill_tasks_map();
                float First_key = tasks_map.Keys.First();
                // current_tasks = tasks_map[First_key];  
                //tasks_map.Remove(First_key);
                // mode = "SJF";
                update_current_tasks();
                mode = "Priority";
                while (current_tasks.Count != 0)
                {
                    if (tasks_map.Count != 0)
                        First_key = tasks_map.Keys.First();
                    running_task = current_tasks.First();
                    current_tasks.RemoveAt(0);
                    run_task_non_pre(running_task);//run the running task
                    if ((current_tasks.Count == 0) && (tasks_map.Count != 0))
                    {
                        update_current_tasks();
                    }
                }
            }
            if (mode == "SJF-Preemptive")
            {
                fill_tasks_map();
                float First_key = tasks_map.Keys.First();
                //  current_tasks = tasks_map[First_key];
                //  tasks_map.Remove(First_key);
                update_current_tasks();

                if (tasks_map.Count != 0)
                    First_key = tasks_map.Keys.First();
                while (current_tasks.Count != 0)
                {
                    running_task = current_tasks.First();
                    current_tasks.RemoveAt(0);
                    run_preemptive();//run the running task
                    if ((current_tasks.Count == 0) && (tasks_map.Count != 0))
                    {
                        update_current_tasks();
                    }
                }
            }
            if (mode == "Priority-Preemptive")
            {
                fill_tasks_map();
                float First_key = tasks_map.Keys.First();
                // current_tasks = tasks_map[First_key];
                // tasks_map.Remove(First_key);
                update_current_tasks();

                if (tasks_map.Count != 0)
                    First_key = tasks_map.Keys.First();
                while (current_tasks.Count != 0)
                {
                    running_task = current_tasks.First();
                    current_tasks.RemoveAt(0);
                    run_preemptive();//run the running task

                    if ((current_tasks.Count == 0) && (tasks_map.Count != 0)) //|| ((tasks_map.Count != 0) && Timer + current_tasks.First().duration > First_key))
                    {
                        update_current_tasks();
                    }
                }
            }
            if (mode == "Round_Robin")
            {
                fill_tasks_map();
                update_queue();

                while (round_robin_queue.Count != 0)
                {
                    running_task = round_robin_queue.Dequeue();
                    run_round();
                    if ((round_robin_queue.Count == 0) && (tasks_map.Count != 0))
                    {
                        update_queue();
                    }
                }

            }

        }

    }

}
