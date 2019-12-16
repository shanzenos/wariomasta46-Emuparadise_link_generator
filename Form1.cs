using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wariomasta46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //Url conversion
        private void createlink_Click(object sender, EventArgs e)
        {
            outputstring.Text = "https://www.emuparadise.me/roms/get-download.php?gid=" + inputstring.Text.Substring(Regex.Match(inputstring.Text, @"[/]", RegexOptions.RightToLeft).Index + 1) + "&test=true";
            inputstring.Text = String.Empty;
        }

        
        private void inputstring_enter(object sender, EventArgs e)
        {
            if (inputstring.Text == "https://www.emuparadise.me/Sega_32X_ROMs/BC_Racers_(32X)/90860")
            {
                inputstring.Text = "";

                inputstring.ForeColor = Color.Black;
            }

        }
        
        private void inputstring_leave(object sender, EventArgs e)
        {
            if (inputstring.Text == "")
            {
                inputstring.Text = "https://www.emuparadise.me/Sega_32X_ROMs/BC_Racers_(32X)/90860";

                inputstring.ForeColor = Color.Silver;
            }

        }
        
        private void copylink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputstring.Text);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(outputstring.Text);
        }

        private void EPlink_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://www.emuparadise.me/");
        }
    }
}
