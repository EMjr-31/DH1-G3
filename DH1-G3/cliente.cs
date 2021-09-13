using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH1_G3
{
    class cliente
    {
        string nombre;
        string apellido;
        string dui;
        string nit;
        float monto;
        string sucursal;
        string tipoCuenta;
        string codigo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Nit { get => nit; set => nit = value; }
        public float Monto { get => monto; set => monto = value; }
        public string Sucursal { get => sucursal; set => sucursal = value; }
        public string TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
