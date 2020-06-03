namespace TcpSocket
{
    partial class ServerForm
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
            this.BtnStartServer = new System.Windows.Forms.Button();
            this.BtnStopServer = new System.Windows.Forms.Button();
            this.ListServerInformations = new System.Windows.Forms.ListBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.LabelHost = new System.Windows.Forms.Label();
            this.TextBoxHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStartServer
            // 
            this.BtnStartServer.Location = new System.Drawing.Point(19, 79);
            this.BtnStartServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStartServer.Name = "BtnStartServer";
            this.BtnStartServer.Size = new System.Drawing.Size(252, 100);
            this.BtnStartServer.TabIndex = 0;
            this.BtnStartServer.Text = "Iniciar Servidor";
            this.BtnStartServer.UseVisualStyleBackColor = true;
            this.BtnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // BtnStopServer
            // 
            this.BtnStopServer.Enabled = false;
            this.BtnStopServer.Location = new System.Drawing.Point(280, 79);
            this.BtnStopServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStopServer.Name = "BtnStopServer";
            this.BtnStopServer.Size = new System.Drawing.Size(256, 100);
            this.BtnStopServer.TabIndex = 1;
            this.BtnStopServer.Text = "Detener Servidor";
            this.BtnStopServer.UseVisualStyleBackColor = true;
            this.BtnStopServer.Click += new System.EventHandler(this.BtnStopServer_Click);
            // 
            // ListServerInformations
            // 
            this.ListServerInformations.FormattingEnabled = true;
            this.ListServerInformations.ItemHeight = 20;
            this.ListServerInformations.Location = new System.Drawing.Point(19, 188);
            this.ListServerInformations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListServerInformations.Name = "ListServerInformations";
            this.ListServerInformations.Size = new System.Drawing.Size(516, 324);
            this.ListServerInformations.TabIndex = 2;
            this.ListServerInformations.SelectedIndexChanged += new System.EventHandler(this.ListServerInformations_SelectedIndexChanged);
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(276, 14);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(60, 20);
            this.LabelPort.TabIndex = 5;
            this.LabelPort.Text = "Puerto:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(280, 39);
            this.TextBoxPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(255, 26);
            this.TextBoxPort.TabIndex = 6;
            this.TextBoxPort.Text = "3000";
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(15, 14);
            this.LabelHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(47, 20);
            this.LabelHost.TabIndex = 7;
            this.LabelHost.Text = "Host:";
            // 
            // TextBoxHost
            // 
            this.TextBoxHost.Location = new System.Drawing.Point(19, 39);
            this.TextBoxHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxHost.Name = "TextBoxHost";
            this.TextBoxHost.Size = new System.Drawing.Size(250, 26);
            this.TextBoxHost.TabIndex = 8;
            this.TextBoxHost.Text = "127.0.0.1";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.TextBoxHost);
            this.Controls.Add(this.LabelHost);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.ListServerInformations);
            this.Controls.Add(this.BtnStopServer);
            this.Controls.Add(this.BtnStartServer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServerForm";
            this.Text = "SERVIDOR";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartServer;
        private System.Windows.Forms.Button BtnStopServer;
        private System.Windows.Forms.ListBox ListServerInformations;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.TextBox TextBoxHost;
    }
}

