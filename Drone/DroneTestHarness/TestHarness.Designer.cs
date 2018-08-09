namespace DroneTestHarness
{
    partial class TestHarness
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
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonSendFromList = new System.Windows.Forms.Button();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.groupBoxDroneStatus = new System.Windows.Forms.GroupBox();
            this.textBoxCommandList = new System.Windows.Forms.TextBox();
            this.buttonSendText = new System.Windows.Forms.Button();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonInitialPosition = new System.Windows.Forms.Button();
            this.buttonBoundary = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAlert = new System.Windows.Forms.Button();
            this.buttonToggleLights = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(180, 376);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(114, 47);
            this.buttonClearList.TabIndex = 0;
            this.buttonClearList.Text = "Clear Commands";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // buttonSendFromList
            // 
            this.buttonSendFromList.Location = new System.Drawing.Point(301, 376);
            this.buttonSendFromList.Name = "buttonSendFromList";
            this.buttonSendFromList.Size = new System.Drawing.Size(114, 47);
            this.buttonSendFromList.TabIndex = 1;
            this.buttonSendFromList.Text = "Send Command To Drone";
            this.buttonSendFromList.UseVisualStyleBackColor = true;
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.Location = new System.Drawing.Point(180, 2);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCommands.Size = new System.Drawing.Size(235, 368);
            this.listBoxCommands.TabIndex = 2;
            // 
            // groupBoxDroneStatus
            // 
            this.groupBoxDroneStatus.Location = new System.Drawing.Point(421, 2);
            this.groupBoxDroneStatus.Name = "groupBoxDroneStatus";
            this.groupBoxDroneStatus.Size = new System.Drawing.Size(174, 368);
            this.groupBoxDroneStatus.TabIndex = 3;
            this.groupBoxDroneStatus.TabStop = false;
            this.groupBoxDroneStatus.Text = "Drone Status";
            // 
            // textBoxCommandList
            // 
            this.textBoxCommandList.Location = new System.Drawing.Point(601, 2);
            this.textBoxCommandList.Multiline = true;
            this.textBoxCommandList.Name = "textBoxCommandList";
            this.textBoxCommandList.Size = new System.Drawing.Size(235, 368);
            this.textBoxCommandList.TabIndex = 5;
            // 
            // buttonSendText
            // 
            this.buttonSendText.Location = new System.Drawing.Point(722, 376);
            this.buttonSendText.Name = "buttonSendText";
            this.buttonSendText.Size = new System.Drawing.Size(114, 47);
            this.buttonSendText.TabIndex = 7;
            this.buttonSendText.Text = "Send Command To Drone";
            this.buttonSendText.UseVisualStyleBackColor = true;
            this.buttonSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // buttonClearText
            // 
            this.buttonClearText.Location = new System.Drawing.Point(601, 376);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(114, 47);
            this.buttonClearText.TabIndex = 6;
            this.buttonClearText.Text = "Clear Commands";
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonShutdown);
            this.groupBox1.Controls.Add(this.buttonRestart);
            this.groupBox1.Controls.Add(this.buttonInitialPosition);
            this.groupBox1.Controls.Add(this.buttonBoundary);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management commands";
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Location = new System.Drawing.Point(6, 135);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(117, 23);
            this.buttonShutdown.TabIndex = 17;
            this.buttonShutdown.Text = "Shutdown (D)";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(6, 106);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(117, 23);
            this.buttonRestart.TabIndex = 16;
            this.buttonRestart.Text = "Restart (R)";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonInitialPosition
            // 
            this.buttonInitialPosition.Location = new System.Drawing.Point(6, 77);
            this.buttonInitialPosition.Name = "buttonInitialPosition";
            this.buttonInitialPosition.Size = new System.Drawing.Size(117, 23);
            this.buttonInitialPosition.TabIndex = 15;
            this.buttonInitialPosition.Text = "Initial Position (Px,y)";
            this.buttonInitialPosition.UseVisualStyleBackColor = true;
            this.buttonInitialPosition.Click += new System.EventHandler(this.buttonInitialPosition_Click);
            // 
            // buttonBoundary
            // 
            this.buttonBoundary.Location = new System.Drawing.Point(6, 48);
            this.buttonBoundary.Name = "buttonBoundary";
            this.buttonBoundary.Size = new System.Drawing.Size(117, 23);
            this.buttonBoundary.TabIndex = 14;
            this.buttonBoundary.Text = "Boundary (Bx,y)";
            this.buttonBoundary.UseVisualStyleBackColor = true;
            this.buttonBoundary.Click += new System.EventHandler(this.buttonBoundary_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(117, 23);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start (S)";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMove);
            this.groupBox2.Controls.Add(this.buttonHome);
            this.groupBox2.Controls.Add(this.buttonAlert);
            this.groupBox2.Controls.Add(this.buttonToggleLights);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action commands";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(6, 106);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(117, 23);
            this.buttonMove.TabIndex = 20;
            this.buttonMove.Text = "Move (Mt,d)";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(6, 77);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(117, 23);
            this.buttonHome.TabIndex = 19;
            this.buttonHome.Text = "Home (H)";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonAlert
            // 
            this.buttonAlert.Location = new System.Drawing.Point(6, 48);
            this.buttonAlert.Name = "buttonAlert";
            this.buttonAlert.Size = new System.Drawing.Size(117, 23);
            this.buttonAlert.TabIndex = 18;
            this.buttonAlert.Text = "Alert (horn) (At)";
            this.buttonAlert.UseVisualStyleBackColor = true;
            this.buttonAlert.Click += new System.EventHandler(this.buttonAlert_Click);
            // 
            // buttonToggleLights
            // 
            this.buttonToggleLights.Location = new System.Drawing.Point(6, 19);
            this.buttonToggleLights.Name = "buttonToggleLights";
            this.buttonToggleLights.Size = new System.Drawing.Size(117, 23);
            this.buttonToggleLights.TabIndex = 17;
            this.buttonToggleLights.Text = "Toggle Lights (T)";
            this.buttonToggleLights.UseVisualStyleBackColor = true;
            this.buttonToggleLights.Click += new System.EventHandler(this.buttonToggleLights_Click);
            // 
            // TestHarness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSendText);
            this.Controls.Add(this.buttonClearText);
            this.Controls.Add(this.textBoxCommandList);
            this.Controls.Add(this.groupBoxDroneStatus);
            this.Controls.Add(this.listBoxCommands);
            this.Controls.Add(this.buttonSendFromList);
            this.Controls.Add(this.buttonClearList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestHarness";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Drone Test Harness";
            this.Load += new System.EventHandler(this.TestHarness_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonSendFromList;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.GroupBox groupBoxDroneStatus;
        private System.Windows.Forms.TextBox textBoxCommandList;
        private System.Windows.Forms.Button buttonSendText;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonInitialPosition;
        private System.Windows.Forms.Button buttonBoundary;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonAlert;
        private System.Windows.Forms.Button buttonToggleLights;
    }
}

