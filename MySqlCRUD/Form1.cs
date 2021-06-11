using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlCRUD.CapaNegocio;

namespace MySqlCRUD
{
    public partial class Form1 : Form
    {


        Libro libroo = new Libro();
        Autor autorr = new Autor();
        Prestamo prestamoo = new Prestamo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string codLibro = txtCod.Text;
            string titulo = txtTit.Text;
            string editorial = txtEdi.Text;
            bool CodError = libroo.Agregar(codLibro, titulo, editorial);
            Clear();
            dgvBook.DataSource = libroo.Listar();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            dgvBook.DataSource = libroo.Listar();
            dgvAutor.DataSource = autorr.ListarAutor();
            dgvPrestamo.DataSource = prestamoo.ListarPrestamo();
        }

        void Clear()
        {
            txtCod.Text = txtTit.Text = txtEdi.Text = txtSearch.Text = "";
            btnGuardar.Text = "Guardar";
            btnDelete.Enabled = true;
        }

        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            //if (dgvBook.CurrentRow.Index != -1)
            //{
            //    txtCod.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            //    txtTit.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            //    txtEdi.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            //    btnGuardar.Text = "Actualizar";
            //    btnDelete.Enabled = Enabled;
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string texto = txtSearch.Text;
            dgvBook.DataSource = libroo.Buscar(texto);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string codLibro = txtCod.Text;
            bool codError = libroo.Eliminar(codLibro);
            Clear();
            dgvBook.DataSource = libroo.Listar();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBook.DataSource = libroo.Listar();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void raea_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {//buscar_autor
            string texto = txtAutorBuscar.Text;
            dgvAutor.DataSource = autorr.BuscarAutor(texto);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAutor.DataSource = autorr.ListarAutor();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            string codautor = txtcoda.Text;
            string nombres = txtnombrea.Text;
            string apellidos = txtapellidoa.Text;
            string nacionalidad = txtnacionalidada.Text;
            bool CodError = autorr.AgregarAutor(codautor, nombres, nacionalidad, apellidos );
            Clear();
            dgvAutor.DataSource = autorr.ListarAutor();
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            string texto = txtbuscarp.Text;
            dgvPrestamo.DataSource = prestamoo.BuscarPrestamo(texto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codAutor = txtcoda.Text;
            bool codError = autorr.EliminarAutor(codAutor);
            Clear();
            dgvAutor.DataSource = autorr.ListarAutor();
        }

        private void btnAgregarp_Click(object sender, EventArgs e)
        {
            string codPres = txtcodp.Text;
            string codautorp = txtcodap.Text;
            string codlibrop = txtcodlp.Text;
            
            bool CodError = prestamoo.AgregarPrestamo(codPres, codautorp, codlibrop);
            Clear();
            dgvPrestamo.DataSource = prestamoo.ListarPrestamo();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            string codPres = txtcodp.Text;
            string codautorp = txtcodap.Text;
            string codlibrop = txtcodlp.Text;
            bool codError = prestamoo.EliminarPrestamo(codPres, codlibrop,codautorp);
            Clear();
            dgvPrestamo.DataSource = prestamoo.ListarPrestamo();
        }
    }
}
