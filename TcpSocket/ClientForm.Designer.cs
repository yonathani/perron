namespace TcpSocket
{
    partial class ClientForm
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
            this.BtnSearchFile = new System.Windows.Forms.Button();
            this.LabelHostName = new System.Windows.Forms.Label();
            this.TextBoxHostName = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.ListBoxClientInformations = new System.Windows.Forms.ListBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBoxFile = new System.Windows.Forms.GroupBox();
            this.BtnSelectPath = new System.Windows.Forms.Button();
            this.btnchat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GroupBoxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearchFile
            // 
            this.BtnSearchFile.Enabled = false;
            this.BtnSearchFile.Location = new System.Drawing.Point(386, 109);
            this.BtnSearchFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearchFile.Name = "BtnSearchFile";
            this.BtnSearchFile.Size = new System.Drawing.Size(125, 31);
            this.BtnSearchFile.TabIndex = 4;
            this.BtnSearchFile.Text = "Buscar";
            this.BtnSearchFile.UseVisualStyleBackColor = true;
            this.BtnSearchFile.Click += new System.EventHandler(this.BtnSearchFile_Click);
            // 
            // LabelHostName
            // 
            this.LabelHostName.AutoSize = true;
            this.LabelHostName.Location = new System.Drawing.Point(4, 25);
            this.LabelHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHostName.Name = "LabelHostName";
            this.LabelHostName.Size = new System.Drawing.Size(47, 20);
            this.LabelHostName.TabIndex = 5;
            this.LabelHostName.Text = "Host:";
            // 
            // TextBoxHostName
            // 
            this.TextBoxHostName.Location = new System.Drawing.Point(9, 55);
            this.TextBoxHostName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxHostName.Name = "TextBoxHostName";
            this.TextBoxHostName.Size = new System.Drawing.Size(244, 26);
            this.TextBoxHostName.TabIndex = 6;
            this.TextBoxHostName.Text = "127.0.0.1";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(9, 95);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(246, 52);
            this.BtnConnect.TabIndex = 7;
            this.BtnConnect.Text = "Conectar";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ListBoxClientInformations
            // 
            this.ListBoxClientInformations.FormattingEnabled = true;
            this.ListBoxClientInformations.ItemHeight = 20;
            this.ListBoxClientInformations.Location = new System.Drawing.Point(18, 335);
            this.ListBoxClientInformations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxClientInformations.Name = "ListBoxClientInformations";
            this.ListBoxClientInformations.Size = new System.Drawing.Size(512, 224);
            this.ListBoxClientInformations.TabIndex = 8;
            this.ListBoxClientInformations.SelectedIndexChanged += new System.EventHandler(this.ListBoxClientInformations_SelectedIndexChanged);
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(260, 25);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(60, 20);
            this.LabelPort.TabIndex = 9;
            this.LabelPort.Text = "Puerto:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(264, 55);
            this.TextBoxPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(244, 26);
            this.TextBoxPort.TabIndex = 10;
            this.TextBoxPort.Text = "3000";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(264, 95);
            this.BtnDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(246, 52);
            this.BtnDisconnect.TabIndex = 11;
            this.BtnDisconnect.Text = "Desconectar";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Archivo:";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Location = new System.Drawing.Point(9, 109);
            this.TextBoxFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Size = new System.Drawing.Size(365, 26);
            this.TextBoxFileName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ruta:";
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Location = new System.Drawing.Point(9, 49);
            this.TextBoxPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(365, 26);
            this.TextBoxPath.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDisconnect);
            this.groupBox1.Controls.Add(this.TextBoxPort);
            this.groupBox1.Controls.Add(this.LabelPort);
            this.groupBox1.Controls.Add(this.TextBoxHostName);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.LabelHostName);
            this.groupBox1.Location = new System.Drawing.Point(18, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(519, 158);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de conexion";
            // 
            // GroupBoxFile
            // 
            this.GroupBoxFile.Controls.Add(this.BtnSelectPath);
            this.GroupBoxFile.Controls.Add(this.label2);
            this.GroupBoxFile.Controls.Add(this.TextBoxPath);
            this.GroupBoxFile.Controls.Add(this.TextBoxFileName);
            this.GroupBoxFile.Controls.Add(this.BtnSearchFile);
            this.GroupBoxFile.Controls.Add(this.label1);
            this.GroupBoxFile.Enabled = false;
            this.GroupBoxFile.Location = new System.Drawing.Point(18, 178);
            this.GroupBoxFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxFile.Name = "GroupBoxFile";
            this.GroupBoxFile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxFile.Size = new System.Drawing.Size(519, 151);
            this.GroupBoxFile.TabIndex = 17;
            this.GroupBoxFile.TabStop = false;
            this.GroupBoxFile.Text = "Inrformacion del archivo";
            // 
            // BtnSelectPath
            // 
            this.BtnSelectPath.Location = new System.Drawing.Point(387, 49);
            this.BtnSelectPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelectPath.Name = "BtnSelectPath";
            this.BtnSelectPath.Size = new System.Drawing.Size(123, 31);
            this.BtnSelectPath.TabIndex = 16;
            this.BtnSelectPath.Text = "Seleccionar";
            this.BtnSelectPath.UseVisualStyleBackColor = true;
            this.BtnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);
            // 
            // btnchat
            // 
            this.btnchat.Location = new System.Drawing.Point(539, 421);
            this.btnchat.Name = "btnchat";
            this.btnchat.Size = new System.Drawing.Size(75, 52);
            this.btnchat.TabIndex = 18;
            this.btnchat.Text = "Chat";
            this.btnchat.UseVisualStyleBackColor = true;
            this.btnchat.Click += new System.EventHandler(this.btnchat_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 580);
            this.Controls.Add(this.btnchat);
            this.Controls.Add(this.GroupBoxFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListBoxClientInformations);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientForm";
            this.Text = " CLIENTE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBoxFile.ResumeLayout(false);
            this.GroupBoxFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSearchFile;
        private System.Windows.Forms.Label LabelHostName;
        private System.Windows.Forms.TextBox TextBoxHostName;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ListBox ListBoxClientInformations;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupBoxFile;
        private System.Windows.Forms.Button BtnSelectPath;
        private System.Windows.Forms.Button btnchat;
    }
}