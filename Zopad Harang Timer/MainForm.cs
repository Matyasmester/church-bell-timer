using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zopad_Harang_Timer
{
    public partial class MainForm : Form
    {
        private protected string FULLPATH = @"harangs.txt";
        private bool HasValidCustomPath = false;
        public MainForm()
        {
            InitializeComponent();
            PathLabel.Text = FULLPATH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateCustomPathStatus()
        {
            HasValidCustomPath = !string.IsNullOrEmpty(PathBox.Text) && CustomPathCheck.Checked;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            UpdateCustomPathStatus();
            List<string> lines = HasValidCustomPath ? File.ReadAllLines(PathBox.Text).ToList() : File.ReadAllLines(FULLPATH).ToList();

            if (lines.Count - 1 < 0) return;

            lines.Remove(lines.Last());

            if(HasValidCustomPath) File.WriteAllLines(PathBox.Text, lines);
            else { File.WriteAllLines(FULLPATH, lines); }
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomPathCheck_CheckedChanged(object sender, EventArgs e)
        {
            PathBox.Visible = !PathBox.Visible;
            WarningLabel.Visible = !WarningLabel.Visible;
        }

        private void WriteDates(string text)
        {
            UpdateCustomPathStatus();
            if (HasValidCustomPath) File.AppendAllText(PathBox.Text, text);
            else
            {
                File.AppendAllText(FULLPATH, text);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            EndButton.Enabled = true;
            StartButton.Enabled = false;
            ProgressLabel.Visible = true;
            string text = "Started: " + DateTime.Now.ToString() + " | ";
            WriteDates(text);
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            EndButton.Enabled = false;
            ProgressLabel.Visible = false;
            StartButton.Enabled = true;
            string text = "Ended: " + DateTime.Now.TimeOfDay.ToString() + "\n";
            WriteDates(text);
        }
    }
}
