/*
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.Button endProcessButton;
        private PerformanceCounter cpuCounter;
        private PerformanceCounter memoryCounter;
        private PerformanceCounter diskCounter;
        private PerformanceCounter networkCounter;

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();

            this.Load += new System.EventHandler(this.MainForm_Load);
            endProcessButton.Click += new System.EventHandler(this.endProcessButton_Click);

            // Initialize performance counters
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            memoryCounter = new PerformanceCounter("Memory", "Available MBytes");
            diskCounter = new PerformanceCounter("LogicalDisk", "% Free Space", "_Total");
            networkCounter = new PerformanceCounter("Network Interface", "Bytes Total/sec", "Intel(R) Wi-Fi 6 AX201 160MHz"); // Replace with your network interface name
        }

        private void InitializeComponents()
        {
            this.processListView = new System.Windows.Forms.ListView();
            this.endProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ListView
            this.processListView.FullRowSelect = true;
            this.processListView.GridLines = true;
            this.processListView.Location = new System.Drawing.Point(12, 12);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(776, 200);
            this.processListView.TabIndex = 0;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.View = System.Windows.Forms.View.Details;

            // Button
            this.endProcessButton.Location = new System.Drawing.Point(12, 220);
            this.endProcessButton.Name = "endProcessButton";
            this.endProcessButton.Size = new System.Drawing.Size(100, 30);
            this.endProcessButton.Text = "End Process";
            this.endProcessButton.UseVisualStyleBackColor = true;

            // Add controls to the form
            this.Controls.Add(this.processListView);
            this.Controls.Add(this.endProcessButton);

            this.ResumeLayout(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set up columns for the ListView
            processListView.Columns.Add("Process Name", 200);
            processListView.Columns.Add("Process ID", 80);
            processListView.Columns.Add("Working Set (Bytes)", 120);

            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            processListView.Items.Clear();

            foreach (var process in Process.GetProcesses())
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                item.SubItems.Add(process.WorkingSet64.ToString());
                processListView.Items.Add(item);
            }
        }

        private void endProcessButton_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in processListView.SelectedItems)
                {
                    int processId = int.Parse(item.SubItems[1].Text);
                    try
                    {
                        Process.GetProcessById(processId).Kill();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error terminating process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                RefreshProcessList();
            }
            else
            {
                MessageBox.Show("Please select a process to terminate.", "No Process Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.Button endProcessButton;
        private Label cpuLabel;
        private PerformanceCounter cpuCounter;

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();

            this.Load += new System.EventHandler(this.MainForm_Load);
            endProcessButton.Click += new System.EventHandler(this.endProcessButton_Click);

            // Initialize CPU performance counter
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        }

        private void InitializeComponents()
        {
            this.processListView = new System.Windows.Forms.ListView();
            this.endProcessButton = new System.Windows.Forms.Button();
            this.cpuLabel = new Label();
            this.SuspendLayout();

            // ListView
            this.processListView.FullRowSelect = true;
            this.processListView.GridLines = true;
            this.processListView.Location = new System.Drawing.Point(12, 12);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(776, 200);
            this.processListView.TabIndex = 0;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.View = System.Windows.Forms.View.Details;

            // Button
            this.endProcessButton.Location = new System.Drawing.Point(12, 220);
            this.endProcessButton.Name = "endProcessButton";
            this.endProcessButton.Size = new System.Drawing.Size(100, 30);
            this.endProcessButton.Text = "End Process";
            this.endProcessButton.UseVisualStyleBackColor = true;

            // CPU Label
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(12, 260);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(100, 20);

            // Add controls to the form
            this.Controls.Add(this.processListView);
            this.Controls.Add(this.endProcessButton);
            this.Controls.Add(this.cpuLabel);

            this.ResumeLayout(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set up columns for the ListView
            processListView.Columns.Add("Process Name", 200);
            processListView.Columns.Add("Process ID", 80);
            processListView.Columns.Add("Working Set (Bytes)", 120);

            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            processListView.Items.Clear();

            foreach (var process in Process.GetProcesses())
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                item.SubItems.Add(process.WorkingSet64.ToString());
                processListView.Items.Add(item);
            }
        }

        private void endProcessButton_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in processListView.SelectedItems)
                {
                    int processId = int.Parse(item.SubItems[1].Text);
                    try
                    {
                        Process.GetProcessById(processId).Kill();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error terminating process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                RefreshProcessList();
            }
            else
            {
                MessageBox.Show("Please select a process to terminate.", "No Process Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            // Update CPU label
            float cpuUsage = cpuCounter.NextValue();
            cpuLabel.Text = $"CPU Usage: {cpuUsage}%";
        }
    }
}
