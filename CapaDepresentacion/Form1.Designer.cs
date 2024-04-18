namespace CapaDepresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip2 = new MenuStrip();
            transaccionesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            reservacionesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip2.Items.AddRange(new ToolStripItem[] { transaccionesToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // transaccionesToolStripMenuItem
            // 
            transaccionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, funcionesToolStripMenuItem, reservacionesToolStripMenuItem });
            transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            transaccionesToolStripMenuItem.Size = new Size(115, 24);
            transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // funcionesToolStripMenuItem
            // 
            funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            funcionesToolStripMenuItem.Size = new Size(180, 24);
            funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // reservacionesToolStripMenuItem
            // 
            reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            reservacionesToolStripMenuItem.Size = new Size(180, 24);
            reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem transaccionesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem funcionesToolStripMenuItem;
        private ToolStripMenuItem reservacionesToolStripMenuItem;
    }
}