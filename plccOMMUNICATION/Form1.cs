using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;

namespace plccOMMUNICATION
{
    public partial class Form1 : Form
    {
        ActUtlType PLC;
        Thread plcthread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            plcthread = new Thread(new ThreadStart(startPlCThread));
            plcthread.Start();

            plcthread = new Thread(new ThreadStart(ReadDataFromPLC));
            plcthread.Start();

            plcthread = new Thread(new ThreadStart(ReadDataFromPLC));
            plcthread.Start();

            plcthread = new Thread(new ThreadStart(ContinousOnFF));
            plcthread.Start();
        }

        private void startPlCThread()
        {
            PLC = new ActUtlType();
            PLC.ActLogicalStationNumber = 1;
        start:
            int IsPlcOpen = PLC.Open();//25202689

            while (true)
            {

                Thread.Sleep(100);
                if (IsPlcOpen == 0)
                {
                    lblplcopen.Text = "PlC Open";
                    lblplcopen.BackColor = Color.LightGreen;

                    ReadDataFromPLC();
                    // WriteDataToPLC();
                    if (IsPlcOpen != 0)
                    {
                        goto start;
                    }
                }
                else
                {
                    lblplcopen.Text = "plc not open";
                    lblplcopen.BackColor = Color.Red;
                    goto start;
                }

            }

        }

        private void ReadDataFromPLC()
        {
            try
            {
                if (PLC != null)
                {

                    int dataValue = 0;
                    int resultCode = PLC.GetDevice("M30", out dataValue);

                    if (resultCode == 0)
                    {
                        lblplcRead.Text = "M30" + "-" + dataValue;
                        lblplcRead.BackColor = Color.Green;
                    }
                    else
                    {
                        lblplcRead.Text = resultCode.ToString();
                        lblplcRead.BackColor = Color.Red;
                    }

                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.BackColor = Color.Red;
            }
        }

        private void WriteDataToPLC(bool setHigh)
        {
            try
            {
                if (PLC != null)
                {
                    string deviceName = "M10";
                    int valueToSet = setHigh ? 1 : 0;

                    int resultCode = PLC.SetDevice(deviceName, valueToSet);

                    if (resultCode == 0)  // 0 means success
                    {
                        plcwrite.Text = "PLC write   :" + deviceName + "----" + valueToSet;
                        plcwrite.BackColor = Color.Red;

                    }
                    else
                    {
                        plcwrite.BackColor = Color.Red;
                        plcwrite.Text = resultCode.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.BackColor = Color.Red;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // plcthread.DisableComObjectEagerCleanup();

        }
        private void ReadDataFromPLCbackup()
        {
            try
            {
                if (PLC != null)
                {
                    string deviceName = "D100";
                    int dataValue = 0;
                    int resultCode = PLC.GetDevice(deviceName, out dataValue);
                    this.Invoke(new Action(() =>
                    {
                        if (resultCode == 0)
                        {
                            lblplcRead.Text = "Read data" + deviceName + "" + dataValue;
                            lblplcRead.BackColor = Color.Green;
                        }
                        else
                        {
                            lblplcRead.Text = resultCode.ToString();
                            lblplcRead.BackColor = Color.Red;
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.BackColor = Color.Red;
            }
        }

        private void btnSethigh_Click(object sender, EventArgs e)
        {
            WriteDataToPLC(true);
        }

        private void btnSetLow_Click(object sender, EventArgs e)
        {
            WriteDataToPLC(false);
        }
        private void ContinousOnFF()
        {
            while (true)
            {
                Thread.Sleep(5000);
                WriteDataToPLC(true);
                Thread.Sleep(5000);
                WriteDataToPLC(false);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLC != null)
                {
                    string deviceName = "D30";
                    int valueToSet = 500;

                    int resultCode = PLC.SetDevice(deviceName, valueToSet);

                    if (resultCode == 0)  // 0 means success
                    {
                        plcwrite.Text = "PLC write   :" + deviceName + "----" + valueToSet;
                        plcwrite.BackColor = Color.Red;

                    }
                    else
                    {
                        plcwrite.BackColor = Color.Red;
                        plcwrite.Text = resultCode.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.BackColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLC != null)
                {
                    string deviceName = "D31";
                    int dataValue = 0;
                    int resultCode = PLC.GetDevice(deviceName, out dataValue);
                    this.Invoke(new Action(() =>
                    {
                        if (resultCode == 0)
                        {
                            lblDataFromPLC.Text = "Read data : " + deviceName + "     " + dataValue;
                            lblDataFromPLC.BackColor = Color.Green;
                        }
                        else
                        {
                            lblDataFromPLC.Text = resultCode.ToString();
                            lblDataFromPLC.BackColor = Color.Red;
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string textToSend = "hello";
                string baseDeviceName = "D100";

                for (int i = 0; i < textToSend.Length; i++)
                {
                    string deviceName = baseDeviceName + i;  // Adjust based on your PLC’s addressing scheme
                    int asciiValue = (int)textToSend[i];

                    int resultCode = PLC.SetDevice(deviceName, asciiValue);

                    if (resultCode != 0)
                    {
                        plcwrite.Text = $"Error writing {textToSend[i]} to {deviceName}. Error code: {resultCode}";
                        plcwrite.BackColor = Color.Red;
                        return;
                    }
                }

                MessageBox.Show("send data ");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.BackColor = Color.Red;

            }







        }


//          try
//            {
//                string textToSend = "hello";
//        string baseDeviceName = "D100";

            //                for (int i = 0; i<textToSend.Length; i++)
            //                {
            //                    string deviceName = baseDeviceName + i;  // Adjust based on your PLC’s addressing scheme
            //        int asciiValue = (int)textToSend[i];

            //        int resultCode = PLC.SetDevice(deviceName, asciiValue);

            //                    if (resultCode != 0)
            //                    {
            //                        plcwrite.Text = $"Error writing {textToSend[i]} to {deviceName}. Error code: {resultCode}";
            //                        plcwrite.BackColor = Color.Red;
            //                        return;
            //                    }
            //}

            //MessageBox.Show("send data ");
            //            }
            //            catch (Exception ex)
            //            {
            //                lblError.Text = ex.Message;
            //lblError.BackColor = Color.Red;

            //            }



    }
}
