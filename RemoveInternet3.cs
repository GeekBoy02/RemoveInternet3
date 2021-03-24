using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using NetFwTypeLib; // FirewallAPI.dll
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using IniParser;
using IniParser.Model;
using RemoveInternet3;

namespace RemoveInternet2
{
    public partial class RemoveInternet2 : Form
    {
        private Process[] listedProcesses;
        private List<string> blockedApps = new List<string>();
        public string saveFileName = "blockedApps.ini";
        private string logFileName = "log.txt";

        Form ActiveInfoBox; // infobox that is visible on screen, gets replaced everytime a new one is opend.

        public RemoveInternet2()
        {
            InitializeComponent();
        }

        private void RemoveInternet2_Load(object sender, EventArgs e)
        {
            WriteToLog(logFileName, "App started");
            ListOpenWindows();
            LoadBlockedListSaveFile(saveFileName);
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ListAllProcesess();
        }

        /// <summary>
        /// Lists all Processes, exept a few Windows tasks runnung on the System, into the listbox1.
        /// </summary>
        void ListAllProcesess()
        {
            Process me = Process.GetCurrentProcess();
            listedProcesses = Process.GetProcesses();

            for (int x = 0; x < listedProcesses.Length; x++)
            {
                Process p = listedProcesses[x];

                try
                {
                    if (p.Id != me.Id
                        && p.MainModule.ModuleName != "services.exe"
                        && p.MainModule.ModuleName != "conhost.exe"
                        && p.MainModule.ModuleName != "svchost.exe")
                    {
                        //listBox1.Items.Add(p.MainModule.ModuleName);
                    }
                    else
                    {
                        listedProcesses[x] = null;
                    }
                }
                catch
                {
                    listedProcesses[x] = null;
                }
            }

            int arrayLenght = 0; ;
            for (int x = 0; x < listedProcesses.Length; x++)
            {

                if (listedProcesses[x] != null)
                {
                    arrayLenght += 1;
                }
            }

            Process[] tempAllPs = new Process[arrayLenght];

            int i = 0;
            int j = 0;
            while (i < listedProcesses.Length)
            {
                if (listedProcesses[i] != null)
                {
                    tempAllPs[j] = listedProcesses[i];
                    j++;
                }
                i++;
            }

            listedProcesses = tempAllPs;

            for (int x = 0; x < listedProcesses.Length; x++)
            {
                try
                {
                    listBox1.Items.Add(listedProcesses[x].MainModule.ModuleName);
                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// Lists all processes running with open Windows in listbox1.
        /// </summary>
        void ListOpenWindows()
        {
            ListAllProcesess();
            listBox1.Items.Clear();

            int arrayLenght = 0; ;
            for (int x = 0; x < listedProcesses.Length; x++)
            {

                if (!String.IsNullOrEmpty(listedProcesses[x].MainWindowTitle))
                {
                    arrayLenght += 1;
                }
            }

            Process[] tempAllPs = new Process[arrayLenght];
            int i = 0;
            int j = 0;

            while (i < listedProcesses.Length)
            {
                if (!String.IsNullOrEmpty(listedProcesses[i].MainWindowTitle))
                {
                    tempAllPs[j] = listedProcesses[i];
                    j++;
                }
                i++;
            }

            listedProcesses = tempAllPs;

            for (int x = 0; x < listedProcesses.Length; x++)
            {
                listBox1.Items.Add(listedProcesses[x].MainWindowTitle);
            }
        }

        /// <summary>
        /// Makes a Firewall rule blocking an outgoing connections.
        /// </summary>
        /// <param name="appName">Filename of the executable that you want to block</param>
        /// <param name="addToBlockedAppsList">true if you want to add the filename to the blockedApps List variable</param>
        void BlockInternet(string appName, bool addToBlockedAppsList)
        {
            if (blockedApps.Contains(appName))
            {
                WriteToLog(logFileName, appName + " is already blocked");
                return;
            }

            INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            firewallRule.ApplicationName = appName;
            firewallRule.Description = appName;
            firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            firewallRule.Enabled = true;
            firewallRule.InterfaceTypes = "All";
            firewallRule.Name = "Block Internet for " + appName;

            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(firewallRule);

            if (addToBlockedAppsList)
            {
                blockedApps.Add(appName);
                ListBlockedApps();

            }

            WriteToLog(logFileName, appName + " is blocked");
        }

        /// <summary>
        /// Removes a Firewall rule blocking an outgoing connections.
        /// </summary>
        /// <param name="appName">Filename of the executable that you want to unblock</param>
        /// <param name="removeFromBlockedAppsList">true if you want to remove the filename from the blockedApps List variable</param>
        void UnBlockInternet(string appName, bool removeFromBlockedAppsList)
        {
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Remove("Block Internet for " + appName);

            if (removeFromBlockedAppsList)
            {
                blockedApps.Remove(appName);
                ListBlockedApps();
            }

            WriteToLog(logFileName, appName + " is unblocked");
        }

        /// <summary>
        /// Removes all Firewall rules blocking an outgoing connections.
        /// </summary>
        void UnBlockAllInternet()
        {
            for (int x = 0; x < blockedApps.Count; x++)
            {
                UnBlockInternet(blockedApps[x], false);
            }

            blockedApps = new List<string>();

            ListBlockedApps();

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ProcessNameValue_lbl.Text = listedProcesses[listBox1.SelectedIndex].ProcessName;
                PorcessIDvalue_lbl.Text = "" + listedProcesses[listBox1.SelectedIndex].Id;
                ProcessLocationValue_lbl.Text = listedProcesses[listBox1.SelectedIndex].MainModule.FileName;
            }
        }

        private void Block_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                BlockInternet(listedProcesses[listBox1.SelectedIndex].MainModule.FileName, true);
            }
        }

