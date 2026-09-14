namespace pryCaglierisSp2
{
    partial class lblNumero
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroTickets = new System.Windows.Forms.TextBox();
            this.cmbtickets = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNumeroTicket = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstboxventas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(488, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // txtNumeroTickets
            // 
            this.txtNumeroTickets.Location = new System.Drawing.Point(118, 15);
            this.txtNumeroTickets.Name = "txtNumeroTickets";
            this.txtNumeroTickets.Size = new System.Drawing.Size(51, 20);
            this.txtNumeroTickets.TabIndex = 1;
            this.txtNumeroTickets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTickets_KeyPress);
            // 
            // cmbtickets
            // 
            this.cmbtickets.FormattingEnabled = true;
            this.cmbtickets.Location = new System.Drawing.Point(118, 56);
            this.cmbtickets.Name = "cmbtickets";
            this.cmbtickets.Size = new System.Drawing.Size(121, 21);
            this.cmbtickets.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(8, 59);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(68, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "tipo de ticket";
            // 
            // lblNumeroTicket
            // 
            this.lblNumeroTicket.AutoSize = true;
            this.lblNumeroTicket.Location = new System.Drawing.Point(8, 19);
            this.lblNumeroTicket.Name = "lblNumeroTicket";
            this.lblNumeroTicket.Size = new System.Drawing.Size(86, 13);
            this.lblNumeroTicket.TabIndex = 4;
            this.lblNumeroTicket.Text = "numero de ticket";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(57, 100);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(86, 32);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstboxventas
            // 
            this.lstboxventas.FormattingEnabled = true;
            this.lstboxventas.Location = new System.Drawing.Point(14, 150);
            this.lstboxventas.Name = "lstboxventas";
            this.lstboxventas.Size = new System.Drawing.Size(225, 160);
            this.lstboxventas.TabIndex = 6;
            this.lstboxventas.SelectedIndexChanged += new System.EventHandler(this.lstboxventas_SelectedIndexChanged);
            // 
            // lblNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lstboxventas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblNumeroTicket);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbtickets);
            this.Controls.Add(this.txtNumeroTickets);
            this.Controls.Add(this.dtpFecha);
            this.Name = "lblNumero";
            this.Text = "Venta de Tickets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNumeroTickets;
        private System.Windows.Forms.ComboBox cmbtickets;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumeroTicket;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lstboxventas;
    }
}

