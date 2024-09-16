using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;

namespace DAS_Biblioteca
{
    public class Prestamos
    {
        private Usuarios    User { get; set; }
        private Libros      Libro { get; set; }
        private DateTime FechaPrestamo { get; set; }
        private DateTime FechaDevolucion { get; set; }

        private bool PrestamoActivo { get; set; }

        // Constructor general
        public Prestamos(Usuarios us, Libros li, DateTime fp)
        {
            User = us;
            Libro = li;
            FechaPrestamo = fp;

            PrestamoActivo = true;
        }

        public Usuarios GetUsuario()
        {
            return User;
        }

        public Libros GetLibro()
        {
            return Libro;
        }

        public DateTime GetFechaPrestamo()
        { return FechaPrestamo; }

        public bool GetPrestamoActivo()
        {
            return PrestamoActivo;
        }

        public void SetDevolucion(DateTime fd)
        {
            FechaDevolucion = fd;
            PrestamoActivo = false;
        }
        


    }
}
