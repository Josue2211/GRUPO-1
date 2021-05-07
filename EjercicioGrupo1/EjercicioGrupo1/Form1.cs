using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioGrupo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgtDatos);
            fila.Cells[0].Value = txtDato.Text;

            dgtDatos.Rows.Add(fila);
            txtDato.Text = "";
        }
    }
}
