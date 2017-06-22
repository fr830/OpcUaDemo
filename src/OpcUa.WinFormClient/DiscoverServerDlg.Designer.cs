﻿namespace TongFang.OpcUa.Client
{
    partial class DiscoverServerDlg
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
            this.CancelBTN = new System.Windows.Forms.Button();
            this.OkBTN = new System.Windows.Forms.Button();
            this.ValueLB = new System.Windows.Forms.Label();
            this.ValueTB = new System.Windows.Forms.TextBox();
            this.ServersLB = new System.Windows.Forms.ListBox();
            this.FindBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelBTN
            // 
            this.CancelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Location = new System.Drawing.Point(313, 173);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 0;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // OkBTN
            // 
            this.OkBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkBTN.Location = new System.Drawing.Point(4, 173);
            this.OkBTN.Name = "OkBTN";
            this.OkBTN.Size = new System.Drawing.Size(75, 23);
            this.OkBTN.TabIndex = 1;
            this.OkBTN.Text = "OK";
            this.OkBTN.UseVisualStyleBackColor = true;
            this.OkBTN.Click += new System.EventHandler(this.OkBTN_Click);
            // 
            // ValueLB
            // 
            this.ValueLB.AutoSize = true;
            this.ValueLB.Location = new System.Drawing.Point(1, 9);
            this.ValueLB.Name = "ValueLB";
            this.ValueLB.Size = new System.Drawing.Size(29, 13);
            this.ValueLB.TabIndex = 2;
            this.ValueLB.Text = "Host";
            // 
            // ValueTB
            // 
            this.ValueTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTB.Location = new System.Drawing.Point(36, 6);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(306, 20);
            this.ValueTB.TabIndex = 3;
            this.ValueTB.TextChanged += new System.EventHandler(this.ValueTB_TextChanged);
            // 
            // ServersLB
            // 
            this.ServersLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServersLB.FormattingEnabled = true;
            this.ServersLB.Location = new System.Drawing.Point(4, 32);
            this.ServersLB.Name = "ServersLB";
            this.ServersLB.Size = new System.Drawing.Size(384, 134);
            this.ServersLB.TabIndex = 5;
            this.ServersLB.SelectedIndexChanged += new System.EventHandler(this.ServersLB_SelectedIndexChanged);
            // 
            // FindBTN
            // 
            this.FindBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FindBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindBTN.Location = new System.Drawing.Point(345, 4);
            this.FindBTN.Margin = new System.Windows.Forms.Padding(0);
            this.FindBTN.Name = "FindBTN";
            this.FindBTN.Size = new System.Drawing.Size(43, 23);
            this.FindBTN.TabIndex = 4;
            this.FindBTN.Text = "Find";
            this.FindBTN.UseVisualStyleBackColor = true;
            this.FindBTN.Click += new System.EventHandler(this.FindBTN_Click);
            // 
            // DiscoverServerDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 198);
            this.Controls.Add(this.FindBTN);
            this.Controls.Add(this.ServersLB);
            this.Controls.Add(this.ValueTB);
            this.Controls.Add(this.ValueLB);
            this.Controls.Add(this.OkBTN);
            this.Controls.Add(this.CancelBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DiscoverServerDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Discover Servers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button OkBTN;
        private System.Windows.Forms.Label ValueLB;
        private System.Windows.Forms.TextBox ValueTB;
        private System.Windows.Forms.ListBox ServersLB;
        private System.Windows.Forms.Button FindBTN;
    }
}