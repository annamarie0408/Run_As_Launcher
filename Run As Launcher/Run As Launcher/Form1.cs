using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Run_As_Launcher
{
    public partial class _mainForm : Form
    {
        public _mainForm()
        {
            InitializeComponent();
            AllowDrop = true;
            DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string File in FileList)
            {
                Console.WriteLine(File);
                _filePathTxtBx.AppendText("\"" + File + "\"");
            }

        }

        private void _runBtn_Click(object sender, EventArgs e)
        {
            string _username = _userLoginTxtBx.Text;
            string _password = _userPassTxtBx.Text;
            string _file = _filePathTxtBx.Text;
            var _secPass = new SecureString();

            try
            {               
                foreach (var c in _password) _secPass.AppendChar(c);
                Process p = new Process();              
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = "/C" + _file;
                p.StartInfo.UserName = _username;
                p.StartInfo.Password = _secPass;                
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.LoadUserProfile = false;
                p.Start();
                _DebugLog("Profile loaded successfully, launching the following file: " + _file);
            }
            catch (Exception ex)
            {
                _DebugLog("ERROR \n" + ex.ToString());
                _DebugLog("The password for username " + _username + " is incorrect");
            }
            _filePathTxtBx.ResetText();
        }

        public static void _DebugLog(string logMessage)
        {
            string debugLog = "DebugLog.txt";
            try
            {
                File.AppendAllText(debugLog, logMessage + Environment.NewLine);
            }
            catch
            { }
        }
    }
}
