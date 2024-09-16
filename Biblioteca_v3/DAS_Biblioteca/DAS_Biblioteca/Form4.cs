using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Biblioteca
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            llenarPrestamo();
        }

        private void llenarPrestamo()
        {

            string username;

            lstLibros.Items.Clear();
            foreach (var libro in DatosGlobales.Libros)
            {
                if (libro.GetLibre())
                {
                    lstLibros.Items.Add(libro.GetTitulo());
                }
                
            }

            lstUsuarios.Items.Clear();
            foreach (var usuario in DatosGlobales.Usuarios)
            {
                username = usuario.GetNombre() + " " + usuario.GetApellido();
                lstUsuarios.Items.Add(username);
            }

            // Cuadro de prestamos
            dataGridView1.Rows.Clear();

            int i = 0;
            foreach (var prestamo in DatosGlobales.Prestamos)
            {
                if (prestamo.GetPrestamoActivo())
                {
                    Usuarios us = prestamo.GetUsuario();
                    Libros lb = prestamo.GetLibro();
                    DateTime fp = prestamo.GetFechaPrestamo();

                    dataGridView1.Rows.Add(i, us.NombreCompleto(), lb.GetTitulo(), fp.ToString());
                    i++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validamos que este seleccionado
            int selectedLibro = lstLibros.SelectedIndex;
            int selectedUsuario = lstUsuarios.SelectedIndex;
            DateTime dt = dtpFechaPrestamo.Value;

            if ( (selectedLibro != -1) && (selectedUsuario != -1))
            {
                //MessageBox.Show(selectedUsuario + " "+ selectedLibro);
                DatosGlobales.Prestamos.Add(new Prestamos(DatosGlobales.Usuarios[selectedUsuario], DatosGlobales.Libros[selectedLibro], dt ));
                DatosGlobales.Libros[selectedLibro].SetPrestar(DatosGlobales.Usuarios[selectedUsuario]);
            }

            llenarPrestamo();
        }

        
    }
}
