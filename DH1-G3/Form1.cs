using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH1_G3
{
    public partial class Form1 : Form
    {
        private List<cliente> Clientes= new List<cliente>();
        private int indice=-1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tipos de cuentas de los clientes
            cbCuenta.Items.Clear();
            cbCuenta.Items.Add("Ahorro");
            cbCuenta.Items.Add("Corriente");
            cbCuenta.Items.Add("Plazos");

            ///Sucursales 
            cbSucursal.Items.Clear();
            cbSucursal.Items.Add("Soyapango");
            cbSucursal.Items.Add("San Salvador");
            cbSucursal.Items.Add("San Martin");
            cbSucursal.Items.Add("Cojutepeque");
            cbSucursal.Items.Add("Suchitoto");
        }

        ///Metodo actualizar 
        private void actualizarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Clientes;
        }

        /// Limpiar Campos
        private void limpiar()
        {
            txtApellido.Clear();
            txtCodigo.Clear();
            txtDui.Clear();
            txtMonto.Clear();
            txtNIT.Clear();
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgvClientes.SelectedRows[0];
            indice = dgvClientes.Rows.IndexOf(seleccion);
            cliente client = Clientes[indice];

            txtApellido.Text = client.Apellido;
            txtCodigo.Text = client.Codigo;
            txtDui.Text = client.Dui;
            txtMonto.Text = client.Monto.ToString();
            txtNIT.Text = client.Nit;
            txtNombre.Text = client.Nombre;
            cbCuenta.Text = client.TipoCuenta;
            cbSucursal.Text = client.Sucursal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Objeto que capturara los valores ingresados
            cliente client = new cliente();
            client.Dui = txtDui.Text;
            client.Nombre = txtNombre.Text;
            client.Apellido = txtApellido.Text;
            client.Nit = txtNIT.Text;
            client.TipoCuenta = cbCuenta.Text;
            client.Codigo = txtCodigo.Text;
            client.Monto = float.Parse(txtMonto.Text);
            client.Sucursal = cbSucursal.Text;
            ///Verficacion de indice
            if (indice > -1)
            {
                Clientes[indice] = client;
            }
            else {
                Clientes.Add(client);
            }
            actualizarGrid();
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ///Metodo de codigo
        public string cod ()
        {
            string codi, iniciales, numeros;
            int num;
            if (cbCuenta.Text == "Ahorro") {
                iniciales = "CA";
            }
            if (cbCuenta.Text == "Corriente")
            {
                iniciales = "CC";
            }
            else {
                iniciales = "CP";
            }
            num = Clientes.Count()+1;
            if (num > 9)
            {
                if (num > 99)
                {
                    numeros = "0" + num.ToString();
                }
                else
                {
                    numeros = "00" + num.ToString();
                }
            }
            else {
                numeros = "000" + num.ToString();
            }
            codi =iniciales+"-"+numeros;

            return codi;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = cod();
        }
    }
}
