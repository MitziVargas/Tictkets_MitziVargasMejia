﻿
namespace Tictkets_MitziVargasMejia.Formularios
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gestiónDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCategoriasDeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creacionDeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solucionDeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.pROCESOSToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeUsuarioToolStripMenuItem,
            this.gestiónDeClientesToolStripMenuItem,
            this.toolStripSeparator1,
            this.gestiónDeRolesToolStripMenuItem,
            this.gestiónDeCategoriasDeTicketToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 20);
            this.toolStripMenuItem1.Text = "MANTENIMIENETOS";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // gestiónDeUsuarioToolStripMenuItem
            // 
            this.gestiónDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.gestiónDeUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestiónDeUsuarioToolStripMenuItem.Name = "gestiónDeUsuarioToolStripMenuItem";
            this.gestiónDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.gestiónDeUsuarioToolStripMenuItem.Text = "Gestión de Usuario";
            this.gestiónDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuarioToolStripMenuItem_Click);
            // 
            // gestiónDeClientesToolStripMenuItem
            // 
            this.gestiónDeClientesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.gestiónDeClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestiónDeClientesToolStripMenuItem.Name = "gestiónDeClientesToolStripMenuItem";
            this.gestiónDeClientesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.gestiónDeClientesToolStripMenuItem.Text = "Gestión de Clientes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // gestiónDeRolesToolStripMenuItem
            // 
            this.gestiónDeRolesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.gestiónDeRolesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestiónDeRolesToolStripMenuItem.Name = "gestiónDeRolesToolStripMenuItem";
            this.gestiónDeRolesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.gestiónDeRolesToolStripMenuItem.Text = "Gestión de Roles";
            // 
            // gestiónDeCategoriasDeTicketToolStripMenuItem
            // 
            this.gestiónDeCategoriasDeTicketToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.gestiónDeCategoriasDeTicketToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestiónDeCategoriasDeTicketToolStripMenuItem.Name = "gestiónDeCategoriasDeTicketToolStripMenuItem";
            this.gestiónDeCategoriasDeTicketToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.gestiónDeCategoriasDeTicketToolStripMenuItem.Text = "Gestión de Categorias de Ticket";
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacionDeTicketToolStripMenuItem,
            this.solucionDeTicketToolStripMenuItem});
            this.pROCESOSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // creacionDeTicketToolStripMenuItem
            // 
            this.creacionDeTicketToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.creacionDeTicketToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.creacionDeTicketToolStripMenuItem.Name = "creacionDeTicketToolStripMenuItem";
            this.creacionDeTicketToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.creacionDeTicketToolStripMenuItem.Text = "Creacion de Ticket";
            // 
            // solucionDeTicketToolStripMenuItem
            // 
            this.solucionDeTicketToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.solucionDeTicketToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.solucionDeTicketToolStripMenuItem.Name = "solucionDeTicketToolStripMenuItem";
            this.solucionDeTicketToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.solucionDeTicketToolStripMenuItem.Text = "Solucion de Ticket";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuarioLogueado,
            this.LblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(627, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // LblUsuarioLogueado
            // 
            this.LblUsuarioLogueado.Name = "LblUsuarioLogueado";
            this.LblUsuarioLogueado.Size = new System.Drawing.Size(14, 17);
            this.LblUsuarioLogueado.Text = "u";
            // 
            // LblHora
            // 
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(548, 17);
            this.LblHora.Spring = true;
            this.LblHora.Text = "Hora";
            this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TmrHora
            // 
            this.TmrHora.Interval = 1000;
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 399);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Sistema de control de Tickets de Soporte Tecnico y Trabajo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeCategoriasDeTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creacionDeTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solucionDeTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuarioLogueado;
        private System.Windows.Forms.ToolStripStatusLabel LblHora;
        private System.Windows.Forms.Timer TmrHora;
    }
}