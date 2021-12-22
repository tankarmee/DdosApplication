using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DdosBox
{
    public partial class Form1 : Form
    {
        HttpRequest Ddos = new HttpRequest();
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/tankarmee/DdosApplication");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ddos.DdosAttack(this.UrlText.Text, this.ContentText.Text, this.UsernameText.Text, "application/json;charset=utf-8", Convert.ToInt32(this.RepeatNum.Text));
        }
    }
}
