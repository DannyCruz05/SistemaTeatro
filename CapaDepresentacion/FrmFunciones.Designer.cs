namespace CapaDepresentacion
{
    partial class FrmFunciones
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
            btnGuardar = new Button();
            dgvdatos = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            dtpHoraFin = new DateTimePicker();
            dtpHoraI = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            txtFuncionId = new TextBox();
            label6 = new Label();
            chkEstado = new CheckBox();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(476, 316);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 51);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvdatos
            // 
            dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatos.Location = new Point(16, 382);
            dgvdatos.Margin = new Padding(4, 3, 4, 3);
            dgvdatos.Name = "dgvdatos";
            dgvdatos.Size = new Size(852, 196);
            dgvdatos.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpHoraFin);
            groupBox1.Controls.Add(dtpHoraI);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(txtFuncionId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(16, 70);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(452, 297);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 217);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 21;
            label4.Text = "Hora Fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 20;
            label3.Text = "Hora Inicio";
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.Location = new Point(144, 214);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(132, 23);
            dtpHoraFin.TabIndex = 19;
            // 
            // dtpHoraI
            // 
            dtpHoraI.Format = DateTimePickerFormat.Time;
            dtpHoraI.Location = new Point(144, 172);
            dtpHoraI.Name = "dtpHoraI";
            dtpHoraI.Size = new Size(132, 23);
            dtpHoraI.TabIndex = 18;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(144, 131);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(228, 23);
            dtpFecha.TabIndex = 17;
            // 
            // txtFuncionId
            // 
            txtFuncionId.Location = new Point(144, 33);
            txtFuncionId.Margin = new Padding(4, 3, 4, 3);
            txtFuncionId.Name = "txtFuncionId";
            txtFuncionId.Size = new Size(112, 23);
            txtFuncionId.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 134);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 10;
            label6.Text = "Fecha Funcion";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(116, 259);
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
            label7.Location = new Point(22, 256);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 14;
            label7.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Funcion Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 87);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 85);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 23);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(367, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 19;
            label1.Text = "Funciones";
            // 
            // FrmFunciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(dgvdatos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmFunciones";
            Text = "FrmFunciones";
            Load += FrmFunciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdatos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dgvdatos;
        private GroupBox groupBox1;
        private TextBox txtFuncionId;
        private Label label6;
        private CheckBox chkEstado;
        private Label label7;
        private Label label2;
        private TextBox txtCodigo;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Label label1;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraI;
        private DateTimePicker dtpFecha;
    }
}