namespace EjercicioFinoCliente
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btenviarMsg = new System.Windows.Forms.Button();
            this.tbMensajeEnviar = new System.Windows.Forms.TextBox();
            this.tbMensajes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.empezarSv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSv = new System.Windows.Forms.Label();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btenviarMsg
            // 
            this.btenviarMsg.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenviarMsg.Location = new System.Drawing.Point(527, 182);
            this.btenviarMsg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btenviarMsg.Name = "btenviarMsg";
            this.btenviarMsg.Size = new System.Drawing.Size(197, 34);
            this.btenviarMsg.TabIndex = 19;
            this.btenviarMsg.Text = "Enviar mensaje";
            this.btenviarMsg.UseVisualStyleBackColor = true;
            this.btenviarMsg.Click += new System.EventHandler(this.btenviarMsg_Click);
            // 
            // tbMensajeEnviar
            // 
            this.tbMensajeEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMensajeEnviar.Location = new System.Drawing.Point(190, 101);
            this.tbMensajeEnviar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbMensajeEnviar.Multiline = true;
            this.tbMensajeEnviar.Name = "tbMensajeEnviar";
            this.tbMensajeEnviar.Size = new System.Drawing.Size(894, 72);
            this.tbMensajeEnviar.TabIndex = 18;
            // 
            // tbMensajes
            // 
            this.tbMensajes.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMensajes.Location = new System.Drawing.Point(188, 237);
            this.tbMensajes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbMensajes.Multiline = true;
            this.tbMensajes.Name = "tbMensajes";
            this.tbMensajes.Size = new System.Drawing.Size(894, 190);
            this.tbMensajes.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Respuesta del servidor";
            // 
            // tbPuerto
            // 
            this.tbPuerto.Location = new System.Drawing.Point(565, 41);
            this.tbPuerto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.Size = new System.Drawing.Size(227, 20);
            this.tbPuerto.TabIndex = 15;
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(190, 40);
            this.tbHost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(214, 20);
            this.tbHost.TabIndex = 14;
            // 
            // empezarSv
            // 
            this.empezarSv.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empezarSv.Location = new System.Drawing.Point(911, 37);
            this.empezarSv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.empezarSv.Name = "empezarSv";
            this.empezarSv.Size = new System.Drawing.Size(125, 34);
            this.empezarSv.TabIndex = 12;
            this.empezarSv.Text = "Empezar";
            this.empezarSv.UseVisualStyleBackColor = true;
            this.empezarSv.Click += new System.EventHandler(this.empezarSv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Puerto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Host (IP)";
            // 
            // lbSv
            // 
            this.lbSv.AutoSize = true;
            this.lbSv.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSv.Location = new System.Drawing.Point(187, 79);
            this.lbSv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSv.Name = "lbSv";
            this.lbSv.Size = new System.Drawing.Size(210, 18);
            this.lbSv.TabIndex = 20;
            this.lbSv.Text = "Mensaje para el servidor";
            this.lbSv.Visible = false;
            // 
            // btnRecibir
            // 
            this.btnRecibir.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibir.Location = new System.Drawing.Point(527, 439);
            this.btnRecibir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(197, 34);
            this.btnRecibir.TabIndex = 21;
            this.btnRecibir.Text = "Recibir mensaje";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1260, 486);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.lbSv);
            this.Controls.Add(this.btenviarMsg);
            this.Controls.Add(this.tbMensajeEnviar);
            this.Controls.Add(this.tbMensajes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPuerto);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.empezarSv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btenviarMsg;
        private System.Windows.Forms.TextBox tbMensajeEnviar;
        private System.Windows.Forms.TextBox tbMensajes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPuerto;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Button empezarSv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSv;
        private System.Windows.Forms.Button btnRecibir;
    }
}

