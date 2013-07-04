namespace iRacingSdkWrapperExample
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.sessionInfoTextBox = new System.Windows.Forms.TextBox();
            this.telemetryTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sessionInfoLabel = new System.Windows.Forms.Label();
            this.telemetryLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // sessionInfoTextBox
            // 
            this.sessionInfoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.sessionInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionInfoTextBox.Location = new System.Drawing.Point(0, 13);
            this.sessionInfoTextBox.Multiline = true;
            this.sessionInfoTextBox.Name = "sessionInfoTextBox";
            this.sessionInfoTextBox.ReadOnly = true;
            this.sessionInfoTextBox.Size = new System.Drawing.Size(398, 388);
            this.sessionInfoTextBox.TabIndex = 0;
            // 
            // telemetryTextBox
            // 
            this.telemetryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.telemetryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telemetryTextBox.Location = new System.Drawing.Point(0, 13);
            this.telemetryTextBox.Multiline = true;
            this.telemetryTextBox.Name = "telemetryTextBox";
            this.telemetryTextBox.ReadOnly = true;
            this.telemetryTextBox.Size = new System.Drawing.Size(405, 388);
            this.telemetryTextBox.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sessionInfoTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.sessionInfoLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.telemetryTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.telemetryLabel);
            this.splitContainer1.Size = new System.Drawing.Size(807, 401);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 3;
            // 
            // sessionInfoLabel
            // 
            this.sessionInfoLabel.AutoSize = true;
            this.sessionInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.sessionInfoLabel.Name = "sessionInfoLabel";
            this.sessionInfoLabel.Size = new System.Drawing.Size(64, 13);
            this.sessionInfoLabel.TabIndex = 1;
            this.sessionInfoLabel.Text = "Session info";
            // 
            // telemetryLabel
            // 
            this.telemetryLabel.AutoSize = true;
            this.telemetryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.telemetryLabel.Location = new System.Drawing.Point(0, 0);
            this.telemetryLabel.Name = "telemetryLabel";
            this.telemetryLabel.Size = new System.Drawing.Size(53, 13);
            this.telemetryLabel.TabIndex = 3;
            this.telemetryLabel.Text = "Telemetry";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(112, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 454);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox sessionInfoTextBox;
        private System.Windows.Forms.TextBox telemetryTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label sessionInfoLabel;
        private System.Windows.Forms.Label telemetryLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}

