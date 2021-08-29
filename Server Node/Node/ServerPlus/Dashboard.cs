using System;
using System.Data;
using System.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Node
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _NoNodes.Text = Utility.No_Of_Nodes.ToString();
            if (Utility.DigLock == 1)
            {
                Thread _cputhread = new Thread(CPU_Performance);
                Thread _memorythread = new Thread(Memory_Performance);
                _cputhread.Start();
                _memorythread.Start();
                Utility.DigLock = 0;
            }
            NetworkInterface.Start();
        }



        private void NetworkInterface_Tick(object sender, EventArgs e)
        {
            string status = Configuration.AutoStatus();
            if(status == "ON")
            {
                AutoTag.Text = "ON";
                AutoTag.ForeColor = Color.Green;
            }
            else
            {
                AutoTag.Text = "OFF";
                AutoTag.ForeColor = Color.Red;
            }

            CPUProgress.Value = Utility.CPUVALUE;
            MemoryProgress.Value = Utility.MEMVALUE;
        }

        private void Memory_Performance()
        {
            while(true)
            {
                Thread.Sleep(1000);
                PerformanceCounter _memory = new PerformanceCounter("Memory", "Available MBytes");
                Utility.MEMVALUE = Convert.ToInt32(((8000.00 - _memory.NextValue()) / 8000.00) * 100);
            }
        }

        private void CPU_Performance()
        {
            do
            {
                PerformanceCounter CPU = new PerformanceCounter();
                CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                var Dummy = CPU.NextValue();
                Thread.Sleep(1000);
                Utility.CPUVALUE = Convert.ToInt32(CPU.NextValue());
            }
            while (true);
        }

        private void SyncRequest()
        {
            Random NodeSeed = new Random();
            int i = NodeSeed.Next();
            string _CONFIGURATION_DATA_ = File.ReadAllText(@Configuration.CONFIGPATH);
            JObject BLOCKCHAIN = JObject.Parse(_CONFIGURATION_DATA_);
            JArray items = (JArray)BLOCKCHAIN["CONFIGURATION"];
            int PortValue = (int)items[0]["NODES"][0]["REVPORT"];
            string ServerValue = (string)items[0]["NODES"][0]["SERVER"];
            Server.SyncRequest(ServerValue, PortValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread _syncthread = new Thread(SyncRequest);
            _syncthread.Start();
        }
    }
}

