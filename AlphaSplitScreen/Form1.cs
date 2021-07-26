using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace AlphaSplitScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m1XRes_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void m1YRes_TextChanged(object sender, EventArgs e)
        {

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                string M1SelectedRes = M1ResSelector.Text;
                string M2SelectedRes = M1ResSelector.Text;

                string M1XRes = M1SelectedRes.Substring(0, 4);
                M1XRes = M1XRes.Trim();

                string M2XRes = M1SelectedRes.Substring(0, 4);
                M2XRes = M1XRes.Trim();

                int M1IntRes = Convert.ToInt32(M1XRes);
                int M2IntRes = Convert.ToInt32(M2XRes);

                int newRes = M1IntRes + M2IntRes;

                string defaultRes = Convert.ToString(M1XRes);
                string newdefaultRes = "ResX=" + defaultRes;

                string newResStr = Convert.ToString(newRes);

                //const string FILENAME = @"C:\Users\Chris\Documents\My Games\Rocket League\TAGame\Config\TASystemSettings.ini";
                string FILENAME = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Rocket League\TAGame\Config\TASystemSettings.ini");

                string ResXText = File.ReadAllText(FILENAME);

                var updatedNewResX = Regex.Replace(ResXText, "\nResX=[0-9]*", match => $"\nResX={newResStr}");
                File.WriteAllText(FILENAME, updatedNewResX);

                string FullScreenText = File.ReadAllText(FILENAME);
                var updatedFullscreen = Regex.Replace(FullScreenText, "\nFullscreen=True*", match => $"\nFullscreen=False");
                File.WriteAllText(FILENAME, updatedFullscreen);

                string BorderlessCheck = File.ReadAllText(FILENAME);
                var updatedBorderless = Regex.Replace(BorderlessCheck, "\nBorderless=False*", match => $"\nBorderless=True");
                File.WriteAllText(FILENAME, updatedBorderless);

                Process.Start(FILENAME);
                //File.SetAttributes(FILENAME, FileAttributes.ReadOnly);
            }
            catch
            {
                MessageBox.Show("Error, Check you have set the resolutions correctly.");

            }
        }
        private void RestoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                const string FILENAME = @"C:\Users\Chris\Documents\My Games\Rocket League\TAGame\Config\TASystemSettings.ini";
                string text = File.ReadAllText(FILENAME);
                File.Delete(FILENAME);
            }
            catch
            {
                MessageBox.Show("Config File has already been deleted\nlaunch Rocket Reague to create a new config file and try again.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            M1ResSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            M2ResSelector.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BGImage_Click(object sender, EventArgs e)
        {
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It appears you need some help, if you have discovered a bug please send me an email @\nChrisWells2003@outlook.com\n If your game will not load after using the software it may be because your device cannot handle running double the resolution, to fix this press the restore button and reload Rocket League. Lower your graphics settings, close Rocket League and run AlphaSplitScreen again, then run Rocket League and the game should boot up on both your monitors.");
        }
    }
}
