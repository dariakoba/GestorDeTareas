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
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(95, 7);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(239, 23);
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
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // listBoxTareas
            // 
            listBoxTareas.ItemHeight = 15;
            listBoxTareas.Location = new Point(370, 7);
            listBoxTareas.Name = "listBoxTareas";
            listBoxTareas.Size = new Size(308, 229);
            listBoxTareas.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(65, 207);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(164, 207);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCompletar
            // 
            buttonCompletar.Location = new Point(259, 207);
            buttonCompletar.Name = "buttonCompletar";
            buttonCompletar.Size = new Size(75, 23);
            buttonCompletar.TabIndex = 6;
            buttonCompletar.Text = "Completar";
            buttonCompletar.Click += buttonCompletar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 44);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Descripción";
            // 
            // Form1
            // 
            ClientSize = new Size(690, 316);
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
    }
}
