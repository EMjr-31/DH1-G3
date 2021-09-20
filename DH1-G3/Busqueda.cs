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
    public partial class Busqueda : Form
    {
        public List<cliente> ClienteRecibe=null;
        public Busqueda()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            actulizarGrid();   
        }
        private void actulizarGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = ClienteRecibe;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        ///BNusqueda de clientes
        public void Buscar()
        {

            int tam_list = ClienteRecibe.Count();
            string codigo = txtCodigo.Text;
            for (int i = 0; i < tam_list; i++)
            {
                if (ClienteRecibe[i].Codigo == codigo)
                {
                    List<cliente> ClienteBusqueda=new List<cliente>();
                    ClienteBusqueda.Add(ClienteRecibe[i]);
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = ClienteBusqueda;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
