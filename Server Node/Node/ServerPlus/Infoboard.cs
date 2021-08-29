using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace Node
{
    public partial class Infoboard : Form
    {
        Boolean Dataflag = true, Chainflag = true;
        public Infoboard()
        {
            InitializeComponent();
        }

        private void DatabaseServer_Load(object sender, EventArgs e)
        {
            DataRequest.Start();
            BlockValidator.Start();
        }

        private void DataRequest_Tick(object sender, EventArgs e)
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
                    if (_BlockGrid.Rows.Count < items.Count)
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            _BlockGrid.Rows.Add(
                            new object[]
                            {
                            items[i]["timestamp"],
                            items[i]["previoushash"],
                            items[i]["blockhash"]
                            }
                            );
                        }
                    }
                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                TotalBlocksTag.Text = "----";
                _BlockGrid.Rows.Clear();
                _StatusTag.Text = "Not Connected";
            }

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

        private void BlockValidation(object sender, EventArgs e)
        {
            if (File.Exists(@Utility.DATAPATH))
            {
                _StatusTag.Text = "VALID CHAIN";
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
                            _StatusTag.ForeColor = Color.Red;
                            _StatusTag.Text = "CHAIN ERROR";
                            _ChainErrorMessage.Text = "Chain error at block :" + (i + 1).ToString();
                            Thread _syncthread = new Thread(SyncRequest);
                            _syncthread.Start();
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
                            Currenthash = BlocksChain.GenerateBlockHash(Convert.ToString(items[y]["certificate"]), (string)items[y]["timestamp"], (string)items[y]["previoushash"], Configuration.SaltValue);
                            if (BlocksChain.BlockValidation(Currenthash, (string)items[y]["blockhash"]))
                            {
                                _StatusTag.ForeColor = Color.Red;
                                _ChainErrorMessage.Text = "Block data error at block :" + (y + 1).ToString();
                                _StatusTag.Text = "BLOCK DATA ERROR";
                                Dataflag = false;
                                Thread _syncthread = new Thread(SyncRequest);
                                _syncthread.Start();
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
                        _StatusTag.Text = "Valid Blockchain";
                        _StatusTag.ForeColor = Color.Orchid;
                        _ChainErrorMessage.Text = "";
                    }
                }
                else
                {
                    _StatusTag.Text = "EMPTY CHAIN";
                }
            }
            else
            {
                _StatusTag.Text = "Not Connected";
            }
        }
    }
}