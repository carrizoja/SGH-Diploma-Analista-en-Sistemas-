using SGH.BE;
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

namespace SGHv1._0
{
    /// <summary>
    /// Formulario para Listar Clientes
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class ListarClientes : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListarClientes"/> class.
        /// </summary>
        public ListarClientes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Actualizars this instance.
        /// </summary>
        public void Actualizar()
        {
            CambiarIdiomaUsandoObserver();
        }
        /// <summary>
        /// Cambiars the idioma usando observer.
        /// </summary>
        public void CambiarIdiomaUsandoObserver()
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);
        }
        /// <summary>
        /// Handles the Load event of the ListarClientes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ListarClientes_Load(object sender, EventArgs e)
        {

            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "ConsultarClientes");
            helpProvider1.SetHelpKeyword(this, "ConsultarClientes");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

            listClientesCargados.View = View.Details;
            listClientesCargados.FullRowSelect = true;
            listClientesCargados.MultiSelect = false;

            listClientesCargados.Columns.Add("Nombre", 100);
            listClientesCargados.Columns.Add("Apellido", 100);
            listClientesCargados.Columns.Add("Dni", 80);
            listClientesCargados.Columns.Add("Edad", 50);
            listClientesCargados.Columns.Add("Email", 140);
            listClientesCargados.Columns.Add("Telefono", 140);

            BLLCliente bLLCliente = new BLLCliente(); //arreglar esto alf
            List<Cliente> resultadoCliente = bLLCliente.TraerTodosLosClientes();


            foreach (var item in resultadoCliente)
            {
                String[] row = { item.Nombre, item.Apellido, item.Dni.ToString(), item.Edad.ToString(), item.Email.ToString(), item.Telefono.ToString() };

                ListViewItem item2 = new ListViewItem(row);

                listClientesCargados.Items.Add(item2);
            }
        }

        private void ListClientesCargados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
