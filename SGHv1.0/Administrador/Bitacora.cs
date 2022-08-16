using SGH.BE;
using SGH.BE.CompositePermisos;
using SGH.BE.MultiIdioma;
using SGH.BE.Observer;
using SGH.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SGHv1._0.Administrador
{
    /// <summary>
    /// Form de la Bitácora
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class Bitacora : Form, IObserver
    {
        Idioma idioma = Idioma.InstanciaIdioma;
        List<SGH.BE.BitacoraDatos> listaBitacora = new List<SGH.BE.BitacoraDatos>();
        /// <summary>
        /// Initializes a new instance of the <see cref="Bitacora"/> class.
        /// </summary>
        public Bitacora()
        {
            InitializeComponent();
            idioma.RegistrarObserver(this);
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
        /// Handles the Load event of the FrmBitacora control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);
            cmbFormulario.Text = " ";
            cmbUsuarios.Text = " ";
            lstwBitacora.View = View.Details;
            lstwBitacora.FullRowSelect = true;
            lstwBitacora.MultiSelect = false;

            lstwBitacora.Columns.Add("Usuario", 200);
            lstwBitacora.Columns.Add("Formulario", 200);
            lstwBitacora.Columns.Add("Fecha", 150);
            lstwBitacora.Columns.Add("Descripcion", 200);

            BLLBitacora bLLBitacora = new BLLBitacora(); //arreglar esto 
            List<BitacoraDatos> resultadoBitacora = bLLBitacora.TraerBitacoras();
            listaBitacora = resultadoBitacora;
            ///<summary>
            /// Traigo a todos los Usuarios
            /// </summary>

           

            traerCombos();

          
            foreach (var item in resultadoBitacora)
            {
                String[] row = { item.Usuario, item.Formulario, item.Fecha.ToString(), item.Descripcion };

                ListViewItem item2 = new ListViewItem(row);

                lstwBitacora.Items.Add(item2);

            }



        }
        /// <summary>
        /// Handles the FormClosing event of the FrmBitacora control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void FrmBitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            idioma.SacarRegistroObserver(this);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnLimpiar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            lstwBitacora.Clear();
            dtpDesde.ResetText();
            dtpHasta.ResetText();
            cmbFormulario.SelectedIndex = -1;
            cmbUsuarios.SelectedIndex = -1;
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
        /// <summary>
        /// Handles the CloseUp event of the dtpHasta control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dtpHasta_CloseUp(object sender, EventArgs e)
        {
            DateTime fechaDesde = Convert.ToDateTime(dtpDesde.Text);
            DateTime fechaHasta = Convert.ToDateTime(dtpHasta.Text);
            if (fechaDesde <= fechaHasta)
            {
                DateTime horaActual = DateTime.Now;
                if (fechaHasta <= horaActual)
                {
                    TimeSpan ts = fechaHasta.Subtract(fechaDesde);
                    int dias = Convert.ToInt16(ts.Days);
                    MessageBox.Show("Se ha seleccionado un filtro de fecha para " + ts.Days + " dias");
                }
                else MessageBox.Show("La fecha no puede ser mayor a la fecha actual");
            }
                
            
            else
            {
                MessageBox.Show("La fecha de Egreso debe ser superior a la de Ingreso");
            }
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbFormulario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbFormulario_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFormulario.Text = cmbFormulario.SelectedItem.ToString();

        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbUsuarios control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usuarioSeleccionado = cmbUsuarios.Text;
            BLLUsuario bLLUsuario = new BLLUsuario();
            List<Usuario> _usuarios = new List<Usuario>();
            List<Usuario> datosUsuario = bLLUsuario.TraerUsuarioPorNombre(usuarioSeleccionado);


            foreach (var item0 in datosUsuario)
            {

                lblUsuarioID.Text = item0.IdUsuario.ToString();
               
               
            }
            
        }
        /// <summary>
        /// Handles the Click event of the btnFiltrar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                lstwBitacora.Clear();
                lstwBitacora.View = View.Details;
                lstwBitacora.FullRowSelect = true;
                lstwBitacora.MultiSelect = false;

                lstwBitacora.Columns.Add("Usuario", 200);
                lstwBitacora.Columns.Add("Formulario", 200);
                lstwBitacora.Columns.Add("Fecha", 150);
                lstwBitacora.Columns.Add("Descripcion", 200);

                if (cmbUsuarios.SelectedIndex >=0)
                {
                    Usuario unUsuario = new Usuario();
                    unUsuario.IdUsuario = new Guid(lblUsuarioID.Text);
                    if ((dtpDesde.Checked) && (dtpHasta.Checked) && (cmbUsuarios.SelectedIndex >= 0) && (cmbFormulario.SelectedIndex >= 0))
                    {

                        BLLBitacora bLLBitacora = new BLLBitacora();
                        List<BitacoraDatos> resultadoBitacora = bLLBitacora.TraerBitacoras(unUsuario, lblFormulario.Text, dtpDesde.Value, dtpHasta.Value);
                        foreach (var item in resultadoBitacora)
                        {
                            String[] row = { item.Usuario, item.Formulario, item.Fecha.ToString(), item.Descripcion };

                            ListViewItem item2 = new ListViewItem(row);

                            lstwBitacora.Items.Add(item2);

                        }
                        listaBitacora = resultadoBitacora;
                        limpiarCombos();
                        traerCombos();
                    }
                    else if ((dtpDesde.Checked) && (dtpHasta.Checked))
                    {
                        BLLBitacora bLLBitacora = new BLLBitacora();
                        List<BitacoraDatos> resultadoBitacora = bLLBitacora.TraerBitacoras(unUsuario, dtpDesde.Value, dtpHasta.Value);
                        foreach (var item in resultadoBitacora)
                        {
                            String[] row = { item.Usuario, item.Formulario, item.Fecha.ToString(), item.Descripcion };

                            ListViewItem item2 = new ListViewItem(row);

                            lstwBitacora.Items.Add(item2);

                        }
                        listaBitacora = resultadoBitacora;
                        limpiarCombos();
                        traerCombos();
                    }
                    else MessageBox.Show(" No eligió un criterio de filtro válido");
                }
                
               
                else if ((dtpDesde.Checked) && (dtpHasta.Checked)  && (cmbFormulario.SelectedIndex >= 0))
                {
                    BLLBitacora bLLBitacora = new BLLBitacora();
                    List<BitacoraDatos> resultadoBitacora = bLLBitacora.TraerBitacoras(lblFormulario.Text, dtpDesde.Value, dtpHasta.Value);
                    foreach (var item in resultadoBitacora)
                    {
                        String[] row = { item.Usuario, item.Formulario, item.Fecha.ToString(), item.Descripcion };

                        ListViewItem item2 = new ListViewItem(row);

                        lstwBitacora.Items.Add(item2);

                    }
                    listaBitacora = resultadoBitacora;
                    limpiarCombos();
                    traerCombos();
                }
                else if ((dtpDesde.Checked) && (dtpHasta.Checked))
                {
                    BLLBitacora bLLBitacora = new BLLBitacora();
                    List<BitacoraDatos> resultadoBitacora = bLLBitacora.TraerBitacoras(dtpDesde.Value, dtpHasta.Value);
                    foreach (var item in resultadoBitacora)
                    {
                        String[] row = { item.Usuario, item.Formulario, item.Fecha.ToString(), item.Descripcion };

                        ListViewItem item2 = new ListViewItem(row);

                        lstwBitacora.Items.Add(item2);

                    }
                    listaBitacora = resultadoBitacora;
                    limpiarCombos();
                    traerCombos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
           
        }
        /// <summary>
        /// Trae combos.
        /// </summary>
        void traerCombos()
        {
            BLLBitacora bLLBitacora = new BLLBitacora();
            BLLUsuario bllUsuario = new BLLUsuario();
            //List<Usuario> _usuarios = new List<Usuario>();
            var _usuariosAgregar = bllUsuario.TraerTodosLosUsuarios();
            foreach (var itemsUsuario in _usuariosAgregar)
            {
                cmbUsuarios.Items.Add(itemsUsuario.Nombre);
                cmbUsuarios.DisplayMember = "Nombre Usuario";
            }

            var _formulariosAgregar = bLLBitacora.TraerFormulariosBitacora();

            foreach (var itemsBitacora in _formulariosAgregar)
            {
                cmbFormulario.Items.Add(itemsBitacora.Formulario);
                cmbFormulario.DisplayMember = "Nombre Formulario";
            }
        }
        /// <summary>
        /// Limpia combos.
        /// </summary>
        void limpiarCombos()
        {
            cmbUsuarios.Text = " ";
            cmbFormulario.Text = " ";
            cmbFormulario.Items.Clear();
            cmbUsuarios.Items.Clear();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnRuta control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRuta_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtRuta.Text = openFileDialog1.FileName;
        }
        /// <summary>
        /// Handles the Click event of the btnSerializar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSerializar_Click(object sender, EventArgs e)
        {
            if (rbBinario.Checked)
            {
                using (FileStream stream = new FileStream("Bitacora.txt", FileMode.Create))
                {
                    BinaryFormatter Formatter = new BinaryFormatter();
                    Formatter.Serialize(stream, listaBitacora);
                    stream.Close();
                    MessageBox.Show("Se ha generado correctamente el archivo Bitacora.txt en GUI/BIN/Debug");
                }
            }
            else if (rbXML.Checked)
            {
                using (FileStream stream = new FileStream("BitacoraXml.txt", FileMode.Create))
                {
                    XmlSerializer Serializer = new XmlSerializer(listaBitacora.GetType());
                    Serializer.Serialize(stream, listaBitacora);
                    stream.Close();
                    MessageBox.Show("Se ha generado correctamente el archivo BitacoraXml.txt en GUI/BIN/Debug");
                }
            }
            else if (rbSOAP.Checked)
            {
                //using (FileStream stream = new FileStream("EmpleadoSoap.txt", FileMode.Create))
                //{
                //    SoapFormatter Formatter = new SoapFormatter();
                //    Formatter.Serialize(stream, listaBitacora);
                //    stream.Close();
                //}
            }
            else
            {
                using (StreamWriter stream = new StreamWriter("BitacoraJson.txt", false))
                {
                    string strEmp = JsonConvert.SerializeObject(listaBitacora);
                    stream.Write(strEmp);
                    stream.Close();
                    MessageBox.Show("Se ha generado correctamente el archivo BitacoraJson.txt en GUI/BIN/Debug");
                }
            }
        }
        /// <summary>
        /// Handles the Click event of the btnDeserializar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            List<BitacoraDatos> bitacoraLista = null;
            if (rbBinario.Checked)
            {
                using (FileStream stream = new FileStream(txtRuta.Text, FileMode.Open))
                {
                    BinaryFormatter Formatter = new BinaryFormatter();
                    bitacoraLista = (List<BitacoraDatos>)Formatter.Deserialize(stream);
                    stream.Close();
                }

            }
            else if (rbXML.Checked)
            {
                using (FileStream stream = new FileStream(txtRuta.Text, FileMode.Open))
                {
                    XmlSerializer Serializer = new XmlSerializer(typeof(List<BitacoraDatos>));
                    bitacoraLista = (List<BitacoraDatos>)Serializer.Deserialize(stream);
                    stream.Close();
                }
            }
            else if (rbSOAP.Checked)
            {
                //using (FileStream stream = new FileStream(txtRuta.Text, FileMode.Open))
                //{
                //    SoapFormatter Formatter = new SoapFormatter();
                //    Emp = (Empleado)Formatter.Deserialize(stream);
                //    stream.Close();
                //}
            }
            else //Deserialize JSON
            {
                using (StreamReader stream = new StreamReader(txtRuta.Text))
                {
                    string strEmp = stream.ReadToEnd();
                    bitacoraLista = JsonConvert.DeserializeObject<List<BitacoraDatos>>(strEmp);
                }
            }
            //string bitacoraString = "===== Bitacora ==========" + Environment.NewLine +
            //    "Usuario: " + bitacoraLista. + " Apellido: " + Emp.Apellido +
            //    " ID: " + Emp.ID + " Ingreso: " + Emp.Ingreso + Environment.NewLine +
            //    "=========================";
            //MessageBox.Show(Empleado);
        }
    }
}
