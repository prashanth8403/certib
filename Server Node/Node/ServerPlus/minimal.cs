using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Node
{
    public partial class minimal : Form
    {
        private bool _dragging;
        private Point _offset;

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        public minimal()
        {
            InitializeComponent();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            Core corepanel = new Core();
            this.Visible = false;
            corepanel.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(@Utility.DATAPATH))
            {
                try
                {
                    if (Utility.RequestsCount() < 10)
                        DataProcessed.Text = "0" + Utility.RequestsCount().ToString();
                    else
                        DataProcessed.Text = Utility.RequestsCount().ToString();
                    string ___BLOCKDATA = File.ReadAllText(@Utility.DATAPATH);
                    JObject BLOCKCHAIN = JObject.Parse(___BLOCKDATA);
                    JArray items = (JArray)BLOCKCHAIN["blocks"];
                    if (items.Count < 10)
                        TotalBlocksTag.Text = "0" + items.Count.ToString();
                    else
                        TotalBlocksTag.Text = items.Count.ToString();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void minimal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
