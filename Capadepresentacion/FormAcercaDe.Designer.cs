namespace Capadepresentacion
{
    partial class FormAcercaDe
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
            listBox5 = new ListBox();
            SuspendLayout();
            // 
            // listBox5
            // 
            listBox5.Dock = DockStyle.Fill;
            listBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBox5.ForeColor = SystemColors.MenuText;
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 20;
            listBox5.Items.AddRange(new object[] { "Software de Registro de Pasajeros y Pagos", "", "Desarrollador: Wilber De La Rosa", "Código de Estudiante: 2022-0547", "Fecha de Creación: 16/04/2024", "", "Herramientas Utilizadas:", "- SQL Server: Versión 2019", "- IDE: Visual Studio Community 2022", "- Frameworks: .NET 7", "- Lenguaje de Programación: C#", "", "Descripción del Programa:", "Este software está diseñado para administrar el registro y seguimiento de pasajeros y sus pagos asociados. Funcionalidades clave incluyen:", "- Registro y Gestión de Pasajeros: Permite el ingreso y actualización de datos de pasajeros.", "- Administración de Pagos: Facilita el manejo de los pagos relacionados con los pasajeros registrados.", "", "Características Adicionales:", "- Consultas Avanzadas: Permite la búsqueda detallada de pasajeros y pagos mediante varios criterios.", "- Interfaz de Usuario Intuitiva: Diseñada para optimizar la experiencia del usuario, facilitando las tareas administrativas.", "", "Objetivo del Proyecto:", "Desarrollado como proyecto final para la materia ISW-123-50 Programación Media [ENE-ABR 2024] (Punta Cana), demuestra la aplicación práctica de las habilidades y conocimientos adquiridos.", "", "Contacto del Profesor:", "Nombre: Ramón E. Zorrilla", "Correo Electrónico: rzorrilla@uce.edu.do", "Teléfono: 829-855-8364", "", "Agradecimientos:", "Un agradecimiento especial a los colaboradores y al profesor Ramón E. Zorrilla por su guía y apoyo durante el desarrollo de este proyecto." });
            listBox5.Location = new Point(0, 0);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(1327, 645);
            listBox5.TabIndex = 0;
            // 
            // FormAcercaDe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 645);
            Controls.Add(listBox5);
            Name = "FormAcercaDe";
            Text = "Acerca del sistema";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox5;
    }
}