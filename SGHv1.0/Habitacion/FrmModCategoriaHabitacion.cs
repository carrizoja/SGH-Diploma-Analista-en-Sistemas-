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
using SGH.BE.CompositePermisos;
using System.Text.RegularExpressions;

namespace SGHv1._0.Habitacion
{
    public partial class FrmModCategoriaHabitacion : Form, IObserver
    {
        CategoriaHabitacion nuevaCatHab = new CategoriaHabitacion();

        public FrmModCategoriaHabitacion()
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

        private void FrmModCategoriaHabitacion_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);
        }

        private void btnTraerCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                BLLCategoriaHabitacion bLLCatHab = new BLLCategoriaHabitacion();
                List<CategoriaHabitacion> categoriasHabObtenidas = bLLCatHab.TraerCatHab(txtCodigoCat.Text);

                foreach (var item in categoriasHabObtenidas)
                {
                    nuevaCatHab.CodCategoriaHabitacion = item.CodCategoriaHabitacion;
                    nuevaCatHab.Nombre = item.Nombre;
                   

                 //   txtCodigoCat.Text = item.CodCategoriaHabitacion;
                    txtNombreCodigo.Text = item.Nombre;
                  
                }

            }
            catch (Exception ex)
            {
                try
                {
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = ex.Message;
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);
                }
                catch (Exception ax)
                {
                    MessageBox.Show(ax.Data.ToString());
                }


                MessageBox.Show(ex.Data.ToString());
            }
        }

        private void txtCodigoCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex("^[A-Za-z]*$");

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

                if (!regex.IsMatch(txtNombreCodigo.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir letras");
                    return;
                }


                BLLCategoriaHabitacion bLLCatHab = new BLLCategoriaHabitacion();
                CategoriaHabitacion unaNuevaCatHabModificada = new CategoriaHabitacion();
                unaNuevaCatHabModificada.CodCategoriaHabitacion = txtCodigoCat.Text;
                unaNuevaCatHabModificada.Nombre = txtNombreCodigo.Text;
               
                int resultadoModificacion = bLLCatHab.ModificarCategoriaHabitacion(unaNuevaCatHabModificada, nuevaCatHab.Nombre);

                if (resultadoModificacion == 1)
                {
                    MessageBox.Show("Se actualizó el cliente con éxito");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente");
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = ex.Message;
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);
                }
                catch (Exception ax)
                {
                    MessageBox.Show(ax.Data.ToString());
                }


                MessageBox.Show(ex.Data.ToString());
            }
        }
    }
}