        private void Unblock_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                UnBlockInternet(listedProcesses[listBox1.SelectedIndex].MainModule.FileName, true);

            }
        }

        /// <summary>
        /// Unblocks apps from FirewallBockedApps Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Unblock2_btn_Click(object sender, EventArgs e)
        {
            if (blockedApps_listbox.SelectedIndex > -1)
            {
                UnBlockInternet(blockedApps[blockedApps_listbox.SelectedIndex], true);
            }
        }

        private void ListRunningPs_btn_Click(object sender, EventArgs e)
        {
            ListOpenWindows();
        }

        private void UnBlockAllApps_btn_Click(object sender, EventArgs e)
        {
            UnBlockAllInternet();
        }

        /// <summary>
        /// Lists the blocked apps in the blockedapps listbox and updates the blockedList savefile
        /// </summary>
        void ListBlockedApps()
        {
            blockedApps_listbox.Items.Clear();

            if (blockedApps.Count > 0)
            {
                for (int x = 0; x < blockedApps.Count; x++)
                {
                    blockedApps_listbox.Items.Add(Path.GetFileName(blockedApps[x]));
                }
            }

            UpdateBlockedListSaveFile(saveFileName);
        }

        /// <summary>
        /// Syncs the given XML savefile with the given List variable.
        /// </summary>
        /// <param name="blockedAppsList"></param>
        /// <param name="saveFileName"></param>
        void UpdateBlockedListSaveFile(string saveFileName)
        {
            var parser = new FileIniDataParser();

            if (!File.Exists(saveFileName))
            {
                IniData freshSaveIni = new IniData();
                //["appname"]["path"] = "pathString";
                parser.WriteFile(saveFileName, freshSaveIni, Encoding.ASCII);
                WriteToLog(logFileName, "Creating Ini savefile");
            }

            IniData saveIni = new IniData();
            //SectionData blockedApps_Section = new SectionData("blockedApps");
            //saveIni.Sections.Add(blockedApps_Section);
            //XElement blockedAppsElement = new XElement("blockedApps");

            for (int x = 0; x < blockedApps.Count; x++)
            {
                WriteToLog(logFileName, blockedApps[x] + " added to Ini savefile");
                string name = Regex.Replace(Path.GetFileName(blockedApps[x]), @"\s+", "_");
                saveIni[name]["path"] = blockedApps[x];
                //saveIni.IniWriteValue("blockedApps", name, blockedApps[x]);                           ______________________
            }

            parser.WriteFile(saveFileName, saveIni, Encoding.ASCII);
        }

        /// <summary>
        /// Loads and lists the blocked applications from the given XML savefile
        /// </summary>
        /// <param name="saveFileName"></param>
        void LoadBlockedListSaveFile(string saveFileName)
        {
            if (!File.Exists(saveFileName))
            {
                WriteToLog(logFileName, "no Ini file found");
                return;
            }

            blockedApps = new List<string>();

            var parser = new FileIniDataParser();
            IniData blockedAppsIni = parser.ReadFile(saveFileName);
            foreach (var section in blockedAppsIni.Sections)
            {
                blockedApps.Add(section.Keys.GetKeyData("path").Value);
            }

            ListBlockedApps();
        }

        /// <summary>
        /// Appends a string to a textfile in a new line
        /// </summary>
        /// <param name="filePath">Textfile path</param>
        /// <param name="message">String you want to append</param>
        void WriteToLog(string filePath, string message)
        {
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, message + Environment.NewLine);
            }
            else
            {
                File.WriteAllText(logFileName, "");
                File.AppendAllText(filePath, message + Environment.NewLine);
            }
        }

        /// <summary>
        /// work in progress
        /// </summary>
        /// <returns></returns>
        int NetworkSpeed()
        {

            return 0;
        }

        private void selectFileToBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ProcessNameValue_lbl.Text = "";
            PorcessIDvalue_lbl.Text = "";
            ProcessLocationValue_lbl.Text = openFileDialog1.FileName;
            listBox1.ClearSelected();

            BlockInternet(openFileDialog1.FileName, true);
        }

        private void ListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ActiveProcess_contextMenu.Show(MousePosition);
            }
        }

        private void blockedApps_listbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                BlockedList_contextMenu.Show(MousePosition);
            }
        }

        private void blockItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                BlockInternet(listedProcesses[listBox1.SelectedIndex].MainModule.FileName, true);
            }
        }

        private void unblockApp_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                UnBlockInternet(listedProcesses[listBox1.SelectedIndex].MainModule.FileName, true);

            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                BlockInternet(listedProcesses[listBox1.SelectedIndex].MainModule.FileName, true);
            }
        }

        private void blockedApps_listbox_DoubleClick(object sender, EventArgs e)
        {
            if (blockedApps_listbox.SelectedIndex > -1)
            {
                UnBlockInternet(blockedApps[blockedApps_listbox.SelectedIndex], true);
            }
        }

        private void unBlockAllApps_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UnBlockAllInternet();
        }

        private void unblockApp_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (blockedApps_listbox.SelectedIndex > -1)
            {
                UnBlockInternet(blockedApps[blockedApps_listbox.SelectedIndex], true);
            }
        }

        private void listAlProcesess_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ListAllProcesess();
        }

        private void listOpenWindows_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOpenWindows();
        }

        private void thereIsNoHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenInfoBox("With this small tool you can quickly add apps to the Firewall in order to block Outbound connections");

        }

        private void showPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (blockedApps_listbox.SelectedIndex > -1)
            {
                OpenInfoBox(blockedApps[blockedApps_listbox.SelectedIndex]);
            }
        }

        private void showPath_btn_Click(object sender, EventArgs e)
        {
            if (blockedApps_listbox.SelectedIndex > -1)
            {
                OpenInfoBox(blockedApps[blockedApps_listbox.SelectedIndex]);
            }
        }

        private void OpenInfoBox(string infotext)
        {
            if (ActiveInfoBox != null)
            {
                ActiveInfoBox.Close();
            }

            InfoBox ib = new InfoBox();
            ib.infoText_lbl.Text = infotext;
            ib.Location = ActiveForm.Location;
            ib.Show();

            ActiveInfoBox = ib;
        }
    }
}
