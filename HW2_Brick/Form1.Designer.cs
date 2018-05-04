namespace HW2_Brick
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r3_fast = new System.Windows.Forms.RadioButton();
            this.r2_normal = new System.Windows.Forms.RadioButton();
            this.r1_slow = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.r6_hard = new System.Windows.Forms.RadioButton();
            this.r5_soso = new System.Windows.Forms.RadioButton();
            this.r4_simple = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.r9_high = new System.Windows.Forms.RadioButton();
            this.r8_middle = new System.Windows.Forms.RadioButton();
            this.r7_low = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.r13_D = new System.Windows.Forms.RadioButton();
            this.r12_C = new System.Windows.Forms.RadioButton();
            this.r11_B = new System.Windows.Forms.RadioButton();
            this.r10_A = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(177, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(166, 300);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(40, 40);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r3_fast);
            this.groupBox1.Controls.Add(this.r2_normal);
            this.groupBox1.Controls.Add(this.r1_slow);
            this.groupBox1.Location = new System.Drawing.Point(12, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // r3_fast
            // 
            this.r3_fast.AutoSize = true;
            this.r3_fast.Location = new System.Drawing.Point(155, 34);
            this.r3_fast.Name = "r3_fast";
            this.r3_fast.Size = new System.Drawing.Size(39, 16);
            this.r3_fast.TabIndex = 2;
            this.r3_fast.Text = "fast";
            this.r3_fast.UseVisualStyleBackColor = true;
            this.r3_fast.CheckedChanged += new System.EventHandler(this.r3_fast_CheckedChanged);
            // 
            // r2_normal
            // 
            this.r2_normal.AutoSize = true;
            this.r2_normal.Checked = true;
            this.r2_normal.Location = new System.Drawing.Point(70, 34);
            this.r2_normal.Name = "r2_normal";
            this.r2_normal.Size = new System.Drawing.Size(56, 16);
            this.r2_normal.TabIndex = 1;
            this.r2_normal.TabStop = true;
            this.r2_normal.Text = "normal";
            this.r2_normal.UseVisualStyleBackColor = true;
            this.r2_normal.CheckedChanged += new System.EventHandler(this.r2_normal_CheckedChanged);
            // 
            // r1_slow
            // 
            this.r1_slow.AutoSize = true;
            this.r1_slow.Location = new System.Drawing.Point(6, 34);
            this.r1_slow.Name = "r1_slow";
            this.r1_slow.Size = new System.Drawing.Size(44, 16);
            this.r1_slow.TabIndex = 0;
            this.r1_slow.Text = "slow";
            this.r1_slow.UseVisualStyleBackColor = true;
            this.r1_slow.CheckedChanged += new System.EventHandler(this.r1_slow_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.r6_hard);
            this.groupBox2.Controls.Add(this.r5_soso);
            this.groupBox2.Controls.Add(this.r4_simple);
            this.groupBox2.Location = new System.Drawing.Point(12, 532);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Difficulty";
            // 
            // r6_hard
            // 
            this.r6_hard.AutoSize = true;
            this.r6_hard.Location = new System.Drawing.Point(155, 34);
            this.r6_hard.Name = "r6_hard";
            this.r6_hard.Size = new System.Drawing.Size(44, 16);
            this.r6_hard.TabIndex = 2;
            this.r6_hard.TabStop = true;
            this.r6_hard.Text = "hard";
            this.r6_hard.UseVisualStyleBackColor = true;
            this.r6_hard.CheckedChanged += new System.EventHandler(this.r6_hard_CheckedChanged);
            // 
            // r5_soso
            // 
            this.r5_soso.AutoSize = true;
            this.r5_soso.Location = new System.Drawing.Point(83, 34);
            this.r5_soso.Name = "r5_soso";
            this.r5_soso.Size = new System.Drawing.Size(43, 16);
            this.r5_soso.TabIndex = 1;
            this.r5_soso.TabStop = true;
            this.r5_soso.Text = "soso";
            this.r5_soso.UseVisualStyleBackColor = true;
            this.r5_soso.CheckedChanged += new System.EventHandler(this.r5_soso_CheckedChanged);
            // 
            // r4_simple
            // 
            this.r4_simple.AutoSize = true;
            this.r4_simple.Checked = true;
            this.r4_simple.Location = new System.Drawing.Point(6, 34);
            this.r4_simple.Name = "r4_simple";
            this.r4_simple.Size = new System.Drawing.Size(53, 16);
            this.r4_simple.TabIndex = 0;
            this.r4_simple.TabStop = true;
            this.r4_simple.Text = "simple";
            this.r4_simple.UseVisualStyleBackColor = true;
            this.r4_simple.CheckedChanged += new System.EventHandler(this.r4_simple_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.r9_high);
            this.groupBox3.Controls.Add(this.r8_middle);
            this.groupBox3.Controls.Add(this.r7_low);
            this.groupBox3.Location = new System.Drawing.Point(260, 532);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 67);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Level";
            // 
            // r9_high
            // 
            this.r9_high.AutoSize = true;
            this.r9_high.Location = new System.Drawing.Point(150, 34);
            this.r9_high.Name = "r9_high";
            this.r9_high.Size = new System.Drawing.Size(44, 16);
            this.r9_high.TabIndex = 2;
            this.r9_high.Text = "high";
            this.r9_high.UseVisualStyleBackColor = true;
            this.r9_high.CheckedChanged += new System.EventHandler(this.r9_high_CheckedChanged);
            // 
            // r8_middle
            // 
            this.r8_middle.AutoSize = true;
            this.r8_middle.Location = new System.Drawing.Point(71, 34);
            this.r8_middle.Name = "r8_middle";
            this.r8_middle.Size = new System.Drawing.Size(55, 16);
            this.r8_middle.TabIndex = 1;
            this.r8_middle.Text = "middle";
            this.r8_middle.UseVisualStyleBackColor = true;
            this.r8_middle.CheckedChanged += new System.EventHandler(this.r8_middle_CheckedChanged);
            // 
            // r7_low
            // 
            this.r7_low.AutoSize = true;
            this.r7_low.Checked = true;
            this.r7_low.Location = new System.Drawing.Point(6, 34);
            this.r7_low.Name = "r7_low";
            this.r7_low.Size = new System.Drawing.Size(40, 16);
            this.r7_low.TabIndex = 0;
            this.r7_low.TabStop = true;
            this.r7_low.Text = "low";
            this.r7_low.UseVisualStyleBackColor = true;
            this.r7_low.CheckedChanged += new System.EventHandler(this.r7_low_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.r13_D);
            this.groupBox4.Controls.Add(this.r12_C);
            this.groupBox4.Controls.Add(this.r11_B);
            this.groupBox4.Controls.Add(this.r10_A);
            this.groupBox4.Location = new System.Drawing.Point(12, 619);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 70);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ball\'s Style";
            // 
            // r13_D
            // 
            this.r13_D.AutoSize = true;
            this.r13_D.Location = new System.Drawing.Point(165, 32);
            this.r13_D.Name = "r13_D";
            this.r13_D.Size = new System.Drawing.Size(31, 16);
            this.r13_D.TabIndex = 3;
            this.r13_D.TabStop = true;
            this.r13_D.Text = "D";
            this.r13_D.UseVisualStyleBackColor = true;
            this.r13_D.CheckedChanged += new System.EventHandler(this.r13_D_CheckedChanged);
            // 
            // r12_C
            // 
            this.r12_C.AutoSize = true;
            this.r12_C.Location = new System.Drawing.Point(109, 32);
            this.r12_C.Name = "r12_C";
            this.r12_C.Size = new System.Drawing.Size(31, 16);
            this.r12_C.TabIndex = 2;
            this.r12_C.TabStop = true;
            this.r12_C.Text = "C";
            this.r12_C.UseVisualStyleBackColor = true;
            this.r12_C.CheckedChanged += new System.EventHandler(this.r12_C_CheckedChanged);
            // 
            // r11_B
            // 
            this.r11_B.AutoSize = true;
            this.r11_B.Location = new System.Drawing.Point(58, 32);
            this.r11_B.Name = "r11_B";
            this.r11_B.Size = new System.Drawing.Size(31, 16);
            this.r11_B.TabIndex = 1;
            this.r11_B.TabStop = true;
            this.r11_B.Text = "B";
            this.r11_B.UseVisualStyleBackColor = true;
            this.r11_B.CheckedChanged += new System.EventHandler(this.r11_B_CheckedChanged);
            // 
            // r10_A
            // 
            this.r10_A.AutoSize = true;
            this.r10_A.Checked = true;
            this.r10_A.Location = new System.Drawing.Point(6, 32);
            this.r10_A.Name = "r10_A";
            this.r10_A.Size = new System.Drawing.Size(31, 16);
            this.r10_A.TabIndex = 0;
            this.r10_A.TabStop = true;
            this.r10_A.Text = "A";
            this.r10_A.UseVisualStyleBackColor = true;
            this.r10_A.CheckedChanged += new System.EventHandler(this.r10_A_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 711);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Destroy the Bricks!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton r3_fast;
        private System.Windows.Forms.RadioButton r2_normal;
        private System.Windows.Forms.RadioButton r1_slow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton r9_high;
        private System.Windows.Forms.RadioButton r8_middle;
        private System.Windows.Forms.RadioButton r7_low;
        private System.Windows.Forms.RadioButton r6_hard;
        private System.Windows.Forms.RadioButton r5_soso;
        private System.Windows.Forms.RadioButton r4_simple;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton r13_D;
        private System.Windows.Forms.RadioButton r12_C;
        private System.Windows.Forms.RadioButton r11_B;
        private System.Windows.Forms.RadioButton r10_A;
    }
}

