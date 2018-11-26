namespace IDS
{
    partial class form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Processes = new System.Windows.Forms.ListBox();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.button_Scan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Processes
            // 
            this.listBox_Processes.FormattingEnabled = true;
            this.listBox_Processes.ItemHeight = 20;
            this.listBox_Processes.Location = new System.Drawing.Point(7, 19);
            this.listBox_Processes.Name = "listBox_Processes";
            this.listBox_Processes.Size = new System.Drawing.Size(359, 424);
            this.listBox_Processes.TabIndex = 0;
            // 
            // buttonAttach
            // 
            this.buttonAttach.Location = new System.Drawing.Point(186, 450);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(84, 36);
            this.buttonAttach.TabIndex = 1;
            this.buttonAttach.Text = "Attach";
            this.buttonAttach.UseVisualStyleBackColor = true;
            this.buttonAttach.Click += new System.EventHandler(this.buttonAttach_Click);
            // 
            // button_Scan
            // 
            this.button_Scan.Location = new System.Drawing.Point(96, 450);
            this.button_Scan.Name = "button_Scan";
            this.button_Scan.Size = new System.Drawing.Size(84, 36);
            this.button_Scan.TabIndex = 2;
            this.button_Scan.Text = "Scan";
            this.button_Scan.UseVisualStyleBackColor = true;
            this.button_Scan.Click += new System.EventHandler(this.button_Scan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Scan);
            this.groupBox1.Controls.Add(this.buttonAttach);
            this.groupBox1.Controls.Add(this.listBox_Processes);
            this.groupBox1.Location = new System.Drawing.Point(5, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 495);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 491);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_Main";
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Processes;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Button button_Scan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

