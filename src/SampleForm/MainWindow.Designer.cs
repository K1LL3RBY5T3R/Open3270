using System.Windows.Forms;

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
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(1206, 31);
            btnConnect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(153, 51);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(1206, 265);
            btnClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(153, 51);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(1206, 148);
            btnRefresh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(153, 51);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDump
            // 
            btnDump.Location = new System.Drawing.Point(1206, 324);
            btnDump.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnDump.Name = "btnDump";
            btnDump.Size = new System.Drawing.Size(153, 51);
            btnDump.TabIndex = 4;
            btnDump.Text = "Dump";
            btnDump.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Location = new System.Drawing.Point(1206, 207);
            btnSettings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(153, 51);
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
            OpenEmulator.Location = new System.Drawing.Point(16, 19);
            OpenEmulator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            OpenEmulator.MaxLength = 2000;
            OpenEmulator.Name = "OpenEmulator";
            OpenEmulator.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            OpenEmulator.Size = new System.Drawing.Size(1153, 901);
            OpenEmulator.TabIndex = 0;
            OpenEmulator.Text = "";
            OpenEmulator.TextChanged += OpenEmulator_TextChanged;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new System.Drawing.Point(1206, 89);
            btnDisconnect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(153, 51);
            btnDisconnect.TabIndex = 6;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new System.Drawing.Point(0, 927);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1374, 24);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            toolStripStatusLabel1.Text = "Cursor Positions";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1374, 951);
            Controls.Add(statusStrip1);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSettings);
            Controls.Add(btnDump);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnConnect);
            Controls.Add(OpenEmulator);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "MainWindow";
            Text = "Open3270";
            Load += MainWindow_Load;
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
    }
}

