using SGH.BE.CompositePermisos;
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
using System.Data.SqlClient; // borrar

namespace SGHv1._0.Administrador
{
    /// <summary>
    /// Form para realizar el Backup / Restore
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmBackupRestore : Form, IObserver
    {
        Idioma idioma = Idioma.InstanciaIdioma;
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmBackupRestore"/> class.
        /// </summary>
        public FrmBackupRestore()
        {
            InitializeComponent();
          
            idioma.RegistrarObserver(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupFileRuta.Text = dlg.SelectedPath;
                txtNombreBackup.Enabled = true;  
            }
        }
        /// <summary>
        /// Handles the Click event of the btnHacerBackup control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnHacerBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBaseDeDatos.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Por Favor, seleccione una Base de Datos");
                    return;
                }

                if (txtBackupFileRuta.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Por Favor, seleccione una ruta para hacer el Back Up");
                    return;
                }

                if (txtNombreBackup.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Por Favor, pongale un nombre al backup");
                    return;
                }

                BLLBackupRestore bLLBackupRestore = new BLLBackupRestore();
                bLLBackupRestore.HacerBackup(cmbBaseDeDatos.Text, txtBackupFileRuta.Text, txtNombreBackup.Text);

                Usuario _usuario = Usuario.Instancia;
                bLLBackupRestore.GrabarDatosBackup(cmbBaseDeDatos.Text, txtBackupFileRuta.Text, txtNombreBackup.Text, _usuario.Nombre);

               

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
                    unaBitacora.formulario = this.Name; 

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
        /// Handles the Load event of the FrmBackupRestore control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmBackupRestore_Load(object sender, EventArgs e)
        {
            try
            {
                BLLIdioma _traduccion = new BLLIdioma();
           //     Idioma idioma = Idioma.InstanciaIdioma;
                Form form = this;
                _traduccion.Traducir(idioma.IdIdioma, form);

                txtBackupFileRuta.Enabled = false;
                txtNombreBackup.Enabled = false;        // revisar acá. Hay Dif.

                BLLBackupRestore bLLBackupRestore = new BLLBackupRestore();
                List<String> databases = bLLBackupRestore.TraerBasesDeDatos();

                foreach (var item in databases)
                {
                    cmbBaseDeDatos.Items.Add(item.ToString());
                }

            }
            catch (Exception ex)
            {
                try
                {
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.UtcNow;
                    unaBitacora.descripcion = ex.Message;
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien

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
        /// <summary>
        /// Handles the FormClosing event of the FrmBackupRestore control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void FrmBackupRestore_FormClosing(object sender, FormClosingEventArgs e)
        {
            idioma.SacarRegistroObserver(this);

        }

        private void txtNombreBackup_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnRuta control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = dlg.FileName;
            }

        

        }
        /// <summary>
        /// Handles the Click event of the btnRestaurar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBaseDeDatos.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Por Favor, seleccione una Base de Datos");
                    return;
                }


                if (txtRuta.Text.Length == 0)
                {
                    MessageBox.Show("Por favor, seleccione una ruta de un backup realizado anteriormente.");
                    return;
                }


                string checkBackFile = txtRuta.Text.Substring(Math.Max(0, txtRuta.Text.Length - 4));

                if (checkBackFile.ToUpper() != ".bak".ToUpper())
                {
                    MessageBox.Show("Por favor, debe seleccionar un archivo .bak para restaurar la base.");
                    return;
                }

                BLLBackupRestore bLLBackupRestore = new BLLBackupRestore();
                bLLBackupRestore.HacerRestore(cmbBaseDeDatos.Text, txtRuta.Text);

                this.MdiParent.Close();

                Usuario.Destructor();
                Idioma.Destructor();
                this.Dispose();
                this.Close();
                FrmLogin frm = new FrmLogin();
                frm.Show();

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
                    unaBitacora.formulario = this.Name; //poner el nombre de formulario bien

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
