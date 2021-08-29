using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.DataViz.WinForms;
using System.Diagnostics;

namespace Node
{
    public partial class Performance : Form
    {
        static int Cpu_Progress = 0;
        static int Data_Progress = 0;
        static int Band_Progress = 0;
        static int Memory_progress = 0;
        int[,] ReqsGraph = new int[4, 12];
        public int Cur_MailReq { get; set; }
        public int Cur_FacialReg { get; set; }
        public int Cur_Rdbms { get; set; }
        public int Cur_Text { get; set; }
        public Performance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Process_Tick(object sender, EventArgs e)
        {

            Thread _cputhread = new Thread(CPU_Performance);
            Thread _memorythread = new Thread(Memory_Performance);
            Thread _datathread = new Thread(Data_Performance);
            Thread _bandthread = new Thread(Band_Performance);

            _cputhread.Start();
            _memorythread.Start();
            _datathread.Start();
            _bandthread.Start();

            DataProgress.Value = Data_Progress;
            BandProgress.Value = Band_Progress;
            MemoryProgress.Value = Memory_progress;
            CPUProgress.Value = Cpu_Progress;
        }

        private void Data_Performance()
        {
            System.Threading.Thread.Sleep(2500);
            Random DataGenerator = new Random();
            Data_Progress = DataGenerator.Next(4, 17);
        }

        private void Band_Performance()
        {
            System.Threading.Thread.Sleep(1300);
            Random BandGenerator = new Random();
            Band_Progress = BandGenerator.Next(2, 23);
        }

        private void Memory_Performance()
        {
            System.Threading.Thread.Sleep(1000);
            PerformanceCounter _memory = new PerformanceCounter("Memory", "Available MBytes");
            Memory_progress = Convert.ToInt32(((8000.00 - _memory.NextValue()) / 8000.00) * 100);
        }

        private void CPU_Performance()
        {
            PerformanceCounter CPU = new PerformanceCounter();
            CPU.CategoryName = "Processor";
            CPU.CounterName = "% Processor Time";
            CPU.InstanceName = "_Total";
            var Dummy = CPU.NextValue();
            System.Threading.Thread.Sleep(1000);
            Cpu_Progress = Convert.ToInt32(CPU.NextValue());
        }

        private void Performance_Load(object sender, EventArgs e)
        {
            Processes.Start();
            Graph.Start();
        }

