using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV01.UI.Clases
{
    public class Respuesta<T>
    {
        public int codigo { get; set; }
        public string mensaje { get; set; }
        public string mensajeError { get; set; }
        public int totalRegistro { get; set; }
        public T data { get; set; }
    }
}
