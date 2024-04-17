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
            btnClear.Location = new System.Drawing.Point(1055, 129);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(134, 38);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(1055, 204);
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
            btnDump.Location = new System.Drawing.Point(1055, 266);
            btnDump.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDump.Name = "btnDump";
            btnDump.Size = new System.Drawing.Size(134, 38);
            btnDump.TabIndex = 4;
            btnDump.Text = "Dump";
            btnDump.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Location = new System.Drawing.Point(1055, 319);
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
            OpenEmulator.MaxLength = 2000;
            OpenEmulator.Name = "OpenEmulator";
            OpenEmulator.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            OpenEmulator.Size = new System.Drawing.Size(1009, 677);
            OpenEmulator.TabIndex = 0;
            OpenEmulator.Text = "";
            OpenEmulator.KeyUp += OpenEmulator_KeyUp;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1202, 713);
            Controls.Add(btnSettings);
            Controls.Add(btnDump);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnConnect);
            Controls.Add(OpenEmulator);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainWindow";
            Text = "Open3270";
            ResumeLayout(false);
        }

        #endregion

        private OpenEmulator OpenEmulator;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Button btnSettings;
    }
}

