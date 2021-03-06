﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using Newtonsoft.Json;//.Converters;

namespace COMSender
{
    public partial class Form1 : Form
    {
        struct speedItems {
            public string cpuName;
            public string cpuSpeed;
            public string cpuUsage;
            public string amountRam;
            public string ramUse;
            public string batterySpecs;
            public string pcName;
            public string osName;
            public bool connectionStatus;
            public string time;
            public string date;
            public string author;
            //public string cpuTemp;
        };

        Timer timer;

        speedItems spd;

        const string cpuKey = "Win32_Processor";
        const string ramKey = "Win32_OperatingSystem";
        const string batKey = "Win32_Battery";
        const string tempKey = "MSAcpi_ThermalZoneTemperature";

        string comPort = "";

        private SerialPort port;// = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        ~Form1()
        {

        }

        

        void setStatus(bool isSending)
        {
            if (isSending)
            {
                lbStatus.Text = "Connected";
                lbStatus.ForeColor = Color.Green;
                ntfIcon.Text = "Connected";
            }
            else
            {
                lbStatus.Text = "Disconnected";
                lbStatus.ForeColor = Color.Red;
                ntfIcon.Text = "Disconnected";
            }
        }

        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();

            ntfIcon.MouseDoubleClick += (s, e) => {
                Show();
                this.WindowState = FormWindowState.Normal;
                //ntfIcon.Visible = false;
            };

            Resize += (s, e) => {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    //ntfIcon.Visible = true;
                }
            };

            Load += (s, e) => {

                foreach(var p in ports.ToList())
                {
                    cmbCOMPorts.Items.Add(p);
                }

                if (ports.Length > 0)
                    cmbCOMPorts.SelectedIndex = 0;

                setStatus(false);
               
                var cpu = getSystemData(cpuKey);
                var ram = getSystemData(ramKey);
                var bat = getSystemData(batKey);

                #region DATA   
                {
                    Debug.WriteLine(cpu.Count);
                    foreach (var c in cpu)
                    {
                        spd.cpuName = c["Name"].ToString();
                        spd.cpuUsage = c["LoadPercentage"].ToString();
                        spd.cpuSpeed = c["CurrentClockSpeed"].ToString() + " MHZ";
                    }

                    foreach (var r in ram)
                    {
                        double free = Double.Parse(r["FreePhysicalMemory"].ToString());
                        double total = Double.Parse(r["TotalVisibleMemorySize"].ToString());

                        double percentage = Math.Round(((total - free) / total * 100));
                        spd.amountRam = "T: " + (Math.Round(total / (1024 * 1024), 1)).ToString() + " GB" + " F: " + (Math.Round(free / (1024 * 1024), 1)).ToString() + " GB";
                        spd.ramUse = percentage.ToString() + " %";

                        spd.osName = r["Caption"].ToString();
                    }

                    foreach (var b in bat)
                    {
                        spd.batterySpecs = b["EstimatedChargeRemaining"].ToString() + " %";
                    }

                    string serverName = System.Windows.Forms.SystemInformation.ComputerName;
                    lbPCName.Text = serverName;
                    lbCPUName.Text = spd.cpuName;
                    lbCPUSpeed.Text = spd.cpuSpeed;
                    lbCPUUsage.Text = spd.cpuUsage;
                    lbRAMUse.Text = spd.ramUse;
                    lbBatSpecs.Text = spd.batterySpecs;

                    Debug.WriteLine(cpu.ToString());
                }
                #endregion;
            };


            btnSend.Click += (s, e) => {
                comPort = (string)cmbCOMPorts.SelectedItem;
                if(comPort != null)
                {
                    if (port == null)
                    {
                        port = new SerialPort(comPort, 115200, Parity.None, 8, StopBits.One);
                        //port.Open();
                        setStatus(true);
                    }
                    else
                    {
                        port.Close();
                        port = new SerialPort(comPort, 115200, Parity.None, 8, StopBits.One);
                        //port.Open();
                        setStatus(true);
                    }
                }
            };

            btnDisconnectCOM.Click += (s, e) => {
                if (port != null)
                {
                    spd.connectionStatus = false;
                    var jsonString = JsonConvert.SerializeObject(spd);
                    //port.Open();
                    if (port.IsOpen)
                        port.WriteLine(jsonString);
                    else
                    {
                        port.Open();
                        port.WriteLine(jsonString);
                    }
                    port.Close();
                    port = null;
                    setStatus(false);
                }
            };

