﻿namespace R6S_Chat_Spammer
{
    partial class Spammer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spammer));
            this.spamBox = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.HyperLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Wait = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IntervalCounter = new System.Windows.Forms.NumericUpDown();
            this.SetInitial = new System.Windows.Forms.TextBox();
            this.SetFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // spamBox
            // 
            this.spamBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.spamBox, "spamBox");
            this.spamBox.Name = "spamBox";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // HyperLink
            // 
            resources.ApplyResources(this.HyperLink, "HyperLink");
            this.HyperLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HyperLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HyperLink.Name = "HyperLink";
            this.HyperLink.TabStop = true;
            this.HyperLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HyperLink_LinkClicked);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Name = "label3";
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.BackColor = System.Drawing.Color.White;
            this.Status.Name = "Status";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Name = "label5";
            // 
            // Wait
            // 
            this.Wait.Interval = 20;
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Name = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Name = "label6";
            // 
            // IntervalCounter
            // 
            this.IntervalCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IntervalCounter.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            resources.ApplyResources(this.IntervalCounter, "IntervalCounter");
            this.IntervalCounter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IntervalCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalCounter.Name = "IntervalCounter";
            this.IntervalCounter.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.IntervalCounter.ValueChanged += new System.EventHandler(this.IntervalCounter_ValueChanged);
            // 
            // SetInitial
            // 
            resources.ApplyResources(this.SetInitial, "SetInitial");
            this.SetInitial.Name = "SetInitial";
            this.SetInitial.TextChanged += new System.EventHandler(this.SetInitial_TextChanged);
            // 
            // SetFinal
            // 
            resources.ApplyResources(this.SetFinal, "SetFinal");
            this.SetFinal.Name = "SetFinal";
            this.SetFinal.TextChanged += new System.EventHandler(this.SetFinal_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Name = "label9";
            // 
            // Spammer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SetFinal);
            this.Controls.Add(this.SetInitial);
            this.Controls.Add(this.IntervalCounter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HyperLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spamBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Spammer";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpamCity_FormClosed);
            this.Load += new System.EventHandler(this.SpamCity_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Spammer_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.IntervalCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox spamBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel HyperLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Wait;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown IntervalCounter;
        private System.Windows.Forms.TextBox SetInitial;
        private System.Windows.Forms.TextBox SetFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

