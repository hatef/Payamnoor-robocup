using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Configure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         Host.Text=Configs.ServerConf.Default.Host;
         HostIp.Text = Configs.ServerConf.Default.HostIP;
         Port.Text = Configs.ServerConf.Default.Port.ToString();
         cDegree.Text =Configs.ServerConf.Default.CircleDegree.ToString();
         tName.Text = Configs.ServerConf.Default.TeamName;
         gTime.Text = Configs.ServerConf.Default.GameTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configs.ServerConf.Default.Host=Host.Text;
            Configs.ServerConf.Default.HostIP = HostIp.Text;
            Configs.ServerConf.Default.Port = int.Parse(Port.Text);
            Configs.ServerConf.Default.CircleDegree = int.Parse(cDegree.Text);
            Configs.ServerConf.Default.TeamName = tName.Text;
            Configs.ServerConf.Default.GameTime = int.Parse(gTime.Text);
            Configs.ServerConf.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
