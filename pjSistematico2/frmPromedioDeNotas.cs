using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjSistematico2
{
    public partial class frmPromedioDeNotas : Form
    {
        Calificaciones obj = new Calificaciones();
        public frmPromedioDeNotas()
        {
            InitializeComponent();
            int num;
            ListViewItem item;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = txtNombreEstudiante.Text;
            int nota1 = int.Parse(txtNota1.Text.ToString());
            int nota2 = int.Parse(txtNota2.Text.ToString());
            int nota3 = int.Parse(txtNota3.Text.ToString());

            while (nota1 > 0 && nota1 < 100);
            while (nota2 > 0 && nota2 < 100);
            while (nota3 > 0 && nota3 < 100);

            ListViewItem fila = new ListViewItem(nombreEstudiante = txtNombreEstudiante.Text.ToString());
            fila.SubItems.Add(txtNota1.Text);
            fila.SubItems.Add(txtNota2.Text);
            fila.SubItems.Add(txtNota3.Text);
            fila.SubItems.Add(obj.ObtenerPromedio().ToString());
            lvRegistro.Items.Add(fila);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
