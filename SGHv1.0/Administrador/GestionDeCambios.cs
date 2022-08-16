using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH.BE;
using SGH.BE.MultiIdioma;
using SGH.BE.Observer;
using SGH.BLL;
using SGH.BE.Vistas;

namespace SGHv1._0.Administrador
{
    /// <summary>
    /// Formulario para la Gestión de Cambios
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class GestionDeCambios : Form, IObserver
    {
        BLLIdioma BLLIdioma = new BLLIdioma();

        /// <summary>
        /// Actualiza instance.
        /// </summary>
        public void Actualizar()
        {
            CambiarIdiomaUsandoObserver();
        }
        /// <summary>
        /// Cambia idioma usando observer.
        /// </summary>
        public void CambiarIdiomaUsandoObserver()

        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GestionDeCambios"/> class.
        /// </summary>
        public GestionDeCambios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Click event of the btnAplicar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try

            {
                listViewGestionCambios.Clear();
                if (rbInsert.Checked)
                {
                    listViewGestionCambios.View = View.Details;
                    listViewGestionCambios.FullRowSelect = true;
                    listViewGestionCambios.MultiSelect = false;

                    listViewGestionCambios.Columns.Add(" Nro Versión Cambio", 100);
                    listViewGestionCambios.Columns.Add("Operación de Cambio", 100);
                    listViewGestionCambios.Columns.Add("ID Cliente", 150);
                    listViewGestionCambios.Columns.Add("Nombre", 100);
                    listViewGestionCambios.Columns.Add("Apellido", 100);
                    listViewGestionCambios.Columns.Add("DNI", 100);
                    listViewGestionCambios.Columns.Add("Edad", 100);
                    listViewGestionCambios.Columns.Add("Email", 100);
                    listViewGestionCambios.Columns.Add("Telefono", 100);
                    BLLGestionCambios bLLGestionCambios = new BLLGestionCambios();
                    GestionDeCambios gestionDeCambios = new GestionDeCambios();
                    List<GcambiosTodosVista> resultadoGestionCambios = bLLGestionCambios.TraerTodoGestionCambios();

                    foreach (var item in resultadoGestionCambios)
                    {
                        String[] row = { item.SYS_CHANGE_VERSION.ToString(), item.SYS_CHANGE_OPERATION, item.idCliente.ToString(), item.Nombre, item.Apellido, item.Dni.ToString(), item.Edad.ToString(), item.Email,item.Telefono.ToString() };

                        ListViewItem item2 = new ListViewItem(row);

                        listViewGestionCambios.Items.Add(item2);

                    }


                }
                else
                {
                    listViewGestionCambios.Clear();
                    listViewGestionCambios.View = View.Details;
                    listViewGestionCambios.FullRowSelect = true;
                    listViewGestionCambios.MultiSelect = false;

                    listViewGestionCambios.Columns.Add(" Nro Versión Cambio", 100);
                    listViewGestionCambios.Columns.Add("Operación de Cambio", 100);
                   
                    BLLGestionCambios bLLGestionCambios = new BLLGestionCambios();
                    GestionDeCambios gestionDeCambios = new GestionDeCambios();
                    List<GcambiosDeleteVista> resultadoGestionCambios = bLLGestionCambios.TraerTodoGestionCambiosDelete();

                    foreach (var item in resultadoGestionCambios)
                    {
                        String[] row = { item.SYS_CHANGE_VERSION.ToString(), item.SYS_CHANGE_OPERATION };

                        ListViewItem item2 = new ListViewItem(row);

                        listViewGestionCambios.Items.Add(item2);

                    }

                }
            }
            catch
            {

            }
        }

        private void GestionDeCambios_Load(object sender, EventArgs e)
        {
           
        }

        private void rbInsert_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Handles the Click event of the btnLimpiar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listViewGestionCambios.Clear();
        }
    }
}
