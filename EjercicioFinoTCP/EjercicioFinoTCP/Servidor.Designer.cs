namespace EjercicioFinoTCP
{
    partial class Servidor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empezarSv = new System.Windows.Forms.Button();
            this.pararSv = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.tbMensajes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMensajeEnviar = new System.Windows.Forms.TextBox();
            this.btrecibirMsg = new System.Windows.Forms.Button();
            this.enviarMensajebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host (IP)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto:";
            // 
            // empezarSv
            // 
            this.empezarSv.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empezarSv.Location = new System.Drawing.Point(814, 40);
            this.empezarSv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.empezarSv.Name = "empezarSv";
            this.empezarSv.Size = new System.Drawing.Size(125, 32);
            this.empezarSv.TabIndex = 2;
            this.empezarSv.Text = "Empezar";
            this.empezarSv.UseVisualStyleBackColor = true;
            this.empezarSv.Click += new System.EventHandler(this.empezarSv_Click);
            // 
            // pararSv
            // 
            this.pararSv.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pararSv.Location = new System.Drawing.Point(947, 40);
            this.pararSv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pararSv.Name = "pararSv";
            this.pararSv.Size = new System.Drawing.Size(125, 32);
            this.pararSv.TabIndex = 3;
            this.pararSv.Text = "Parar";
            this.pararSv.UseVisualStyleBackColor = true;
            this.pararSv.Click += new System.EventHandler(this.pararSv_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(190, 40);
            this.tbHost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(214, 27);
            this.tbHost.TabIndex = 4;
            // 
            // tbPuerto
            // 
            this.tbPuerto.Location = new System.Drawing.Point(566, 41);
            this.tbPuerto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.Size = new System.Drawing.Size(214, 27);
            this.tbPuerto.TabIndex = 5;
            // 
            // tbMensajes
            // 
            this.tbMensajes.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMensajes.Location = new System.Drawing.Point(178, 112);
            this.tbMensajes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbMensajes.Multiline = true;
            this.tbMensajes.Name = "tbMensajes";
            this.tbMensajes.Size = new System.Drawing.Size(894, 160);
            this.tbMensajes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensaje Recibido del cliente:";
            // 
            // tbMensajeEnviar
            // 
            this.tbMensajeEnviar.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMensajeEnviar.Location = new System.Drawing.Point(178, 338);
            this.tbMensajeEnviar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbMensajeEnviar.Multiline = true;
            this.tbMensajeEnviar.Name = "tbMensajeEnviar";
            this.tbMensajeEnviar.Size = new System.Drawing.Size(894, 95);
            this.tbMensajeEnviar.TabIndex = 8;
            // 
            // btrecibirMsg
            // 
            this.btrecibirMsg.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrecibirMsg.Location = new System.Drawing.Point(529, 280);
            this.btrecibirMsg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btrecibirMsg.Name = "btrecibirMsg";
            this.btrecibirMsg.Size = new System.Drawing.Size(197, 32);
            this.btrecibirMsg.TabIndex = 9;
            this.btrecibirMsg.Text = "Recibir mensaje";
            this.btrecibirMsg.UseVisualStyleBackColor = true;
            this.btrecibirMsg.Click += new System.EventHandler(this.btrecibirMsg_Click);
            // 
            // enviarMensajebtn
            // 
            this.enviarMensajebtn.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarMensajebtn.Location = new System.Drawing.Point(529, 441);
            this.enviarMensajebtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.enviarMensajebtn.Name = "enviarMensajebtn";
            this.enviarMensajebtn.Size = new System.Drawing.Size(197, 32);
            this.enviarMensajebtn.TabIndex = 10;
            this.enviarMensajebtn.Text = "Enviar mensaje";
            this.enviarMensajebtn.UseVisualStyleBackColor = true;
            this.enviarMensajebtn.Click += new System.EventHandler(this.enviarMensajebtn_Click);
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1260, 486);
            this.Controls.Add(this.enviarMensajebtn);
            this.Controls.Add(this.btrecibirMsg);
            this.Controls.Add(this.tbMensajeEnviar);
            this.Controls.Add(this.tbMensajes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPuerto);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.pararSv);
            this.Controls.Add(this.empezarSv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button empezarSv;
        private System.Windows.Forms.Button pararSv;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbPuerto;
        private System.Windows.Forms.TextBox tbMensajes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMensajeEnviar;
        private System.Windows.Forms.Button btrecibirMsg;
        private System.Windows.Forms.Button enviarMensajebtn;
    }
}

