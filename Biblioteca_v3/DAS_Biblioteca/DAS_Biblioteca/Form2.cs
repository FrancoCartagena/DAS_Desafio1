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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Cargamos el listado de los libro
            llenarLibros();

            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // desbloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = true;
            txtBoxAutor.Enabled = true;
            txtBoxIsbn.Enabled = true;
            btnCancelar.Enabled = true;
            btnSaveNewBook.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnSaveNewBook_Click(object sender, EventArgs e)
        {
            string tit = txtBoxTitulo.Text;
            string au = txtBoxAutor.Text;
            string isb = txtBoxIsbn.Text;
            DatosGlobales.Libros.Add(new Libros(tit, au, isb));

            llenarLibros();

            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void llenarLibros()
        {
            dataGridView1.Rows.Clear();

            int i = 0;
            foreach (var libro in DatosGlobales.Libros)
            {
                dataGridView1.Rows.Add(i, libro.GetTitulo(), libro.GetAutor(), libro.GetISBN());
                i++;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;

            // Habilitamos la informacion a consultar

        }
    }
}
