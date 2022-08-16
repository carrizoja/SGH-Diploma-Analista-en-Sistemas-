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
    /// Form para borrar un Usuario
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmBorrarUsuario : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmBorrarUsuario"/> class.
        /// </summary>
        public FrmBorrarUsuario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Load event of the FrmBorrarUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmBorrarUsuario_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

            listBorrarUsuario.View = View.Details;
            listBorrarUsuario.FullRowSelect = true;
            listBorrarUsuario.MultiSelect = false;

            listBorrarUsuario.Columns.Add("Nombre", 100);
            listBorrarUsuario.Columns.Add("Dni", 100);
            listBorrarUsuario.Columns.Add("Email", 80);
            listBorrarUsuario.Columns.Add("IdUsuario", 50);


            BLLUsuario bLLUsuario = new BLLUsuario(); //arreglar esto alf
            List<Usuario> resultadoAutos = bLLUsuario.TraerTodosLosUsuarios();


            foreach (var item in resultadoAutos)
            {
                String[] row = { item.Nombre, item.Dni.ToString(), item.Email, item.IdUsuario.ToString() };

                ListViewItem item2 = new ListViewItem(row);

                listBorrarUsuario.Items.Add(item2);
            }

            btnBorrarUsuario.Enabled = false;
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the listBorrarUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void listBorrarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBorrarUsuario.Enabled = true;
        }
        /// <summary>
        /// Handles the Click event of the btnBorrarUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                var index = listBorrarUsuario.SelectedIndices;


                string idUsuario = listBorrarUsuario.Items[index[0]].SubItems[3].Text;


                BLLUsuario bLLUsuario = new BLLUsuario(); //arreglar esto alf
                bLLUsuario.BorrarUsuario(idUsuario);

                MessageBox.Show("Se Borró el Usuario exitosamente");
                Usuario _usuario = Usuario.Instancia;
                var unaBitacora = new SGH.BE.Bitacora();
                unaBitacora.fecha = DateTime.Now;
                unaBitacora.descripcion = "Usuario eliminado";
                unaBitacora.usuario = _usuario;
                unaBitacora.formulario = this.Name;
                BLLBitacora bitaElinimarUsuario = new BLLBitacora();
                bitaElinimarUsuario.GrabarBitacora(unaBitacora);

                listBorrarUsuario.Clear();
                FrmBorrarUsuario_Load(sender, e);

               
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
        /// <summary>
        /// Actualiza this instance.
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
    }
}
