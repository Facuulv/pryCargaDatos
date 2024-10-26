using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMatriz.Columns.Clear();
            dgvMatriz.Rows.Clear();
            //cont = 0;
            dgvMatriz.Columns.Add("col0", "Nombre");
            dgvMatriz.Columns.Add("col1", "DNI");
            dgvMatriz.Columns.Add("col2", "Sector");
        }

        string[,] matNombre = new string [10, 3];
        string[,] matDNI = new string [10, 3];
        string[,] matSector = new string[10, 3];
        int cont = 0;
        int cont2 = 0;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDNI.Text != "" && txtSector.Text != "")
            {
                if (DniExiste(txtDNI.Text))
                {
                    if (cont < 10)
                    {
                        CargarMatriz();
                        cont++;
                        lblDispo.Text = cont + "/10";
                    } else
                    {
                        MessageBox.Show("Se ha llegado al limite de carga", "Atención");
                    }
                } else
                {
                    txtNombre.Text = "";
                    txtDNI.Text = "";
                    txtSector.Text = "";
                    txtNombre.Select();
                    MessageBox.Show($"El DNI {txtDNI.Text} ya se encuentra cargado en el sistema", "Error");
                }
            } else
            {
                MessageBox.Show("Error, debe completar todos los datos");
            }
        }

        public void CargarGrilla()
        {
            dgvMatriz.Rows.Clear();
            for (int f = 0; f < matNombre.GetLength(0); f++)
            {
                for (int c = 0; c < matNombre.GetLength(1); c++)
                {
                    if (matNombre[f, c] != null)
                    {
                        dgvMatriz.Rows.Add(matNombre[f, c], matDNI[f, c], matSector[f, c]);
                    }
                }
            }
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtSector.Text = "";
        }

        public void CargarMatriz()
        {
            string nombre = txtNombre.Text;
            string dni = txtDNI.Text;
            string sector = txtSector.Text;

            int f = 0;
            bool control = true;
            while (f < matNombre.GetLength(0) && control)
            {
                int c = 0;
                while (c < matNombre.GetLength(1) && control)
                {
                    if (matNombre[f, c] == null)
                    {
                        matNombre[f, c] = nombre;
                        matDNI[f, c] = dni;
                        matSector[f, c] = sector;
                        control = false;
                    }
                    c++;
                }
                f++;
            }
            CargarGrilla();
        }

        public bool DniExiste(string dni)
        {
            for (int f = 0; f < matDNI.GetLength(0); f++)
            {
                for (int c = 0; c < matDNI.GetLength(1); c++)
                {
                    if (matDNI[f, c] == dni)
                    {
                        return false; //El Dni existe
                    }
                }
            }
            return true; //El Dni no existe
        }
        public void EliminarDato()
        {
            for (int f = 0; f < matNombre.GetLength(0); f++)
            {
                for (int c = 0; c < matNombre.GetLength(1); c++)
                {
                    if (matDNI[f, c] == txtDniE.Text)
                    {
                        dgvMatriz.Rows.RemoveAt(f);
                        matNombre[f, c] = null;
                        matDNI[f, c] = null;
                        matSector[f, c] = null;
                        cont2++;
                        break;
                    }
                }
            }
            txtDniE.Text = "";
            CargarGrilla();
        }

        private void btnEliminarDato_Click(object sender, EventArgs e)
        {
            EliminarDato();
            lblDispo.Text = (cont - cont2) + "/10";
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < matNombre.GetLength(0); f++)
            {
                for (int c = 0; c < matNombre.GetLength(1); c++)
                {
                    if (matNombre[f, c] != null)
                    {
                        dgvMatriz.Rows.Clear();
                        matNombre[f, c] = null;
                        matDNI[f, c] = null;
                        matSector[f, c] = null;
                    }
                }
            }
            cont = 0;
            cont2 = 0;
            lblDispo.Text = cont + "/10";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
