

namespace DistortionAnalyser
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
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_sinBufSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSinAmp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSinPhase = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDiffMult = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSinVert = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scope1 = new DistortionAnalyser.Screen();
            this.differientiator = new DistortionAnalyser.Screen();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sinBufSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinAmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinPhase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiffMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinVert)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Launch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(12, 124);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vertical Multiplier:";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(0, 429);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1030, 22);
            this.hScrollBar1.TabIndex = 17;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(148, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.scope1);
            this.splitContainer1.Panel1.Controls.Add(this.hScrollBar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.differientiator);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 616);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Buffer Size (Frequency):";
            // 
            // nud_sinBufSize
            // 
            this.nud_sinBufSize.Location = new System.Drawing.Point(5, 32);
            this.nud_sinBufSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_sinBufSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_sinBufSize.Name = "nud_sinBufSize";
            this.nud_sinBufSize.Size = new System.Drawing.Size(90, 20);
            this.nud_sinBufSize.TabIndex = 19;
            this.nud_sinBufSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_sinBufSize.ValueChanged += new System.EventHandler(this.nud_sinBufSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Amplitude:";
            // 
            // nudSinAmp
            // 
            this.nudSinAmp.DecimalPlaces = 3;
            this.nudSinAmp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSinAmp.Location = new System.Drawing.Point(5, 73);
            this.nudSinAmp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSinAmp.Name = "nudSinAmp";
            this.nudSinAmp.Size = new System.Drawing.Size(90, 20);
            this.nudSinAmp.TabIndex = 21;
            this.nudSinAmp.ThousandsSeparator = true;
            this.nudSinAmp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSinAmp.ValueChanged += new System.EventHandler(this.nudSinAmp_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phase:";
            // 
            // nudSinPhase
            // 
            this.nudSinPhase.Location = new System.Drawing.Point(5, 112);
            this.nudSinPhase.Name = "nudSinPhase";
            this.nudSinPhase.Size = new System.Drawing.Size(90, 20);
            this.nudSinPhase.TabIndex = 23;
            this.nudSinPhase.ThousandsSeparator = true;
            this.nudSinPhase.ValueChanged += new System.EventHandler(this.nudSinPhase_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Differential Multiplier:";
            // 
            // nudDiffMult
            // 
            this.nudDiffMult.DecimalPlaces = 1;
            this.nudDiffMult.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDiffMult.Location = new System.Drawing.Point(12, 409);
            this.nudDiffMult.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDiffMult.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.nudDiffMult.Name = "nudDiffMult";
            this.nudDiffMult.Size = new System.Drawing.Size(90, 20);
            this.nudDiffMult.TabIndex = 25;
            this.nudDiffMult.ThousandsSeparator = true;
            this.nudDiffMult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiffMult.ValueChanged += new System.EventHandler(this.nudDiffMult_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Offset:";
            // 
            // nudSinVert
            // 
            this.nudSinVert.DecimalPlaces = 3;
            this.nudSinVert.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSinVert.Location = new System.Drawing.Point(5, 151);
            this.nudSinVert.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSinVert.Name = "nudSinVert";
            this.nudSinVert.Size = new System.Drawing.Size(90, 20);
            this.nudSinVert.TabIndex = 27;
            this.nudSinVert.ThousandsSeparator = true;
            this.nudSinVert.ValueChanged += new System.EventHandler(this.nudSinVert_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nud_sinBufSize);
            this.groupBox1.Controls.Add(this.nudSinVert);
            this.groupBox1.Controls.Add(this.nudSinAmp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudSinPhase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 185);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sine Wave";
            // 
            // scope1
            // 
            this.scope1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scope1.BackColor = System.Drawing.Color.Black;
            this.scope1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scope1.ForeColor = System.Drawing.SystemColors.Control;
            this.scope1.FPS = 24;
            this.scope1.Location = new System.Drawing.Point(0, 0);
            this.scope1.ModelDrawer = null;
            this.scope1.Name = "scope1";
            this.scope1.Size = new System.Drawing.Size(1027, 428);
            this.scope1.TabIndex = 14;
            // 
            // differientiator
            // 
            this.differientiator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.differientiator.BackColor = System.Drawing.Color.Black;
            this.differientiator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.differientiator.ForeColor = System.Drawing.SystemColors.Control;
            this.differientiator.FPS = 12;
            this.differientiator.Location = new System.Drawing.Point(3, 3);
            this.differientiator.ModelDrawer = null;
            this.differientiator.Name = "differientiator";
            this.differientiator.Size = new System.Drawing.Size(1024, 152);
            this.differientiator.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDiffMult);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Distortion Analyser";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_sinBufSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinAmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinPhase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiffMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinVert)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private Screen scope1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Screen differientiator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_sinBufSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSinAmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSinPhase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDiffMult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSinVert;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

