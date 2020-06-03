namespace TcpSocket
{
    partial class Chat
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnconctar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(527, 264);
            this.listBox1.TabIndex = 0;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(473, 360);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(103, 37);
            this.btnenviar.TabIndex = 1;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btnconctar
            // 
            this.btnconctar.Location = new System.Drawing.Point(208, 211);
            this.btnconctar.Name = "btnconctar";
            this.btnconctar.Size = new System.Drawing.Size(103, 37);
            this.btnconctar.TabIndex = 3;
            this.btnconctar.Text = "Conectar";
            this.btnconctar.UseVisualStyleBackColor = true;
            this.btnconctar.Click += new System.EventHandler(this.btnconctar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 26);
            this.textBox2.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(230, 102);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 20);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Usuario";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnconctar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.listBox1);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnconctar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl1;
    }
}