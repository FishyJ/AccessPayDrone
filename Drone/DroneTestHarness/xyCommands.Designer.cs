namespace DroneTestHarness
{
    partial class xyCommands
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.maskedTextBoxX = new System.Windows.Forms.MaskedTextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.maskedTextBoxY = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(102, 84);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(12, 84);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 26);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(50, 13);
            this.labelX.TabIndex = 8;
            this.labelX.Text = "Prompt X";
            // 
            // maskedTextBoxX
            // 
            this.maskedTextBoxX.Location = new System.Drawing.Point(135, 26);
            this.maskedTextBoxX.Mask = "0####";
            this.maskedTextBoxX.Name = "maskedTextBoxX";
            this.maskedTextBoxX.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBoxX.TabIndex = 7;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(12, 55);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(50, 13);
            this.labelY.TabIndex = 10;
            this.labelY.Text = "Prompt Y";
            // 
            // maskedTextBoxY
            // 
            this.maskedTextBoxY.Location = new System.Drawing.Point(135, 55);
            this.maskedTextBoxY.Mask = "0####";
            this.maskedTextBoxY.Name = "maskedTextBoxY";
            this.maskedTextBoxY.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBoxY.TabIndex = 9;
            // 
            // xyCommands
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(187, 121);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.maskedTextBoxY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.maskedTextBoxX);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xyCommands";
            this.Text = "xyCommands";
            this.Load += new System.EventHandler(this.xyCommands_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxY;
    }
}