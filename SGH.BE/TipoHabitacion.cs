using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase de Entidad de Negocio perteneciente a Tipo de Habitación
    /// </summary>
    public class TipoHabitacion
    {
        private int codTipoHabitacion;

        private string tipo;

        public int CodTipoHabitacion { get => codTipoHabitacion; set => codTipoHabitacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
