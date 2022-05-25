namespace My_Conways_Game_Of_Life
{
    partial class Options
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
            this.Ok_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.TimerChangeUpDownBox = new System.Windows.Forms.NumericUpDown();
            this.UniverseWidthChangeUpDown = new System.Windows.Forms.NumericUpDown();
            this.UniverseHeightChangeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimerChangeUpDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniverseWidthChangeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniverseHeightChangeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_button
            // 
            this.Ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok_button.Location = new System.Drawing.Point(59, 149);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(75, 23);
            this.Ok_button.TabIndex = 0;
            this.Ok_button.Text = "OK";
            this.Ok_button.UseVisualStyleBackColor = true;
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Location = new System.Drawing.Point(140, 149);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 1;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // TimerChangeUpDownBox
            // 
            this.TimerChangeUpDownBox.Location = new System.Drawing.Point(180, 46);
            this.TimerChangeUpDownBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimerChangeUpDownBox.Name = "TimerChangeUpDownBox";
            this.TimerChangeUpDownBox.Size = new System.Drawing.Size(75, 20);
            this.TimerChangeUpDownBox.TabIndex = 2;
            this.TimerChangeUpDownBox.ValueChanged += new System.EventHandler(this.TimerChangeUpDownBox_ValueChanged);
            // 
            // UniverseWidthChangeUpDown
            // 
            this.UniverseWidthChangeUpDown.Location = new System.Drawing.Point(180, 72);
            this.UniverseWidthChangeUpDown.Name = "UniverseWidthChangeUpDown";
            this.UniverseWidthChangeUpDown.Size = new System.Drawing.Size(75, 20);
            this.UniverseWidthChangeUpDown.TabIndex = 3;
            this.UniverseWidthChangeUpDown.ValueChanged += new System.EventHandler(this.UniverseWidthChangeUpDown_ValueChanged);
            // 
            // UniverseHeightChangeUpDown
            // 
            this.UniverseHeightChangeUpDown.Location = new System.Drawing.Point(180, 98);
            this.UniverseHeightChangeUpDown.Name = "UniverseHeightChangeUpDown";
            this.UniverseHeightChangeUpDown.Size = new System.Drawing.Size(75, 20);
            this.UniverseHeightChangeUpDown.TabIndex = 4;
            this.UniverseHeightChangeUpDown.ValueChanged += new System.EventHandler(this.UniverseHeightChangeUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer Interval in Milliseconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Width of Universe in Cells";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height of Universe in Cells";
            // 
            // Options
            // 
            this.AcceptButton = this.Ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(278, 190);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UniverseHeightChangeUpDown);
            this.Controls.Add(this.UniverseWidthChangeUpDown);
            this.Controls.Add(this.TimerChangeUpDownBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Ok_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TimerChangeUpDownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniverseWidthChangeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniverseHeightChangeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.NumericUpDown TimerChangeUpDownBox;
        private System.Windows.Forms.NumericUpDown UniverseWidthChangeUpDown;
        private System.Windows.Forms.NumericUpDown UniverseHeightChangeUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}