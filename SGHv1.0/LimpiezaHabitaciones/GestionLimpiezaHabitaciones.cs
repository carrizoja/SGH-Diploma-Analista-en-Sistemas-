using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SGH.BLL;
using SGH.BE.Observer;
using SGH.BE.MultiIdioma;
using SGH.BE;
using SGH.BE.CompositePermisos;
using SGH.DAL;



namespace SGHv1._0.LimpiezaHabitaciones
{
    /// <summary>
    /// Formulario para la Gestión de Limpieza. Se implementó Entity Framework
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class GestionLimpiezaHabitaciones : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GestionLimpiezaHabitaciones"/> class.
        /// </summary>
        public GestionLimpiezaHabitaciones()
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
        /// Handles the Load event of the GestionLimpiezaHabitaciones control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GestionLimpiezaHabitaciones_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "GestiondeLimpiezaHabitaciones");
            helpProvider1.SetHelpKeyword(this, "GestiondeLimpiezaHabitaciones");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

            LimpiarFormulario();
         




        }
        /// <summary>
        /// Limpiar formulario.
        /// </summary>
        void LimpiarFormulario()
        {
            cmbEmpleadosLimpieza.Visible = true;
            using (SGHEntities db = new SGHEntities())
            {
                var emp = from EmpleadoLimpieza in db.EmpleadoLimpieza
                          select EmpleadoLimpieza;
                cmbEmpleadosLimpieza.DataSource = emp.ToList();
                cmbEmpleadosLimpieza.ValueMember = "IdEmpleadoLimpieza";
                cmbEmpleadosLimpieza.DisplayMember = "Nombre";
            }


            using (SGHEntities db = new SGHEntities())
            {
                var hab = from HabitacionLimpieza in db.HabitacionesLimpieza
                          select HabitacionLimpieza;
                dgvHabitaciones.DataSource = hab.ToList();
                dgvHabitaciones.Columns[0].Visible = false;
            
                dgvHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

            using (SGHEntities db = new SGHEntities())
            {
                var planilla = from VistaPlanillaLimpieza in db.VistaPlanillaLimpieza
                               select VistaPlanillaLimpieza;
                dgvPlanilla.DataSource = planilla.ToList();
                dgvPlanilla.Columns[0].Visible = false;
                //dgvHabitaciones.Columns[2].Visible = false;
                //dgvHabitaciones.Columns[3].Visible = false;
                //dgvHabitaciones.Columns[4].Visible = false;
                dgvPlanilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

        }

        private void cmbEmpleadosLimpieza_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Handles the Click event of the btnSalir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            cmbEmpleadosLimpieza.Enabled = false;
        }
        /// <summary>
        /// Handles the Click event of the btnAgregarHabitacion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                PlanillaLimpieza planilla = new PlanillaLimpieza();

                using (SGHEntities db = new SGHEntities())
                {
                    planilla.IdPlanillaLimpieza = new int();
                    planilla.IdHabitacion = Convert.ToInt32(dgvHabitaciones.CurrentRow.Cells[0].Value);
                    planilla.IdEmpleadoLimpieza = Convert.ToInt32(cmbEmpleadosLimpieza.SelectedValue);
                    planilla.FechaCarga = DateTime.Now;
                    planilla.EstaAsignada = true;
                    db.PlanillaLimpieza.Add(planilla);
                    
                    db.SaveChanges();
                    MessageBox.Show("Habitación Cargada Exitosamente");
                }
                LimpiarFormulario();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }




        }
        /// <summary>
        /// Handles the Click event of the btnBorrarSeleccionada control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBorrarSeleccionada_Click(object sender, EventArgs e)
        {
            try
            {
               if (dgvPlanilla.CurrentRow.Index != -1)
               {
                    if (MessageBox.Show("¿Esta seguro de eliminar?", "Eliminación de Planilla", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //PlanillaLimpieza planillaLimpieza = new PlanillaLimpieza();
                        int idPlanilla = Convert.ToInt32(dgvPlanilla.CurrentRow.Cells[0].Value);
                        using (SGHEntities db = new SGHEntities())
                        {
                            PlanillaLimpieza pl = (from r in db.PlanillaLimpieza where r.IdPlanillaLimpieza == idPlanilla select r).SingleOrDefault();
                            db.PlanillaLimpieza.Remove(pl);
                            db.SaveChanges();
                            MessageBox.Show("Se ha borrado la planilla de forma correcta");
                            LimpiarFormulario();
                        }
                    }
                    LimpiarFormulario();
               }
                 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }

        private void dgvPlanilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
