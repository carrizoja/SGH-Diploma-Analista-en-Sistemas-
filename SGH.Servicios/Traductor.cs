using SGH.BE.MultiIdioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SGH.Servicios
{
    /// <summary>
    /// Clase encargada de la traducción de los controles y tags
    /// </summary>
    public class Traductor
    {
        /// <summary>
        /// Cambia idioma.
        /// </summary>
        /// <param name="thisForm">The this form.</param>
        /// <param name="idioma">The idioma.</param>
        public static void CambiarIdioma(Form thisForm, List<ControlIdioma> idioma)
         {
            foreach (Control control in thisForm.Controls)
            {
                foreach (var item in idioma)
                {
                    if (control is MenuStrip)
                    {
                        foreach (var itemMenuStrip in ((System.Windows.Forms.ToolStrip)control).Items)
                        {
                            if (((System.Windows.Forms.ToolStripItem)itemMenuStrip).Tag != null)
                            {
                                if (((System.Windows.Forms.ToolStripItem)itemMenuStrip).Tag.ToString() == item.NombreOriginal.ToString())
                                {
                                    ((System.Windows.Forms.ToolStripItem)itemMenuStrip).Text = item.NombreTraducido;
                                }
                                foreach (var itemKid in ((System.Windows.Forms.ToolStripDropDownItem)((System.Windows.Forms.ToolStripItem)itemMenuStrip)).DropDownItems)
                                {
                                    if (((System.Windows.Forms.ToolStripItem)itemKid).Tag.ToString() == item.NombreOriginal.ToString())
                                    {
                                        ((System.Windows.Forms.ToolStripItem)itemKid).Text = item.NombreTraducido;
                                    }
                                }
                            }



                        }
                    }
                    else
                    {
                        if (control.Tag != null)
                        {
                            if (control.Tag.ToString() == item.NombreOriginal.ToString())
                            {
                                control.Text = item.NombreTraducido;
                            }
                        }
                    }
                }
            }
        }

      
    }

}