        private void Graph_Tick(object sender, EventArgs e)
        {

            Graph.Stop();
            Random R = new Random();
            /*for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    ReqsGraph[i, j] = R.Next(4, R.Next(12, 20));
                }
            }*/
            ReqsGraph[0, 0] = 12;
            ReqsGraph[0, 4] = 7;
            ReqsGraph[0, 2] = 3;
            ReqsGraph[1, 0] = 13;
            ReqsGraph[1, 2] = 4;
            ReqsGraph[1, 4] = 5;
            ReqsGraph[2, 0] = 16;
            ReqsGraph[2, 2] = 9;
            ReqsGraph[2, 4] = 12;
            ReqsGraph[3, 0] = 2;
            ReqsGraph[3, 2] = 7;
            ReqsGraph[3, 4] = 9;
            //Utility.Mail();
            Canvas GraphContent = new Canvas();

            // Graph Colouring
            RequestGraph.colorSet.Add(Color.FromArgb(255, 255, 0));
            RequestGraph.colorSet.Add(Color.FromArgb(31, 123, 202));
            RequestGraph.colorSet.Add(Color.FromArgb(255, 140, 0));
            RequestGraph.colorSet.Add(Color.FromArgb(128, 0, 128));

            //Mail Feature
            DataPoint MailGraph = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            MailGraph.addLabely("12 AM", ReqsGraph[0, 0]);
            MailGraph.addLabely("2 AM", ReqsGraph[0, 1]);
            MailGraph.addLabely("4 AM", ReqsGraph[0, 2]);
            MailGraph.addLabely("6 AM", ReqsGraph[0, 3]);
            MailGraph.addLabely("8 AM", ReqsGraph[0, 4]);
            //MailGraph.addLabely("10 AM", Utility.Mail());
            MailGraph.addLabely("12 PM", ReqsGraph[0, 6]);
            MailGraph.addLabely("2 PM", ReqsGraph[0, 7]);
            MailGraph.addLabely("4 PM", ReqsGraph[0, 8]);
            MailGraph.addLabely("6 PM", ReqsGraph[0, 9]);
            MailGraph.addLabely("8 PM", ReqsGraph[0, 10]);
            MailGraph.addLabely("10 PM", ReqsGraph[0, 11]);
            GraphContent.addData(MailGraph);

            //Facial Recognition
            DataPoint FacialGraph = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            FacialGraph.addLabely("12 AM", ReqsGraph[1, 0]);
            FacialGraph.addLabely("2 AM", ReqsGraph[1, 1]);
            FacialGraph.addLabely("4 AM", ReqsGraph[1, 2]);
            FacialGraph.addLabely("6 AM", ReqsGraph[1, 3]);
            FacialGraph.addLabely("8 AM", ReqsGraph[1, 4]);
            FacialGraph.addLabely("10 AM", Cur_FacialReg);
            FacialGraph.addLabely("12 PM", ReqsGraph[1, 6]);
            FacialGraph.addLabely("2 PM", ReqsGraph[1, 7]);
            FacialGraph.addLabely("4 PM", ReqsGraph[1, 8]);
            FacialGraph.addLabely("6 PM", ReqsGraph[1, 9]);
            FacialGraph.addLabely("8 PM", ReqsGraph[1, 10]);
            FacialGraph.addLabely("10 PM", ReqsGraph[1, 11]);
            GraphContent.addData(FacialGraph);

            //Database Query
            DataPoint DataBase = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            DataBase.addLabely("12 AM", ReqsGraph[2, 0]);
            DataBase.addLabely("2 AM", ReqsGraph[2, 1]);
            DataBase.addLabely("4 AM", ReqsGraph[2, 2]);
            DataBase.addLabely("6 AM", ReqsGraph[2, 3]);
            DataBase.addLabely("8 AM", ReqsGraph[2, 4]);
            DataBase.addLabely("10 AM", Utility.RequestsCount()) ;
            DataBase.addLabely("12 PM", ReqsGraph[2, 6]);
            DataBase.addLabely("2 PM", ReqsGraph[2, 7]);
            DataBase.addLabely("4 PM", ReqsGraph[2, 8]);
            DataBase.addLabely("6 PM", ReqsGraph[2, 9]);
            DataBase.addLabely("8 PM", ReqsGraph[2, 10]);
            DataBase.addLabely("10 PM", ReqsGraph[2, 11]);
            GraphContent.addData(DataBase);

            //Text Transfer
            DataPoint TextTransfer = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            TextTransfer.addLabely("12 AM", ReqsGraph[3, 0]);
            TextTransfer.addLabely("2 AM", ReqsGraph[3, 1]);
            TextTransfer.addLabely("4 AM", ReqsGraph[3, 2]);
            TextTransfer.addLabely("6 AM", ReqsGraph[3, 3]);
            TextTransfer.addLabely("8 AM", ReqsGraph[3, 4]);
            TextTransfer.addLabely("10 AM", Cur_Text);
            TextTransfer.addLabely("12 PM", ReqsGraph[3, 6]);
            TextTransfer.addLabely("2 PM", ReqsGraph[3, 7]);
            TextTransfer.addLabely("4 PM", ReqsGraph[3, 8]);
            TextTransfer.addLabely("6 PM", ReqsGraph[3, 9]);
            TextTransfer.addLabely("8 PM", ReqsGraph[3, 10]);
            TextTransfer.addLabely("10 PM", ReqsGraph[3, 11]);
            GraphContent.addData(TextTransfer);

            // Final Graph Rendering
            RequestGraph.Render(GraphContent);
            Graph.Start();
        }
    }
}
