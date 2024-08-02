using System;
using System.Windows.Forms;

namespace Deber_1
{
    public partial class Form_Tareas : Form
    {
        public Form_Tareas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            var Materia = txt_Materia.Text;
            var Tarea = txt_Tarea.Text;

            string cadena = Materia + " || " + Tarea;

            lst_Tareas.Items.Add(cadena); // Agrega la variable 'cadena' que contiene el valor correcto
            LimpiarCajas();
        }
        public void LimpiarCajas()
        {
            txt_Materia.Text = "";
            txt_Tarea.Text = "";
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            if (lst_Tareas.SelectedIndex != -1)
            {
                lst_Tareas.Items.RemoveAt(lst_Tareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione la tarea que desee eliminar");
            }
        }

    }
}
