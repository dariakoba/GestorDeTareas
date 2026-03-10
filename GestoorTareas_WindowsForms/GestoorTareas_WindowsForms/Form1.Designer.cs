namespace GestorTareas_WindowsForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxTareas;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCompletar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxNombre = new TextBox();
            textBoxDescripcion = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            listBoxTareas = new ListBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonCompletar = new Button();
            label1 = new Label();
            label2 = new Label();
            chkPrioridadAlta = new CheckBox();
            cmbCategoria = new ComboBox();
            lblContadorTareas = new Label();
            btnLimpiarCampos = new Button();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(95, 7);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(239, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(95, 41);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(239, 96);
            textBoxDescripcion.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // listBoxTareas
            // 
            listBoxTareas.Location = new Point(370, 7);
            listBoxTareas.Name = "listBoxTareas";
            listBoxTareas.Size = new Size(489, 244);
            listBoxTareas.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(454, 267);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(84, 34);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(550, 267);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(115, 34);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCompletar
            // 
            buttonCompletar.Location = new Point(674, 267);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(102, 34);
            buttonCompletar.TabIndex = 6;
            buttonCompletar.Text = "Completar";
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 7;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 8;
            label2.Text = "Descripción";
            // 
            // chkPrioridadAlta
            // 
            chkPrioridadAlta.AutoSize = true;
            chkPrioridadAlta.Location = new Point(58, 206);
            chkPrioridadAlta.Name = "chkPrioridadAlta";
            chkPrioridadAlta.Size = new Size(121, 24);
            chkPrioridadAlta.TabIndex = 9;
            chkPrioridadAlta.Text = "Prioridad alta";
            chkPrioridadAlta.UseVisualStyleBackColor = true;
            chkPrioridadAlta.CheckedChanged += chkPrioridadAlta_CheckedChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Trabajo", "Personal", "Estudios" });
            cmbCategoria.Location = new Point(185, 204);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 10;
            cmbCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // lblContadorTareas
            // 
            lblContadorTareas.AutoSize = true;
            lblContadorTareas.Location = new Point(58, 267);
            lblContadorTareas.Name = "lblContadorTareas";
            lblContadorTareas.Size = new Size(128, 20);
            lblContadorTareas.TabIndex = 11;
            lblContadorTareas.Text = "Número de tareas";
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(215, 269);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(138, 29);
            btnLimpiarCampos.TabIndex = 12;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(903, 402);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(lblContadorTareas);
            Controls.Add(cmbCategoria);
            Controls.Add(chkPrioridadAlta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDescripcion);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBoxTareas);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonCompletar);
            Name = "Form1";
            Text = "Gestor de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private CheckBox chkPrioridadAlta;
        private ComboBox cmbCategoria;
        private Label lblContadorTareas;
        private Button btnLimpiarCampos;
    }
}
