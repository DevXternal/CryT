using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryT
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void KeyUI_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
         System.Diagnostics.Process.Start("https://discord.com/invite/GZxwnRt8k4");
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CryT mainui = new CryT();
            mainui.Show();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerisonInformation vi = new VerisonInformation();
            vi.Show();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/x35EwdRzRy");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://wearedevs.net/d/Exploit%20API");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Hide();
            LuaC ctlc = new LuaC();
            ctlc.Show();
        }
    }
}
