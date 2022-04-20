using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class login : Form

    {
        private Conectar datos = new Conectar();


        public login()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            singup llamar = new singup();
            llamar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String conec;
                SqlCommand comando = new SqlCommand();
                SqlConnection cnn;

                conec = "Server=DESKTOP-LVU63JL;DataBase=SellPoint;Integrated Security=true";
                cnn = new SqlConnection(conec);
                cnn.Open();
                comando.Connection = cnn;
                comando.CommandText = "select * from Entidades where UserNameEntidad = @UserNameEntidad and PassworEntidad = @PassworEntidad";
                comando.Parameters.AddWithValue("@UserNameEntidad", txtusuario.Text);
                comando.Parameters.AddWithValue("@PassworEntidad", txtpassword.Text);
                comando.ExecuteNonQuery();
                SqlDataReader dr = comando.ExecuteReader();
                

                if (dr.Read())
                {
                    MessageBox.Show("Sesion iniciada satisfactoriamente");
                    cnn.Close();
                    home login = new home();
                    login.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("No se pudo iniciar sesion");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                            "" + ex);
            }
        }
    }
}
