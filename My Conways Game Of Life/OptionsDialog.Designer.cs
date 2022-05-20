namespace My_Conways_Game_Of_Life
{
    partial class OptionsDialog
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timerIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeInterval = new System.Windows.Forms.Label();
            this.cellWidth = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cellHight = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(133, 244);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(214, 244);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // timerIntervalUpDown
            // 
            this.timerIntervalUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timerIntervalUpDown.Location = new System.Drawing.Point(161, 71);
            this.timerIntervalUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timerIntervalUpDown.Name = "timerIntervalUpDown";
            this.timerIntervalUpDown.Size = new System.Drawing.Size(75, 20);
            this.timerIntervalUpDown.TabIndex = 2;
            // 
            // timeInterval
            // 
            this.timeInterval.AutoSize = true;
            this.timeInterval.Location = new System.Drawing.Point(16, 73);
            this.timeInterval.Name = "timeInterval";
            this.timeInterval.Size = new System.Drawing.Size(139, 13);
            this.timeInterval.TabIndex = 3;
            this.timeInterval.Text = "Time Interval in Milliseconds";
            // 
            // cellWidth
            // 
            this.cellWidth.AutoSize = true;
            this.cellWidth.Location = new System.Drawing.Point(16, 104);
            this.cellWidth.Name = "cellWidth";
            this.cellWidth.Size = new System.Drawing.Size(123, 13);
            this.cellWidth.TabIndex = 4;
            this.cellWidth.Text = "Width of Universe in Cell";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(161, 102);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // cellHight
            // 
            this.cellHight.AutoSize = true;
            this.cellHight.Location = new System.Drawing.Point(16, 134);
            this.cellHight.Name = "cellHight";
            this.cellHight.Size = new System.Drawing.Size(125, 13);
            this.cellHight.TabIndex = 6;
            this.cellHight.Text = "Hight of Universe in Cells";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(161, 132);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(301, 279);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.cellHight);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cellWidth);
            this.Controls.Add(this.timeInterval);
            this.Controls.Add(this.timerIntervalUpDown);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsDialog";
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown timerIntervalUpDown;
        private System.Windows.Forms.Label timeInterval;
        private System.Windows.Forms.Label cellWidth;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label cellHight;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}