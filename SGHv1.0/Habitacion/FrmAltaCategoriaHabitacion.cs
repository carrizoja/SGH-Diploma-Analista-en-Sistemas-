using SGH.BE.MultiIdioma;
using SGH.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH.BE.Observer;
using SGH.BE;

namespace SGHv1._0.Habitacion
{
    public partial class FrmAltaCategoriaHabitacion : Form, IObserver
    {
        public FrmAltaCategoriaHabitacion()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            CambiarIdiomaUsandoObserver();
        }

        public void CambiarIdiomaUsandoObserver()
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);
        }

        private void FrmAltaCategoriaHabitacion_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Control con in this.Controls)
            {
                if (con is TextBox)
                {
                    TextBox textBox = con as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor, completar todos los campos");
                        return;
                    }
                }
            }

            CategoriaHabitacion nuevaCategoriaHabitacion = new CategoriaHabitacion();
            BLLCategoriaHabitacion bLLCategoriaHabitacion= new BLLCategoriaHabitacion();

            nuevaCategoriaHabitacion.Nombre = txtNombreCategoria.Text;
            nuevaCategoriaHabitacion.CodCategoriaHabitacion = txtCodigoCategoriaHabitacion.Text;

            int resultadoAlta = bLLCategoriaHabitacion.RegistrarCategoriaHabitacion(nuevaCategoriaHabitacion);//bLLCliente.RegistrarCliente(nuevoCliente, usuario);

            if (resultadoAlta == 1)
            {
                MessageBox.Show("Se registro la categoria con éxito!");
            }
            if (resultadoAlta == 0)
            {
                MessageBox.Show("Ya existe una categoria con ese nombre");
            }

        }
    }
}
