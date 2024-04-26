namespace SampleForm
{
    partial class MainWindow
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
            btnConnect = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnDump = new System.Windows.Forms.Button();
            btnSettings = new System.Windows.Forms.Button();
            OpenEmulator = new OpenEmulator();
            btnDisconnect = new System.Windows.Forms.Button();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(1055, 23);
            btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(134, 38);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(1055, 199);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(134, 38);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(1055, 111);
            btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(134, 38);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDump
            // 
            btnDump.Location = new System.Drawing.Point(1055, 243);
            btnDump.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDump.Name = "btnDump";
            btnDump.Size = new System.Drawing.Size(134, 38);
            btnDump.TabIndex = 4;
            btnDump.Text = "Dump";
            btnDump.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Location = new System.Drawing.Point(1055, 155);
            btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(134, 38);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // OpenEmulator
            // 
            OpenEmulator.AcceptsTab = true;
            OpenEmulator.BackColor = System.Drawing.Color.Black;
            OpenEmulator.ForeColor = System.Drawing.Color.Lime;
            OpenEmulator.Location = new System.Drawing.Point(14, 14);
            OpenEmulator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            OpenEmulator.MaxLength = 1920;
            OpenEmulator.Name = "OpenEmulator";
            OpenEmulator.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            OpenEmulator.Size = new System.Drawing.Size(1009, 677);
            OpenEmulator.TabIndex = 0;
            OpenEmulator.Text = "";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new System.Drawing.Point(1055, 67);
            btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(134, 38);
            btnDisconnect.TabIndex = 6;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new System.Drawing.Point(0, 691);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1202, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1202, 713);
            Controls.Add(statusStrip1);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSettings);
            Controls.Add(btnDump);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnConnect);
            Controls.Add(OpenEmulator);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainWindow";
            Text = "Open3270";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenEmulator OpenEmulator;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

