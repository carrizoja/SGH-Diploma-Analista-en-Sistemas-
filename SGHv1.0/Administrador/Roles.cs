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
    /// Formulario para la asignación de Roles y permisos
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class Roles : Form, IObserver
    {
        Usuario _nuevoUsuario = new Usuario();
        private List<Patente> _idsPermisosSeleccionadosDeUsuario = new List<Patente>();
        private List<Patente> _idsPermisosSeleccionadosDeUsuarioNoAsignados = new List<Patente>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Roles"/> class.
        /// </summary>
        public Roles()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Load event of the FrmRoles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmRoles_Load(object sender, EventArgs e)
        {
            try
            {
                BLLIdioma _traduccion = new BLLIdioma();
                Idioma idioma = Idioma.InstanciaIdioma;
                Form form = this;
                _traduccion.Traducir(idioma.IdIdioma, form);

                BLLUsuario bLLUsuario = new BLLUsuario();
                List<Permiso> _permisosRoles = new List<Permiso>();
                var _rolesParaAgregar = bLLUsuario.TraerRolesParaAgregar();

                foreach (var item in _rolesParaAgregar)
                {
                    comboBoxPermisosCompuestos.Items.Add(item);
                    comboBoxPermisosCompuestos.DisplayMember = "Nombre";
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
        /// Handles the Click event of the bntAceptar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bntAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _nuevoUsuario.Permisos.Clear();
                _idsPermisosSeleccionadosDeUsuario.Clear();
                _idsPermisosSeleccionadosDeUsuarioNoAsignados.Clear();
                lstPermisosSimples.Clear();
                lstPermisosSimples2.Clear();
                lstPermisosAsignados.Clear();

                BLLUsuario bLLUsuario = new BLLUsuario();
                string nombreUsuario = bLLUsuario.TraerUsuario(txtDni.Text);
                if (nombreUsuario == "NO")
                {
                    MessageBox.Show("No existe un Usuario con ese DNI");
                    return;
                }
                else
                {
                    txtNombreUsuario.Text = nombreUsuario;
                }



                List<Patente> _leafPermisos = bLLUsuario.TraerPermisoUsuario(txtDni.Text);

                foreach (var item in _leafPermisos)
                {
                    lstPermisosAsignados.Items.Add(item.Nombre);
                    _idsPermisosSeleccionadosDeUsuario.Add(item);
                }
                //alf begin
                Familia permisosParaUsuario = new Familia();

                foreach (var item in _leafPermisos)
                {
                    permisosParaUsuario.AgregarComponente(item);
                }

                _nuevoUsuario.Permisos.Clear();

                _nuevoUsuario.Permisos.Add(permisosParaUsuario);
                //alf end
                List<Patente> _leafPermisos2 = bLLUsuario.TraerPermisoUsuarioQueNoTieneAsignados(txtDni.Text);

                foreach (var item in _leafPermisos2)
                {
                    lstPermisosSimples2.Items.Add(item.Nombre);
                    _idsPermisosSeleccionadosDeUsuarioNoAsignados.Add(item);
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
        /// <summary>
        /// Actualiza this instance.
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
        /// Handles the Click event of the txtAgregarPermisoSimple control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtAgregarPermisoSimple_Click(object sender, EventArgs e)
        {
            try
            {
                var permisosSimplesSeleccionados = lstPermisosSimples2.SelectedItems;
                List<Object> cccc = new List<Object>();
                BLLUsuario bLLUsuario = new BLLUsuario();

                foreach (var item in _idsPermisosSeleccionadosDeUsuarioNoAsignados)
                {
                    foreach (var secondItem in permisosSimplesSeleccionados)
                    {
                        if (item.Nombre == ((System.Windows.Forms.ListViewItem)secondItem).Text)
                        {
                            //alf begin
                            Familia permisosParaUsuario = new Familia();

                            permisosParaUsuario.AgregarComponente(item);

                            _nuevoUsuario.Permisos.Add(permisosParaUsuario);


                        }
                    }
                }

                bLLUsuario.AgregarPermiso(_nuevoUsuario, txtDni.Text);

                //ALF BEGIN
                lstPermisosAsignados.Clear();
                lstPermisosSimples2.Clear();
                _idsPermisosSeleccionadosDeUsuario.Clear();
                _idsPermisosSeleccionadosDeUsuarioNoAsignados.Clear();

                //foreach(var item in _idsPermisosSeleccionadosDeUsuario)
                //{
                //    _idsPermisosSeleccionadosDeUsuario.Remove(item);
                //}

                //foreach (var item2 in _idsPermisosSeleccionadosDeUsuarioNoAsignados)
                //{
                //    _idsPermisosSeleccionadosDeUsuarioNoAsignados.Remove(item2);
                //}



                List<Patente> _leafPermisos = bLLUsuario.TraerPermisoUsuario(txtDni.Text);

                foreach (var item in _leafPermisos)
                {
                    lstPermisosAsignados.Items.Add(item.Nombre);
                    _idsPermisosSeleccionadosDeUsuario.Add(item);
                }

                List<Patente> _leafPermisos2 = bLLUsuario.TraerPermisoUsuarioQueNoTieneAsignados(txtDni.Text);

                foreach (var item in _leafPermisos2)
                {
                    lstPermisosSimples2.Items.Add(item.Nombre);
                    _idsPermisosSeleccionadosDeUsuarioNoAsignados.Add(item);
                }

                //ALF END


                MessageBox.Show("Se Asigno el Nuevo Permiso con éxito");
                Usuario _usuario = Usuario.Instancia;
                var unaBitacora = new SGH.BE.Bitacora();
                unaBitacora.fecha = DateTime.UtcNow;
                unaBitacora.descripcion = "Permiso Agregado con éxito";
                unaBitacora.usuario = _usuario;
                unaBitacora.formulario = this.Name;

                BLLBitacora bitacoraIngles = new BLLBitacora();
                bitacoraIngles.GrabarBitacora(unaBitacora);

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
        /// Handles the SelectedIndexChanged event of the comboBoxPermisosCompuestos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void comboBoxPermisosCompuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPermisosSimples.Clear();
            _idsPermisosSeleccionadosDeUsuario.Clear();

            BLLUsuario bLLUsuario = new BLLUsuario();
            int index_ = comboBoxPermisosCompuestos.SelectedIndex;
            string idSelected = ((SGH.BE.CompositePermisos.Permiso)comboBoxPermisosCompuestos.Items[index_]).IdPermiso.ToString();
            List<Patente> _leafPermisos = bLLUsuario.TraerPermisoSimples(idSelected);


            foreach (var item in _leafPermisos)
            {
                lstPermisosSimples.Items.Add(item.Nombre);
                _idsPermisosSeleccionadosDeUsuario.Add(item);
            }
        }
        /// <summary>
        /// Handles the Click event of the btnCambioRolusuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCambioRolusuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDni.Text == "")
                {
                    if (txtNombreUsuario.Text == "")
                    {
                        MessageBox.Show("Por favor, primero seleccione un usuario mediante su DNI para asignar un Rol");
                        return;
                    }
                }

                if (comboBoxPermisosCompuestos.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un conjunto de permisos para poder asignar");
                    return;
                }


                if (_nuevoUsuario.Permisos.Count == 1)
                {
                    _nuevoUsuario.Permisos.RemoveAt(0);
                }

                Familia permisosParaUsuario = new Familia();
                int index_ = comboBoxPermisosCompuestos.SelectedIndex;
                permisosParaUsuario.IdPermiso = ((SGH.BE.CompositePermisos.Permiso)comboBoxPermisosCompuestos.Items[index_]).IdPermiso;
                permisosParaUsuario.Nombre = comboBoxPermisosCompuestos.Text;

                foreach (var item in _idsPermisosSeleccionadosDeUsuario)
                {
                    permisosParaUsuario.AgregarComponente(item);
                }

                _idsPermisosSeleccionadosDeUsuario.Clear();
                _idsPermisosSeleccionadosDeUsuarioNoAsignados.Clear();

                _nuevoUsuario.Permisos.Clear();

                _nuevoUsuario.Permisos.Add(permisosParaUsuario);

                BLLUsuario bLLUsuario = new BLLUsuario();
                bLLUsuario.AgregarRol(_nuevoUsuario, txtDni.Text);


                //ALF BEGIN
                lstPermisosAsignados.Clear();
                lstPermisosSimples2.Clear();


                List<Patente> _leafPermisos = bLLUsuario.TraerPermisoUsuario(txtDni.Text);

                foreach (var item in _leafPermisos)
                {
                    lstPermisosAsignados.Items.Add(item.Nombre);
                    _idsPermisosSeleccionadosDeUsuario.Add(item);
                }

                List<Patente> _leafPermisos2 = bLLUsuario.TraerPermisoUsuarioQueNoTieneAsignados(txtDni.Text);

                foreach (var item in _leafPermisos2)
                {
                    lstPermisosSimples2.Items.Add(item.Nombre);
                    _idsPermisosSeleccionadosDeUsuarioNoAsignados.Add(item);
                }

                //ALF END


                MessageBox.Show("Se Asigno el Nuevo Rol con éxito");


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

        private void LstPermisosAsignados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblIngreseDniusuario_Click(object sender, EventArgs e)
        {

        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
