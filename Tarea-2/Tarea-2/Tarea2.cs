using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2
{
    public partial class Tarea2 : Form
    {
        public Tarea2()
        {
            InitializeComponent();
        }

        private async void PromedioButton_Click(object sender, EventArgs e)
        {

            decimal nota1 = Convert.ToDecimal(Nota1TextBox.Text);
            decimal nota2 = Convert.ToDecimal(Nota2TextBox.Text);
            decimal nota3 = Convert.ToDecimal(Nota3TextBox.Text);
            decimal nota4 = Convert.ToDecimal(Nota4TextBox.Text);

            decimal total = await PromedioAsync(nota1, nota2, nota3, nota4);

            MessageBox.Show($"El Promedio del estuadiante es: {total}");

            Limpiar();
            Nota1TextBox.Focus();
        }
        private async Task<decimal> PromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promerdio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return promerdio;
        }
        private void Limpiar()
        {
            Nota1TextBox.Clear();
            Nota2TextBox.Clear();
            Nota3TextBox.Clear();
            Nota4TextBox.Clear();
            Nota1TextBox.Clear();
        }

    }
}

