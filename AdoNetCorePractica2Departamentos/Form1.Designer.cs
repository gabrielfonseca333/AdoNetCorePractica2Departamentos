namespace AdoNetCorePractica2Departamentos
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
            cmbDepartamentos = new ComboBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            txtIdDepartamento = new TextBox();
            lstEmpleados = new ListBox();
            btnUpdateEmpleado = new Button();
            btnInsertarDepartamento = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNombreDepartamento = new TextBox();
            label4 = new Label();
            txtLocalidad = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtSalario = new TextBox();
            label7 = new Label();
            txtOficio = new TextBox();
            label8 = new Label();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(76, 68);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(121, 23);
            cmbDepartamentos.TabIndex = 0;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(285, 33);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 50);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Departamentos";
            // 
            // txtIdDepartamento
            // 
            txtIdDepartamento.Location = new Point(76, 150);
            txtIdDepartamento.Name = "txtIdDepartamento";
            txtIdDepartamento.Size = new Size(100, 23);
            txtIdDepartamento.TabIndex = 3;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(241, 132);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(268, 184);
            lstEmpleados.TabIndex = 4;
            // 
            // btnUpdateEmpleado
            // 
            btnUpdateEmpleado.Location = new Point(587, 265);
            btnUpdateEmpleado.Name = "btnUpdateEmpleado";
            btnUpdateEmpleado.Size = new Size(117, 51);
            btnUpdateEmpleado.TabIndex = 5;
            btnUpdateEmpleado.Text = "Update Empleado";
            btnUpdateEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnInsertarDepartamento
            // 
            btnInsertarDepartamento.Location = new Point(59, 292);
            btnInsertarDepartamento.Name = "btnInsertarDepartamento";
            btnInsertarDepartamento.Size = new Size(117, 51);
            btnInsertarDepartamento.TabIndex = 6;
            btnInsertarDepartamento.Text = "Insertar Departamento";
            btnInsertarDepartamento.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 132);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 7;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 180);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Nombre";
            // 
            // txtNombreDepartamento
            // 
            txtNombreDepartamento.Location = new Point(76, 198);
            txtNombreDepartamento.Name = "txtNombreDepartamento";
            txtNombreDepartamento.Size = new Size(100, 23);
            txtNombreDepartamento.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 228);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 11;
            label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(76, 246);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 114);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 12;
            label5.Text = "Empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(587, 202);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 18;
            label6.Text = "Oficio";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(587, 220);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 154);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(587, 172);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(587, 106);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 14;
            label8.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(587, 124);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtSalario);
            Controls.Add(label7);
            Controls.Add(txtOficio);
            Controls.Add(label8);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombreDepartamento);
            Controls.Add(label2);
            Controls.Add(btnInsertarDepartamento);
            Controls.Add(btnUpdateEmpleado);
            Controls.Add(lstEmpleados);
            Controls.Add(txtIdDepartamento);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(cmbDepartamentos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDepartamentos;
        private LinkLabel linkLabel1;
        private Label label1;
        private TextBox txtIdDepartamento;
        private ListBox lstEmpleados;
        private Button btnUpdateEmpleado;
        private Button btnInsertarDepartamento;
        private Label label2;
        private Label label3;
        private TextBox txtNombreDepartamento;
        private Label label4;
        private TextBox txtLocalidad;
        private Label label5;
        private Label label6;
        private TextBox txtSalario;
        private Label label7;
        private TextBox txtOficio;
        private Label label8;
        private TextBox txtApellido;
    }
}
