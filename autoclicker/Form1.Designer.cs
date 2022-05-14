namespace autoclicker
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSetPoint = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMilliseconds = new System.Windows.Forms.RadioButton();
            this.rbSeconds = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerPoint = new System.Windows.Forms.Timer(this.components);
            this.timerpoint2 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timepoint3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(29, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "شروع / توقف";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnSetPoint
            // 
            this.btnSetPoint.Location = new System.Drawing.Point(29, 74);
            this.btnSetPoint.Name = "btnSetPoint";
            this.btnSetPoint.Size = new System.Drawing.Size(139, 23);
            this.btnSetPoint.TabIndex = 1;
            this.btnSetPoint.Text = "ست کردن نقطه اول";
            this.btnSetPoint.UseVisualStyleBackColor = true;
            this.btnSetPoint.Click += new System.EventHandler(this.btnSetPoint_Click);
            this.btnSetPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(233, 21);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(152, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "فاصله بین هر کلیک";
            // 
            // rbMilliseconds
            // 
            this.rbMilliseconds.AutoSize = true;
            this.rbMilliseconds.Location = new System.Drawing.Point(304, 47);
            this.rbMilliseconds.Name = "rbMilliseconds";
            this.rbMilliseconds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbMilliseconds.Size = new System.Drawing.Size(72, 17);
            this.rbMilliseconds.TabIndex = 4;
            this.rbMilliseconds.Text = "میلی ثانیه";
            this.rbMilliseconds.UseVisualStyleBackColor = true;
            this.rbMilliseconds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // rbSeconds
            // 
            this.rbSeconds.AutoSize = true;
            this.rbSeconds.Checked = true;
            this.rbSeconds.Location = new System.Drawing.Point(235, 49);
            this.rbSeconds.Name = "rbSeconds";
            this.rbSeconds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbSeconds.Size = new System.Drawing.Size(44, 17);
            this.rbSeconds.TabIndex = 5;
            this.rbSeconds.TabStop = true;
            this.rbSeconds.Text = "ثانیه";
            this.rbSeconds.UseVisualStyleBackColor = true;
            this.rbSeconds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerPoint
            // 
            this.timerPoint.Tick += new System.EventHandler(this.timerPoint_Tick);
            // 
            // timerpoint2
            // 
            this.timerpoint2.Tick += new System.EventHandler(this.timerpoint2_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "ست کردن نقطه دوم";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timepoint3
            // 
            this.timepoint3.Tick += new System.EventHandler(this.timepoint3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(477, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "ست کردن نقطه سوم";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 110);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rbSeconds);
            this.Controls.Add(this.rbMilliseconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSetPoint);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "autoclicker";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSetPoint;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMilliseconds;
        private System.Windows.Forms.RadioButton rbSeconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerPoint;
        private System.Windows.Forms.Timer timerpoint2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timepoint3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button button5;
    }
}

