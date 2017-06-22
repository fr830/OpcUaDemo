namespace TongFang.OpcUa.Client
{
    partial class ConnectServerCtrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectBTN = new System.Windows.Forms.Button();
            this.UseSecurityCK = new System.Windows.Forms.CheckBox();
            this.UrlCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBTN.Location = new System.Drawing.Point(425, 0);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(75, 23);
            this.ConnectBTN.TabIndex = 2;
            this.ConnectBTN.Text = "Connect";
            this.ConnectBTN.UseVisualStyleBackColor = true;
            this.ConnectBTN.Click += new System.EventHandler(this.Server_ConnectMI_Click);
            // 
            // UseSecurityCK
            // 
            this.UseSecurityCK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseSecurityCK.AutoSize = true;
            this.UseSecurityCK.Checked = true;
            this.UseSecurityCK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseSecurityCK.Location = new System.Drawing.Point(335, 3);
            this.UseSecurityCK.Name = "UseSecurityCK";
            this.UseSecurityCK.Size = new System.Drawing.Size(86, 17);
            this.UseSecurityCK.TabIndex = 1;
            this.UseSecurityCK.Text = "Use Security";
            this.UseSecurityCK.UseVisualStyleBackColor = true;
            // 
            // UrlCB
            // 
            this.UrlCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlCB.FormattingEnabled = true;
            this.UrlCB.Location = new System.Drawing.Point(0, 1);
            this.UrlCB.Name = "UrlCB";
            this.UrlCB.Size = new System.Drawing.Size(327, 21);
            this.UrlCB.TabIndex = 0;
            // 
            // ConnectServerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConnectBTN);
            this.Controls.Add(this.UseSecurityCK);
            this.Controls.Add(this.UrlCB);
            this.MaximumSize = new System.Drawing.Size(2048, 23);
            this.MinimumSize = new System.Drawing.Size(500, 23);
            this.Name = "ConnectServerCtrl";
            this.Size = new System.Drawing.Size(500, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectBTN;
        private System.Windows.Forms.CheckBox UseSecurityCK;
        private System.Windows.Forms.ComboBox UrlCB;
    }
}
