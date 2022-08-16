using SGH.BE.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH.BE.CompositePermisos;
using SGH.BE.MultiIdioma;
using SGH.BLL;
using SGHv1._0.FormsHabitacion;
using SGHv1._0.FormsReservas;
using SGHv1._0.Administrador;
using DevExpress.Data.TreeList;
using SGH.BE;
using SGHv1._0.FormsServicios;
using SGHv1._0.FormsCuentas;
using SGHv1._0.LimpiezaHabitaciones;


namespace SGHv1._0
{

    /// <summary>
    /// Formulario para el Menú Principal
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmMenuPrincipal : Form,IObserver
    {
        /// <summary>
        /// Actualizars this instance.
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
        /// Initializes a new instance of the <see cref="FrmMenuPrincipal"/> class.
        /// </summary>
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(this);
        }


        /// <summary>
        /// Handles the Load event of the FrmMenuPrincipal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            MdiClient ctlMdi;

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMdi = (MdiClient)ctl;
                    ctlMdi.BackColor = this.BackColor;
                    ctlMdi.BackgroundImage = this.BackgroundImage;
                }
                catch (Exception ex)
                {
                 
                }

            }
            Usuario usuario = Usuario.Instancia;
            nombreUsuarioToolStripMenuItem.Text = usuario.Nombre;
            foreach (var permiso in usuario.Permisos)
            {
                switch (permiso.Nombre)
                {
                    case "Registrar Cliente": registrarClienteToolStripMenuItem.Enabled = true; break;
               
                

                    case "Modificar Cliente": modificarClienteToolStripMenuItem.Enabled = true; break;

               


              
                    case "Borrar Cliente": borrarClienteToolStripMenuItem.Enabled = true; break;
                    case "Ver Listado de Clientes": consultarClientesToolStripMenuItem.Enabled = true; break;



                    case "Bitacora": bitácoraToolStripMenuItem.Enabled = true; break;
                    case "Ver Listado Backups": verListadoBackupsToolStripMenuItem.Enabled = true; break;
                    case "Gestion De Cambios": gestiónDeCambiosToolStripMenuItem.Enabled = true; break; 

                    case "Ver Log del Sistema": bitácoraToolStripMenuItem.Enabled = true; break;
           
                    case "Registrar Usuario": registrarUsuarioToolStripMenuItem.Enabled = true; break;
                    case "Borrar Usuario": borrarUsuarioToolStripMenuItem.Enabled = true; break;
                    case "Modificar Usuario": modificarUsuarioToolStripMenuItem.Enabled = true; break;
                    case "Consultar Usuario": consultarUsuariosToolStripMenuItem.Enabled = true; break;
                    case "Asignar Roles Usuario": asignarRolesUsuarioToolStripMenuItem.Enabled = true; break;
                    case "Backup Restore": backupRestoreToolStripMenuItem.Enabled = true; break;
                    case "Cargar Reserva": administracionDeReservasToolStripMenuItem.Enabled = true; break;
                  
                    case "Ver Listado de Reservas": verListadoBackupsToolStripMenuItem.Enabled = Enabled; break;
                  
                    case "Check In": checkInToolStripMenuItem.Enabled = true; break;
                    
                        
                    case "Ganancias Generadas": verListadoVentasToolStripMenuItem.Enabled = true; break;

                    case "Administracion Habitaciones": administracionHabitacionesToolStripMenuItem.Enabled = true; break;
                    case "Gestion de Buffet": gestiónDeRoomServiceToolStripMenuItem.Enabled = true; break;
                    case "Gestion de Complementos": gestiónDeComplementosToolStripMenuItem.Enabled = true; break;
                    case "Ver Estado Cuentas Corrientes": verEstadoCuentasCorrientesToolStripMenuItem.Enabled = true; break;
                    case "Gestion de Limpieza Habitaciones": gestiónDeLimpiezaHabitacionesToolStripMenuItem.Enabled = true; break;
                    case "ABM MultiIdioma": aBMMultiIdiomaToolStripMenuItem.Enabled = true; break;
                    case "Cargar Servicio": cargarServicioToolStripMenuItem.Enabled = true; break;

           



                    // Agregado 17-8-2020. Agrupo los permisos por Perfil

                    //case "Administrador":
                    //    bitácoraToolStripMenuItem.Enabled = true;
                    //    backupRestoreToolStripMenuItem.Enabled = true;
                    //    asignarRolesUsuarioToolStripMenuItem.Enabled = true;
                    //    consultarUsuariosToolStripMenuItem.Enabled = true;
                    //    modificarUsuarioToolStripMenuItem.Enabled = true;
                    //    borrarUsuarioToolStripMenuItem.Enabled = true;
                    //    registrarUsuarioToolStripMenuItem.Enabled = true;
                    //    bitácoraToolStripMenuItem.Enabled = true;
                    //    verListadoBackupsToolStripMenuItem.Enabled = true;
                    //    consultarClientesToolStripMenuItem.Enabled = true;
                    //    borrarClienteToolStripMenuItem.Enabled = true;
                    //    registrarClienteToolStripMenuItem.Enabled = true;
                    //    modificarClienteToolStripMenuItem.Enabled = true; break;


                }
            }
        }

        /// <summary>
        /// Handles the Click event of the CerraSesiónToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CerraSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.Destructor();
            Idioma.Destructor();
            this.Dispose();
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();

        }
        /// <summary>
        /// Handles the Click event of the backupRestoreToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void backupRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

             Administrador.FrmBackupRestore frm = new Administrador.FrmBackupRestore();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm); 
            frm.Show();
            
        }
        /// <summary>
        /// Handles the Click event of the bitácoraToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador.Bitacora frm = new Administrador.Bitacora();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the multiIdiomaToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void multiIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarIdioma frm = new CambiarIdioma();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm); 
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the verListadoBackupsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void verListadoBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Administrador.FrmListadoBackupHistorico frm = new Administrador.FrmListadoBackupHistorico();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the registrarUsuarioToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador.RegistrarUsuario frm = new Administrador.RegistrarUsuario();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the borrarUsuarioToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void borrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador.FrmBorrarUsuario frm = new Administrador.FrmBorrarUsuario();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the modificarUsuarioToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador.FrmModificarUsuario frm = new Administrador.FrmModificarUsuario();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the consultarUsuariosToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador.FrmlistarUsuarios frm = new Administrador.FrmlistarUsuarios();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the asignarRolesUsuarioToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void asignarRolesUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador.Roles frm = new Administrador.Roles();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the registrarClienteToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente frm = new FrmRegistrarCliente();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the borrarClienteToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void borrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarBaja frm = new FrmRegistrarBaja();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the modificarClienteToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarCliente frm = new FrmModificarCliente();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the consultarClienteToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarClientes frm = new ListarClientes();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }

        private void categoriaHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

      

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// Handles the Click event of the CargarReservaToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CargarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministracionDeReservas frm = new FrmAdministracionDeReservas();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the AsignarRolesTreeViewToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
       

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void altaHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the aBMMultiIdiomaToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void aBMMultiIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIIdiomas frm = new GUIIdiomas();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();

            //ABMMultiIdioma frm = new ABMMultiIdioma();
            //frm.MdiParent = this;
            //Idioma idioma = Idioma.InstanciaIdioma;
            //idioma.RegistrarObserver(frm);
            //frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the administraciónHabitacionesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void administraciónHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministracionHabitaciones frm = new AdministracionHabitaciones();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the checkInToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn frm = new CheckIn();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the gestiónDeCambiosToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gestiónDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDeCambios frm = new GestionDeCambios();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the gestiónDeRoomServiceToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gestiónDeRoomServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoomService  frm = new FrmRoomService();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the gestiónDeComplementosToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gestiónDeComplementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicioComplementario frm = new FrmServicioComplementario();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the cargarServicioToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cargarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargarServicio frm = new FrmCargarServicio();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the verEstadoCuentasCorrientesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void verEstadoCuentasCorrientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerEstadoCuentaHabitaciones frm = new FrmVerEstadoCuentaHabitaciones();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the gestiónDeLimpiezaHabitacionesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gestiónDeLimpiezaHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionLimpiezaHabitaciones frm = new GestionLimpiezaHabitaciones();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
        /// <summary>
        /// Handles the Click event of the verListadoVentasToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void verListadoVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.GananciasGeneradas frm = new Reportes.GananciasGeneradas();
            frm.MdiParent = this;
            Idioma idioma = Idioma.InstanciaIdioma;
            idioma.RegistrarObserver(frm);
            frm.Show();
        }
    }
}