            btnRefreshCOM.Click += (s, e) => {
                string[] ps = SerialPort.GetPortNames();
                cmbCOMPorts.Items.Clear();
                foreach (var p in ps.ToList())
                {
                    cmbCOMPorts.Items.Add(p);
                }
            };

            FormClosing += (s, e) => {
                if (port != null)
                {
                    spd.connectionStatus = false;
                    var jsonString = JsonConvert.SerializeObject(spd);
                    //port.Open();
                    if (port.IsOpen)
                        port.WriteLine(jsonString);
                    else
                    {
                        port.Open();
                        port.WriteLine(jsonString);
                    }

                    port.Close();
                    port = null;
                }
            };

            timer = new Timer();
            timer.Interval = 45000;
            timer.Start();

            timer.Tick += (s, e) => {
                try
                {
                    if (port != null)
                    {
                        port.Open();
                    }
                    #region DATA   
                    var cpu = getSystemData(cpuKey);
                    var ram = getSystemData(ramKey);
                    var bat = getSystemData(batKey);
                    //var temp = getSystemDataWMI(tempKey);

                    {
                        Debug.WriteLine(cpu.Count);
                        foreach (var c in cpu)
                        {
                            spd.cpuName = c["Name"].ToString();
                            spd.cpuUsage = c["LoadPercentage"].ToString();
                            spd.cpuSpeed = c["CurrentClockSpeed"].ToString() + " Mhz";
                        }

                        foreach (var r in ram)
                        {
                            double free = Double.Parse(r["FreePhysicalMemory"].ToString());
                            double total = Double.Parse(r["TotalVisibleMemorySize"].ToString());

                            double percentage = Math.Round(((total - free) / total * 100));
                            spd.amountRam = "T: " + (Math.Round(total / (1024 * 1024), 1)).ToString() + " GB" + " F: " + (Math.Round(free / (1024 * 1024), 1)).ToString() + " GB";
                            spd.amountRam = "T: " + (Math.Round(total / (1024 * 1024), 1)).ToString() + " GB" + " F: " + (Math.Round(free / (1024 * 1024), 1)).ToString() + " GB";
                            spd.ramUse = percentage.ToString() + " %";

                            spd.osName = r["Caption"].ToString();
                        }

                        foreach (var b in bat)
                        {
                            spd.batterySpecs = b["EstimatedChargeRemaining"].ToString() + " %";
                        }

                        //foreach(var t in temp)
                        //{
                        //    Double cpuTemp = Convert.ToDouble(t["CurrentTemperature"].ToString());
                        //    cpuTemp = (cpuTemp - 2732) / 10.0;

                        //    spd.cpuTemp = cpuTemp.ToString();

                        //}

                        string serverName = System.Windows.Forms.SystemInformation.ComputerName;
                        spd.pcName = serverName;
                        spd.connectionStatus = true;

                        var now = DateTime.Now;
                        spd.time = now.ToString("hh:mm:ss tt");//("HH:mm:ss");
                        spd.date = now.ToString("dd-MMM-yyyy");
                        spd.author = "BR4Y0\'64\'S4V4G3";

                        lbPCName.Text = serverName;
                        lbCPUName.Text = spd.cpuName;
                        lbCPUSpeed.Text = spd.cpuSpeed;
                        lbCPUUsage.Text = spd.cpuUsage;
                        lbRAMUse.Text = spd.ramUse;
                        lbBatSpecs.Text = spd.batterySpecs;

                        Debug.WriteLine(cpu.ToString());
                        if (port != null)
                        {
                            var jsonString = JsonConvert.SerializeObject(spd);
                            Debug.WriteLine(jsonString);
                            //port.Open();
                            if (port.IsOpen)
                            {
                                port.WriteLine(jsonString);
                                port.Close();
                            }
                            else
                            {
                                //port.Open();
                                port.WriteLine(jsonString);
                                port.Close();
                            }
                        }
                    }
                    #endregion;
                }catch(Exception r)
                {
                    Debug.WriteLine(r.Message);//Silently SWALLOW ERRORS    
                }
            };       
        }

        

        ManagementObjectCollection getSystemData(string key)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + key);
            return searcher.Get();           
        }


        ManagementObjectCollection getSystemDataWMI(string key)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "select * from " + key);
            return searcher.Get();
        }
    }
}
