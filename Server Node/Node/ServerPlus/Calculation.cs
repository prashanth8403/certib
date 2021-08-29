using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Silicon;
using System.Threading;

namespace Node
{
    public partial class Calculation : Form
    {
        Boolean Dataflag = true, Chainflag = true;
        public Calculation()
        {
            InitializeComponent();
        }
        int A, B, C, D, E;

        private void Calculation_Load(object sender, EventArgs e)
        {
            StartPanel.Show();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(@Utility.LOCKPATH))
            {
                StartPanel.Hide();
                CalculateResult();
            }
            else
            {
                MessageBox.Show("Voting lock doesn't exist", "Server Plus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalculateResult()
        {
            ResultText.Text = "";
            if (File.Exists(@Utility.DATAPATH))
            {

                string ___BLOCKDATA = File.ReadAllText(@Utility.DATAPATH);
                JObject BLOCKCHAIN = JObject.Parse(___BLOCKDATA);
                JArray items = (JArray)BLOCKCHAIN["blocks"];
                string Currenthash, BlockHash, PrevHash;
                if (items.Count > 1)
                {
                    for (int i = 0; i < items.Count - 1; i++)
                    {
                        BlockHash = (string)items[i]["blockhash"];
                        PrevHash = (string)items[i + 1]["previoushash"];
                        if (!BlocksChain.Validation(PrevHash, BlockHash))
                        {
                            Chainflag = false;
                            ResultText.Text += "\r\n------------------------------------";
                            ResultText.Text += "\r\nCHAIN ERROR AT BLOCK : " + (i + 1).ToString();
                            ResultText.Text += "\r\n------------------------------------";
                            break;
                        }
                        else
                        {
                            Chainflag = true;
                        }
                    }
                    if (Chainflag)
                    {
                        for (int y = 1; y < items.Count; y++)
                        {
                            Currenthash = BlocksChain.GenerateBlockHash((string)items[y]["votehash"], (string)items[y]["timestamp"], (string)items[y]["previoushash"], Configuration.SaltValue);
                            if (BlocksChain.BlockValidation(Currenthash, (string)items[y]["blockhash"]))
                            {
                                ResultText.Text += "\r\n------------------------------------";
                                ResultText.Text += "\r\nCORRUPT DATA IN BLOCK : " + (y + 1).ToString();
                                ResultText.Text += "\r\n------------------------------------";
                                Dataflag = false;
                                break;
                            }
                            else
                            {
                                Dataflag = true;
                            }
                        }
                    }
                    if (Chainflag && Dataflag)
                    {
                        ResultText.AppendText("\r\n-------------------------------------");
                        ResultText.AppendText("\r\nVALID BLOCK CHAIN -- COMPUTING RESULT");
                        ResultText.AppendText("\r\n-------------------------------------");
                    }

                    for(int z=0;z<items.Count;z++)
                    {
                        for(int ID = 70001; ID<= 70005; ID++)
                        {
                            Thread.Sleep(500);
                            for (int UID = 10001; UID<= 10005; UID++)
                            {
                                //ResultText.Text += "\r\n";
                                if ((string)items[z]["votehash"] == SILICON64.GenerateHash(ID.ToString() +UID. ToString()))
                                {
                                    Console.Beep(700, 500);
                                    ResultText.AppendText("\r\n\r\nBLOCK - [" + (z+1).ToString()+ "]\r\n");
                                    ResultText.AppendText("\r\nVOTE HASH  >>" + (string)items[z]["votehash"]);
                                    ResultText.AppendText("\r\nBLOCK HASH >>" + (string)items[z]["blockhash"]);
                                    if (ID == 70001)
                                        A++;
                                    if (ID == 70002)
                                        B++;
                                    if (ID == 70003)
                                        C++;
                                    if (ID == 70004)
                                        D++;
                                    if (ID == 70005)
                                        E++;
                                    Thread.Sleep(1500);
                                    continue;
                                }
                            }
                        }
                    }
                    
                    ResultText.Text += "\r\n\r\n";
                    Console.Beep(500, 2500);
                    ResultText.Text += "\r\n70001	ALPHA  : " + A.ToString();
                    ResultText.Text += "\r\n70002	BETA   : " + B.ToString();
                    ResultText.Text += "\r\n70003	DELTA  : " + C.ToString();
                    ResultText.Text += "\r\n70004	GAMMA  : " + D.ToString();
                    ResultText.Text += "\r\n70005	ECHO   : " + E.ToString();
                }
                else
                {
                    ResultText.Text = "EMPTY CHAIN";
                }
            }
            else
            {
                ResultText.Text = "Blocks not found!!";
            }

        }
    }
}
