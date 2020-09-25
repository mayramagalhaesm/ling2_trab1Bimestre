namespace Cakelicia1
{
    partial class FrmAgendar
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
            this.cmdSair = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblA = new System.Windows.Forms.Label();
            this.lblDEscolhida = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.cmdAgendar = new System.Windows.Forms.Button();
            this.lblResumo = new System.Windows.Forms.Label();
            this.listPedido = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdSair
            // 
            this.cmdSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdSair.Font = new System.Drawing.Font("Conformable", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdSair.Location = new System.Drawing.Point(462, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 31);
            this.cmdSair.TabIndex = 0;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = false;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.monthCalendar1.Font = new System.Drawing.Font("Homework", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(16, 71);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2020, 9, 21, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.White;
            this.lblA.Font = new System.Drawing.Font("Homework", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(12, 42);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(212, 20);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Agendar meu pedido para...";
            // 
            // lblDEscolhida
            // 
            this.lblDEscolhida.AutoSize = true;
            this.lblDEscolhida.BackColor = System.Drawing.Color.White;
            this.lblDEscolhida.Font = new System.Drawing.Font("Homework", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEscolhida.Location = new System.Drawing.Point(13, 251);
            this.lblDEscolhida.Name = "lblDEscolhida";
            this.lblDEscolhida.Size = new System.Drawing.Size(136, 16);
            this.lblDEscolhida.TabIndex = 3;
            this.lblDEscolhida.Text = "Sua data escolhida é:";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.BackColor = System.Drawing.Color.White;
            this.lblDE.Font = new System.Drawing.Font("Homework", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.Location = new System.Drawing.Point(155, 251);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(20, 16);
            this.lblDE.TabIndex = 4;
            this.lblDE.Text = "...";
         
            // 
            // cmdAgendar
            // 
            this.cmdAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdAgendar.Font = new System.Drawing.Font("Homework", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdAgendar.Location = new System.Drawing.Point(75, 292);
            this.cmdAgendar.Name = "cmdAgendar";
            this.cmdAgendar.Size = new System.Drawing.Size(122, 27);
            this.cmdAgendar.TabIndex = 5;
            this.cmdAgendar.Text = "Agendar";
            this.cmdAgendar.UseVisualStyleBackColor = false;
            this.cmdAgendar.Click += new System.EventHandler(this.cmdAgendar_Click);
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.BackColor = System.Drawing.Color.White;
            this.lblResumo.Font = new System.Drawing.Font("Homework", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(272, 46);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(124, 16);
            this.lblResumo.TabIndex = 6;
            this.lblResumo.Text = "Resumo do Pedido:";
            // 
            // listPedido
            // 
            this.listPedido.FormattingEnabled = true;
            this.listPedido.Location = new System.Drawing.Point(275, 73);
            this.listPedido.Name = "listPedido";
            this.listPedido.Size = new System.Drawing.Size(197, 160);
            this.listPedido.TabIndex = 7;
            // 
            // FrmAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cakelicia1.Properties.Resources.pastel_cupcakes_Art_Print_by_uhkneeluh;
            this.ClientSize = new System.Drawing.Size(549, 360);
            this.Controls.Add(this.listPedido);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.cmdAgendar);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.lblDEscolhida);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cmdSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agendar";
            this.Load += new System.EventHandler(this.FrmAgendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblDEscolhida;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button cmdAgendar;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.ListBox listPedido;
    }
}