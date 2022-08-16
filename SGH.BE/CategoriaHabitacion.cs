using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH.BE
{
    /// <summary>
    /// Clase Entidad de Negocio de la Categoria de Habitación
    /// </summary>
    public class CategoriaHabitacion
    {
        private int codCategoriaHabitacion;

        private string categoria;

        public int CodCategoriaHabitacion { get => codCategoriaHabitacion; set => codCategoriaHabitacion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
