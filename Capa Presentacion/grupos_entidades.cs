using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class grupos_entidades : Form
    {
        acciones datos = new acciones();
        private string id = null;
        public grupos_entidades()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void grupos_entidades_Load(object sender, EventArgs e)
        {
            consultar();
        }
        private void consultar()
        {
            acciones objeto = new acciones();
            dataGridView1.DataSource = objeto.gpConsultar();
        }

        private void limpiarForm()
        {
            txtid.Clear();
            txtcomentario.Clear();
            txtdescripcion.Clear();
            txtstatus.Clear();
            txtnoeliminable.Clear();
            txtfechaderegistro.Clear();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sakirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entidades entidad = new entidades();
            entidad.Show();
            this.Hide();
        }

        private void tiposEntidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tipos_entidades tipos = new tipos_entidades();
            tipos.Show();
            this.Hide();
        }

        private void acercaDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            about sobre = new about();
            sobre.ShowDialog();
            
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdescripcion.Text == String.Empty || txtstatus.Text == String.Empty || txtcomentario.Text == String.Empty)
                {
                    MessageBox.Show("Completa todos los campos!");
                }
                else
                {
                    Metodos datos = new Metodos();
                    datos.gpAgregar(txtdescripcion.Text, txtcomentario.Text, txtstatus.Text);
                    MessageBox.Show("Se agrego el registro correctamente");
                    consultar();
                    limpiarForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Su registro no pudo ser agregado debido a: " +
                    "" + ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                datos.gpEliminar(id);
                MessageBox.Show("Eliminado correctamente");
                consultar();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtdescripcion.Text = row.Cells[1].Value.ToString();
                txtcomentario.Text = row.Cells[2].Value.ToString();
                txtstatus.Text = row.Cells[3].Value.ToString();
                txtnoeliminable.Text = row.Cells[4].Value.ToString();
                txtfechaderegistro.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    Metodos datos = new Metodos();
                    datos.gpCambiar( Convert.ToInt32(txtid.Text), txtdescripcion.Text, txtcomentario.Text, txtstatus.Text);
                    MessageBox.Show("El registro fue actualizado correctamente");
                    consultar();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Su registro no pudo ser actualizado debido a: " +
                        "" + ex);
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}
