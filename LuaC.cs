using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace CryT
{
    public partial class LuaC : Form
    {
        ExploitAPI module = new ExploitAPI();
        public LuaC()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Hide();
            Loader loader = new Loader();
            loader.Show();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            LuaCText.Clear();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            module.SendLuaCScript(LuaCText.Text);
        }
    }
}
