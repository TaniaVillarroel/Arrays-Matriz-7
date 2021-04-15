using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio7Lilo
{
    public partial class Form1 : Form
    {
        const int fil = 2;
        const int col = 3;
        claseAlumno[,] mAlumno = new claseAlumno[fil,col];
        int conFil;
        int conCol;

        public Form1()
        {
            InitializeComponent();

            for (int f = 0; f < fil; f++)
			{
                for (int c = 0; c < col; c++)
                {
                    mAlumno[f, c] = null;
                }
			}
            conFil = 0;
            conCol = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            mAlumno[conFil, conCol] = new claseAlumno();
            mAlumno[conFil, conCol].pNombre = txtNombre.Text;
            mAlumno[conFil, conCol].pNota1 = int.Parse(txtNota1.Text);
            mAlumno[conFil, conCol].pNota2 = int.Parse(txtNota2.Text);
            mAlumno[conFil, conCol].pNota3 = int.Parse(txtNota3.Text);

            lstAlumnos.Items.Add(mAlumno[conFil, conCol].pNombre);
            conCol++;

            if(conCol==col)
            {
                MessageBox.Show("Se completo la fila " + conFil);
                conFil++;
                conCol = 0;
            }
            if (conFil == fil)
            {
                MessageBox.Show("Se completo la matriz bro");
                btnCargar.Enabled = false;
            }
            
            
            
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            lstPromedios.Items.Clear();
            for (int f = 0; f < fil; f++)
			{
                for (int c = 0; c < col; c++)
                {
                    lstPromedios.Items.Add(mAlumno[f, c].calcularPromedio());

                }
			}
            
        }
    }
}
