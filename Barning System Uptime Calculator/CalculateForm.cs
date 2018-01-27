using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarningSystemUptimeCalculator;
using Microsoft.Win32;
using System.Diagnostics;
using System.Management;   //This namespace is used to work with WMI classes. For using this namespace add reference of System.Management.dll .

namespace CalculateFormApplication
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {
            BarningSystemUptimeCalculator.BarningSystemUptimeCalculator barn = new BarningSystemUptimeCalculator.BarningSystemUptimeCalculator();
            // GetUpTime();
            barn.Close();
            string systeUp = GetUpTime().ToString();



            //gengetate the colums

            string days = GetUpTime().TotalDays.ToString();
           

            var sytemInfo = new ListViewItem(new[] { FriendlyName(), GetUpTime().TotalDays.ToString(), GetUpTime().TotalHours.ToString(), GetUpTime().TotalMinutes.ToString(), GetUpTime().TotalSeconds.ToString(), GetUpTime().TotalMilliseconds.ToString() });            
            listView1.Items.Add(sytemInfo);                       

        }

        public static TimeSpan GetUpTime()
        {
            TimeSpan t = TimeSpan.FromMilliseconds(GetTickCount64());
            string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                        t.Hours,
                        t.Minutes,
                        t.Seconds,
                        t.Milliseconds);
            return t;
        }

        [DllImport("kernel32")]
        extern static UInt64 GetTickCount64();

       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       

        public string HKLM_GetString(string path, string key)
        {
            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey(path);
                if (rk == null) return "";
                return (string)rk.GetValue(key);
            }
            catch { return ""; }
        }

        public string FriendlyName()
        {
            string ProductName = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName");
            string CSDVersion = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CSDVersion");
            string ProductId = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductID");
            if (ProductName != "")
            {
                return (ProductName.StartsWith("Microsoft") ? "" : "Microsoft ") + ProductName +
                            (CSDVersion != "" ? " " + CSDVersion : "") +
                           (ProductId !="" ? " "+ "Computer ID: " + ProductId: "");
            }
            return "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
