using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using IDS.Source;
using System.Diagnostics;

namespace IDS
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private void form_Main_Load(object sender, EventArgs e)
        {

        }

        private void button_Scan_Click(object sender, EventArgs e)
        {
            ProcessSnoop.updateProcessList();

            foreach (var proc in ProcessSnoop.processList)
            {
                listBox_Processes.Items.Add(new SnoopProcess(proc));
            }
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            if (listBox_Processes.SelectedItem != null)
                ProcessSnoop.processToMonitor = (Process) listBox_Processes.SelectedItem;
            
        }
    }
}
