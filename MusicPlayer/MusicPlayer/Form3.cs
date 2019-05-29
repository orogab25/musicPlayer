using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class f_options : Form
    {
        string be;

        //Form
        public f_options()
        {
            InitializeComponent();

            //Checking config file
            if (!File.Exists("config.ini"))
            {
                StreamWriter configWrite = new StreamWriter("config.ini");

                cB_Device.SelectedIndex=0;
                cB_Skin.SelectedIndex = 0;
                configWrite.WriteLine("[options]");
                configWrite.WriteLine("Device=0");
                configWrite.WriteLine("Skin=0");

                configWrite.Close();
            }
            //Reading config
            else
            {
                StreamReader configRead = new StreamReader("config.ini");

                while (configRead.Peek() > -1)
                {
                    be = configRead.ReadLine();

                    if (be.StartsWith("Device"))
                    {
                        cB_Device.SelectedIndex = Int32.Parse(be.Substring(be.Length-1,1));
                    }

                    if (be.StartsWith("Skin"))
                    {
                        cB_Skin.SelectedIndex = Int32.Parse(be.Substring(be.Length - 1, 1));
                    }
                }
                configRead.Close();
            }
        }

        //Cancel
        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //Apply
        private void b_apply_Click(object sender, EventArgs e)
        {
            StreamWriter configWrite = new StreamWriter("config.ini");

            configWrite.WriteLine("[options]");
            configWrite.WriteLine("Device="+ cB_Device.SelectedIndex);
            configWrite.WriteLine("Skin=" + cB_Skin.SelectedIndex);

            configWrite.Close();

            MessageBox.Show("Please restart the program to apply new settings!","Restart",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            this.Visible = false;
        }
    }
}
