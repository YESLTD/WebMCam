﻿namespace WebMCam
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonToggle = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.checkBoxDrawCursor = new System.Windows.Forms.CheckBox();
            this.numericUpDownFramerate = new System.Windows.Forms.NumericUpDown();
            this.labelFPS = new System.Windows.Forms.Label();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.timerRecord = new System.Windows.Forms.Timer(this.components);
            this.checkBoxCaptureAudio = new System.Windows.Forms.CheckBox();
            this.linkLabelFFmpeg = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFramerate)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToggle
            // 
            this.buttonToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToggle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonToggle.Location = new System.Drawing.Point(302, 99);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(110, 35);
            this.buttonToggle.TabIndex = 0;
            this.buttonToggle.Text = "Record";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // displayBox
            // 
            this.displayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBox.BackColor = System.Drawing.Color.Fuchsia;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBox.Location = new System.Drawing.Point(2, 2);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(298, 243);
            this.displayBox.TabIndex = 1;
            this.displayBox.TabStop = false;
            // 
            // checkBoxDrawCursor
            // 
            this.checkBoxDrawCursor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDrawCursor.AutoSize = true;
            this.checkBoxDrawCursor.Checked = true;
            this.checkBoxDrawCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawCursor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxDrawCursor.Location = new System.Drawing.Point(306, 26);
            this.checkBoxDrawCursor.Name = "checkBoxDrawCursor";
            this.checkBoxDrawCursor.Size = new System.Drawing.Size(90, 18);
            this.checkBoxDrawCursor.TabIndex = 0;
            this.checkBoxDrawCursor.Text = "Draw Cursor";
            this.checkBoxDrawCursor.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFramerate
            // 
            this.numericUpDownFramerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownFramerate.Location = new System.Drawing.Point(333, 73);
            this.numericUpDownFramerate.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFramerate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFramerate.Name = "numericUpDownFramerate";
            this.numericUpDownFramerate.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownFramerate.TabIndex = 0;
            this.numericUpDownFramerate.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labelFPS
            // 
            this.labelFPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFPS.Location = new System.Drawing.Point(303, 73);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(33, 18);
            this.labelFPS.TabIndex = 4;
            this.labelFPS.Text = "FPS:";
            this.labelFPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOptions
            // 
            this.buttonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOptions.Location = new System.Drawing.Point(302, 140);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(110, 35);
            this.buttonOptions.TabIndex = 0;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Checked = true;
            this.checkBoxTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTopMost.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxTopMost.Location = new System.Drawing.Point(306, 3);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(102, 18);
            this.checkBoxTopMost.TabIndex = 0;
            this.checkBoxTopMost.Text = "Always on Top";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // linkGithub
            // 
            this.linkGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGithub.Location = new System.Drawing.Point(302, 222);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(110, 23);
            this.linkGithub.TabIndex = 0;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "v2.0";
            this.linkGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // timerRecord
            // 
            this.timerRecord.Interval = 500;
            this.timerRecord.Tick += new System.EventHandler(this.timerRecord_Tick);
            // 
            // checkBoxCaptureAudio
            // 
            this.checkBoxCaptureAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCaptureAudio.AutoSize = true;
            this.checkBoxCaptureAudio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxCaptureAudio.Location = new System.Drawing.Point(306, 49);
            this.checkBoxCaptureAudio.Name = "checkBoxCaptureAudio";
            this.checkBoxCaptureAudio.Size = new System.Drawing.Size(99, 18);
            this.checkBoxCaptureAudio.TabIndex = 0;
            this.checkBoxCaptureAudio.Text = "Capture Audio";
            this.checkBoxCaptureAudio.UseVisualStyleBackColor = true;
            // 
            // linkLabelFFmpeg
            // 
            this.linkLabelFFmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelFFmpeg.Location = new System.Drawing.Point(302, 199);
            this.linkLabelFFmpeg.Name = "linkLabelFFmpeg";
            this.linkLabelFFmpeg.Size = new System.Drawing.Size(110, 23);
            this.linkLabelFFmpeg.TabIndex = 5;
            this.linkLabelFFmpeg.TabStop = true;
            this.linkLabelFFmpeg.Text = "FFmpeg";
            this.linkLabelFFmpeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelFFmpeg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFFmpeg_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 247);
            this.Controls.Add(this.linkLabelFFmpeg);
            this.Controls.Add(this.checkBoxCaptureAudio);
            this.Controls.Add(this.checkBoxTopMost);
            this.Controls.Add(this.numericUpDownFramerate);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.labelFPS);
            this.Controls.Add(this.checkBoxDrawCursor);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.linkGithub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebMCam 2.0";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Move += new System.EventHandler(this.FormMain_Move);
            this.Resize += new System.EventHandler(this.FormMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFramerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.CheckBox checkBoxDrawCursor;
        private System.Windows.Forms.NumericUpDown numericUpDownFramerate;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Timer timerRecord;
        private System.Windows.Forms.CheckBox checkBoxCaptureAudio;
        private System.Windows.Forms.LinkLabel linkLabelFFmpeg;
    }
}

