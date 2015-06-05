namespace filter_tester
{
    partial class LpfCoefTester
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
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.numericUpDown_interval = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_coef = new System.Windows.Forms.NumericUpDown();
            this.label_interval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.radioButton_stepUp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_stepDown = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_stopThresh = new System.Windows.Forms.NumericUpDown();
            this.label_duration = new System.Windows.Forms.Label();
            this.checkBox_clipboard = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_coef)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopThresh)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.Location = new System.Drawing.Point(139, 28);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(158, 206);
            this.textBox_output.TabIndex = 1;
            // 
            // numericUpDown_interval
            // 
            this.numericUpDown_interval.Location = new System.Drawing.Point(12, 56);
            this.numericUpDown_interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_interval.Name = "numericUpDown_interval";
            this.numericUpDown_interval.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_interval.TabIndex = 2;
            this.numericUpDown_interval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_interval.ValueChanged += new System.EventHandler(this.numericUpDown_interval_ValueChanged);
            // 
            // numericUpDown_coef
            // 
            this.numericUpDown_coef.DecimalPlaces = 3;
            this.numericUpDown_coef.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_coef.Location = new System.Drawing.Point(12, 82);
            this.numericUpDown_coef.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            196608});
            this.numericUpDown_coef.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_coef.Name = "numericUpDown_coef";
            this.numericUpDown_coef.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_coef.TabIndex = 3;
            this.numericUpDown_coef.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_coef.ValueChanged += new System.EventHandler(this.numericUpDown_coef1_ValueChanged);
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.Location = new System.Drawing.Point(69, 58);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(64, 13);
            this.label_interval.TabIndex = 5;
            this.label_interval.Text = "Interval (ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "LPF Coef";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(12, 9);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(36, 13);
            this.label_output.TabIndex = 9;
            this.label_output.Text = "Ouput";
            // 
            // radioButton_stepUp
            // 
            this.radioButton_stepUp.AutoSize = true;
            this.radioButton_stepUp.Checked = true;
            this.radioButton_stepUp.Location = new System.Drawing.Point(6, 19);
            this.radioButton_stepUp.Name = "radioButton_stepUp";
            this.radioButton_stepUp.Size = new System.Drawing.Size(65, 17);
            this.radioButton_stepUp.TabIndex = 10;
            this.radioButton_stepUp.TabStop = true;
            this.radioButton_stepUp.Text = "Step UP";
            this.radioButton_stepUp.UseVisualStyleBackColor = true;
            this.radioButton_stepUp.CheckedChanged += new System.EventHandler(this.radioButton_stepUp_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_stepDown);
            this.groupBox1.Controls.Add(this.radioButton_stepUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 76);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step Input Direction";
            // 
            // radioButton_stepDown
            // 
            this.radioButton_stepDown.AutoSize = true;
            this.radioButton_stepDown.Location = new System.Drawing.Point(6, 42);
            this.radioButton_stepDown.Name = "radioButton_stepDown";
            this.radioButton_stepDown.Size = new System.Drawing.Size(85, 17);
            this.radioButton_stepDown.TabIndex = 11;
            this.radioButton_stepDown.Text = "Step DOWN";
            this.radioButton_stepDown.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "% to Stop at";
            // 
            // numericUpDown_stopThresh
            // 
            this.numericUpDown_stopThresh.DecimalPlaces = 2;
            this.numericUpDown_stopThresh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_stopThresh.Location = new System.Drawing.Point(12, 108);
            this.numericUpDown_stopThresh.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.numericUpDown_stopThresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_stopThresh.Name = "numericUpDown_stopThresh";
            this.numericUpDown_stopThresh.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_stopThresh.TabIndex = 12;
            this.numericUpDown_stopThresh.Value = new decimal(new int[] {
            90,
            0,
            0,
            131072});
            this.numericUpDown_stopThresh.ValueChanged += new System.EventHandler(this.numericUpDown_stopThresh_ValueChanged);
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.Location = new System.Drawing.Point(12, 28);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(59, 13);
            this.label_duration.TabIndex = 14;
            this.label_duration.Text = "Duration = ";
            // 
            // checkBox_clipboard
            // 
            this.checkBox_clipboard.AutoSize = true;
            this.checkBox_clipboard.Location = new System.Drawing.Point(15, 218);
            this.checkBox_clipboard.Name = "checkBox_clipboard";
            this.checkBox_clipboard.Size = new System.Drawing.Size(108, 17);
            this.checkBox_clipboard.TabIndex = 15;
            this.checkBox_clipboard.Text = "Copy to clipboard";
            this.checkBox_clipboard.UseVisualStyleBackColor = true;
            this.checkBox_clipboard.CheckedChanged += new System.EventHandler(this.checkBox_clipboard_CheckedChanged);
            // 
            // LpfCoefTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 244);
            this.Controls.Add(this.checkBox_clipboard);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_stopThresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_interval);
            this.Controls.Add(this.numericUpDown_coef);
            this.Controls.Add(this.numericUpDown_interval);
            this.Controls.Add(this.textBox_output);
            this.Name = "LpfCoefTester";
            this.Text = "LPF Coef Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_coef)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopThresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.NumericUpDown numericUpDown_interval;
        private System.Windows.Forms.NumericUpDown numericUpDown_coef;
        private System.Windows.Forms.Label label_interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.RadioButton radioButton_stepUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_stepDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_stopThresh;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.CheckBox checkBox_clipboard;
    }
}

