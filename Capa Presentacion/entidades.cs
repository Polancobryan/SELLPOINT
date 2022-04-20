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
    public partial class entidades : Form
    {
        acciones datos = new acciones();
        private string id = null;
        public entidades()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void entidades_Load(object sender, EventArgs e)
        {
            consultar();
        }
        private void consultar()
        {
            acciones objeto = new acciones();
            dataGridView1.DataSource = objeto.consultar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //--------------------------------------------------btnCAMBIAR
        private void button4_Click(object sender, EventArgs e)
        {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        Metodos datos = new Metodos();
                        datos.cambiar(Convert.ToInt32(txtid.Text), txtDescripcion.Text, txtDireccion.Text, txtLocalidad.Text, txtTipodeentidad.Text, txtTipodedocumento.Text, txtNumerodocumento.Text, txtTelefono.Text, txtPaginaweb.Text, txtFacebook.Text, txtInstagram.Text, txtInstagram.Text, txtTwitter.Text, txtTiktok.Text, txtUsuario.Text, txtContraseña.Text, txtRoluserentidad.Text, txtComentario.Text, txtStatus.Text);
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

        //---------------------------------------------------btnGUARDAR
        private void button5_Click(object sender, EventArgs e)
        {
                try
                {   
                    if (txtUsuario.Text == String.Empty || txtStatus.Text == String.Empty || txtComentario.Text == String.Empty || txtContraseña.Text == String.Empty || txtTelefono.Text == String.Empty || txtDireccion.Text == String.Empty ||txtLocalidad.Text == String.Empty || txtTipodeentidad.Text == String.Empty || txtDescripcion.Text == String.Empty || txtPaginaweb.Text == String.Empty || txtNumerodocumento.Text == String.Empty || txtTwitter.Text == String.Empty || txtFacebook.Text == String.Empty || txtInstagram.Text == String.Empty || txtTiktok.Text == String.Empty || txtRoluserentidad.Text == String.Empty || txtLimitecredito.Text == String.Empty || txtTipodedocumento.Text == String.Empty) 
                    {
                        MessageBox.Show("Completa todos los campos!");
                    }
                    else
                    {
                        Metodos datos = new Metodos();
                        datos.agregar(txtDescripcion.Text, txtDireccion.Text, txtLocalidad.Text, txtTipodeentidad.Text, txtTipodedocumento.Text, txtNumerodocumento.Text, txtTelefono.Text, txtPaginaweb.Text, txtFacebook.Text, txtInstagram.Text, txtInstagram.Text, txtTwitter.Text, txtTiktok.Text, txtUsuario.Text, txtContraseña.Text, txtRoluserentidad.Text, txtComentario.Text, txtStatus.Text);
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

        private void limpiarForm()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
            txtTipodeentidad.Clear();
            txtDescripcion.Clear();
            txtPaginaweb.Clear();
            txtNumerodocumento.Clear();
            txtTwitter.Clear();
            txtFacebook.Clear();
            txtInstagram.Clear();
            txtTiktok.Clear();
            txtRoluserentidad.Clear();
            txtComentario.Clear();
            txtStatus.Clear();
            txtLimitecredito.Clear();
            txtTipodedocumento.Clear();
        }

        private void sakirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sistemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about acerca_de = new about();
            acerca_de.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grupos_entidades tabla2 = new grupos_entidades();
            tabla2.ShowDialog();
            this.Hide();
        }

        private void tiposEntidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tipos_entidades tabla3 = new tipos_entidades();
            tabla3.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtDescripcion.Text = row.Cells[1].Value.ToString();
                txtDireccion.Text = row.Cells[2].Value.ToString();
                txtLocalidad.Text = row.Cells[3].Value.ToString();
                txtTipodeentidad.Text = row.Cells[4].Value.ToString();
                txtTipodedocumento.Text = row.Cells[5].Value.ToString();
                txtNumerodocumento.Text = row.Cells[6].Value.ToString();
                txtTelefono.Text = row.Cells[7].Value.ToString();
                txtPaginaweb.Text = row.Cells[8].Value.ToString();
                txtFacebook.Text = row.Cells[9].Value.ToString();
                txtInstagram.Text = row.Cells[10].Value.ToString();
                txtTwitter.Text = row.Cells[11].Value.ToString();
                txtTiktok.Text = row.Cells[12].Value.ToString();
                txtLimitecredito.Text = row.Cells[15].Value.ToString();
                txtUsuario.Text = row.Cells[16].Value.ToString();
                txtContraseña.Text = row.Cells[17].Value.ToString();
                txtRoluserentidad.Text = row.Cells[18].Value.ToString();
                txtComentario.Text = row.Cells[19].Value.ToString();
                txtStatus.Text = row.Cells[20].Value.ToString();

            }
        }

        //-------------------------------------------------btnBORRAR
        private void button6_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                datos.Eliminar(id);
                MessageBox.Show("Eliminado correctamente");
                consultar();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}
