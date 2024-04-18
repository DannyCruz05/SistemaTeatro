namespace CapaDepresentacion
{
    partial class FrmClientes
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
            txtClienteId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            txtDNI = new TextBox();
            label5 = new Label();
            txtNombres = new TextBox();
            label6 = new Label();
            txtApellidos = new TextBox();
            groupBox1 = new GroupBox();
            chkEstado = new CheckBox();
            label7 = new Label();
            dgvdatos = new DataGridView();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).BeginInit();
            SuspendLayout();
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(115, 32);
            txtClienteId.Margin = new Padding(4, 3, 4, 3);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(112, 23);
            txtClienteId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(384, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Cliente Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 77);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(115, 80);
            txtCodigo.Margin = new Padding(4, 3, 4, 3);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(182, 23);
            txtCodigo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 126);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 6;
            label4.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(115, 128);
            txtDNI.Margin = new Padding(4, 3, 4, 3);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(182, 23);
            txtDNI.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 170);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(115, 172);
            txtNombres.Margin = new Padding(4, 3, 4, 3);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(261, 23);
            txtNombres.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 217);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 10;
            label6.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(115, 219);
            txtApellidos.Margin = new Padding(4, 3, 4, 3);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(261, 23);
            txtApellidos.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtClienteId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(33, 67);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(399, 297);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(115, 259);
            chkEstado.Margin = new Padding(4, 3, 4, 3);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 16;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(34, 256);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 14;
            label7.Text = "Estado";
            // 
            // dgvdatos
            // 
            dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatos.Location = new Point(33, 379);
            dgvdatos.Margin = new Padding(4, 3, 4, 3);
            dgvdatos.Name = "dgvdatos";
            dgvdatos.Size = new Size(852, 196);
            dgvdatos.TabIndex = 17;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(493, 313);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 51);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click_1;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 607);
            Controls.Add(btnGuardar);
            Controls.Add(dgvdatos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmClientes";
            Text = "CN_Clientes";
            Load += FrmClientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClienteId;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodigo;
        private Label label4;
        private TextBox txtDNI;
        private Label label5;
        private TextBox txtNombres;
        private Label label6;
        private TextBox txtApellidos;
        private GroupBox groupBox1;
        private Label label7;
        private CheckBox chkEstado;
        private DataGridView dgvdatos;
        private Button btnGuardar;
    }
}