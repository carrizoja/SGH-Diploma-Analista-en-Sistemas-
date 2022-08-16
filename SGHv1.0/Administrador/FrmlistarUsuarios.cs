using SGH.BE.CompositePermisos;
using SGH.BE.MultiIdioma;
using SGH.BE.Observer;
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

namespace SGHv1._0.Administrador
{
    /// <summary>
    /// Form para listar Usuarios
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmlistarUsuarios : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmlistarUsuarios"/> class.
        /// </summary>
        public FrmlistarUsuarios()
        {
            InitializeComponent();
        }
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
        /// Handles the Load event of the FrmlistarUsuarios control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmlistarUsuarios_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);


            listUsuarios.View = View.Details;
            listUsuarios.FullRowSelect = true;
            listUsuarios.MultiSelect = false;

            listUsuarios.Columns.Add("Nombre", 100);
            listUsuarios.Columns.Add("Dni", 80);
            listUsuarios.Columns.Add("Email", 140);

            BLLUsuario bLLUsuario = new BLLUsuario(); //arreglar esto 
            List<Usuario> resultadoUsuario = bLLUsuario.TraerTodosLosUsuarios();


            foreach (var item in resultadoUsuario)
            {
                String[] row = { item.Nombre, item.Dni.ToString(), item.Email.ToString() };

                ListViewItem item2 = new ListViewItem(row);

                listUsuarios.Items.Add(item2);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
