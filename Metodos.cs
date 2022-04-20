using System;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class Metodos
    {
        private Conectar datos = new Conectar();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();


        //------------------------------------------Metodos de Entidades
        public DataTable consultar()
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "consultar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            datos.cerrarConexion();
            return tabla;

        }

        public void agregar(string descripcion, string direccion, string localidad, string tipodeentidad, string tipodedocumento, string numerodocumento, string telefonos, string paginaweb, string facebook, string instagram, string twitter, string tiktok, string limitecredito, string usernameentidad, string passwordentidad, string roluserentidad, string comentario, string status)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=SellPoint;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();

            comando.Connection = cnn;
            comando.CommandText = "INSERT into Entidades (Descripcion,Direccion,Localidad,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,Status) values (@Descripcion,@Direccion,@localidad,@Tipoentidad,@Numerodocumento,@Telefonos,@URLPaginaWeb,@URLFacebook,@URLInstagram,@URLTwitter,@URLTikTok,@LimiteCredito,@UserNameEntidad,@PassworEntidad,@RolUserEntidad,@Comentario,@Status)";
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@localidad", localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", tipodeentidad);
            comando.Parameters.AddWithValue("@TipoDocumento", tipodedocumento);
            comando.Parameters.AddWithValue("@Numerodocumento", numerodocumento);
            comando.Parameters.AddWithValue("@Telefonos", telefonos);
            comando.Parameters.AddWithValue("@URLPaginaWeb", paginaweb);
            comando.Parameters.AddWithValue("@URLFacebook", facebook);
            comando.Parameters.AddWithValue("@URLInstagram", instagram);
            comando.Parameters.AddWithValue("@URLTwitter", twitter);
            comando.Parameters.AddWithValue("@URLTikTok", tiktok);
            comando.Parameters.AddWithValue("@LimiteCredito", limitecredito);
            comando.Parameters.AddWithValue("@UserNameEntidad", usernameentidad);
            comando.Parameters.AddWithValue("@PassworEntidad", passwordentidad);
            comando.Parameters.AddWithValue("@RolUserEntidad", roluserentidad);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.Parameters.AddWithValue("@Status", status);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void cambiar(int id_Entidad, string descripcion, string direccion, string localidad, string tipoentidad, string tipodocumento, string numerodocumento, string telefonos, string paginaweb, string facebook, string instagram, string twitter, string tiktok, string limitecredito, string usernameentidad, string passwordentidad, string roluserentidad, string comentario, string status)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=SellPoint;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();
            //Tipoentidad
            comando.Connection = cnn;
            comando.CommandText = "UPDATE Entidades SET Descripcion = @Descripcion, Direccion = @Direccion,Localidad = @localidad,TipoEntidad = @TipoEntidad,TipoDocumento = @TipoDocumento,NumeroDocumento = @Numerodocumento,Telefonos = @Telefonos,URLPaginaWeb = @URLPaginaWeb,URLFacebook = @URLFacebook,URLInstagram = @URLInstagram,URLTwitter = @URLTwitter,URLTikTok = @URLTikTok,LimiteCredito = @LimiteCredito,UserNameEntidad = @UserNameEntidad,PassworEntidad = @PassworEntidad,RolUserEntidad = @RolUserEntidad,Comentario = @Comentario,Status = @Status WHERE id_Entidad = @id_Entidad";
            comando.Parameters.AddWithValue("@id_Entidad", id_Entidad);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@localidad", localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", tipoentidad);
            comando.Parameters.AddWithValue("@TipoDocumento", tipodocumento);
            comando.Parameters.AddWithValue("@Numerodocumento", numerodocumento);
            comando.Parameters.AddWithValue("@Telefonos", telefonos);
            comando.Parameters.AddWithValue("@URLPaginaWeb", paginaweb);
            comando.Parameters.AddWithValue("@URLFacebook", facebook);
            comando.Parameters.AddWithValue("@URLInstagram", instagram);
            comando.Parameters.AddWithValue("@URLTwitter", twitter);
            comando.Parameters.AddWithValue("@URLTikTok", tiktok);
            comando.Parameters.AddWithValue("@LimiteCredito", limitecredito);
            comando.Parameters.AddWithValue("@UserNameEntidad", usernameentidad);
            comando.Parameters.AddWithValue("@PassworEntidad", passwordentidad);
            comando.Parameters.AddWithValue("@RolUserEntidad", roluserentidad);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.Parameters.AddWithValue("@Status", status);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void Insertar(string descripcion, string direccion, string localidad, string tipoentidad, string numerodocumento, string telefonos, string paginaweb, string facebook, string instagram, string twitter, string tiktok, string limitecredito, string usernameentidad, string passwordentidad, string roluserentidad, string comentario, string status)
        {
            String sql = "insert into Entidades (Descripcion,Direccion,Localidad,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,Status) values (A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q)";

            comando = new SqlCommand(sql, Conectar.conexion);
            adapter.InsertCommand = new SqlCommand(sql, Conectar.conexion);
            adapter.InsertCommand.ExecuteNonQuery();
            comando.Dispose();
            Conectar.conexion.Close();
        }

        public void Eliminar(int id_Entidad)
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "Eliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Entidad", id_Entidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            datos.cerrarConexion();
        }


        //------------------------------------------Metodos de GruposEntidades
        public DataTable gpConsultar()
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "gpConsultar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            datos.cerrarConexion();
            return tabla;
        }

        public void gpAgregar(string Descripcion, string Comentario, string Status)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=SellPoint;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();

            comando.Connection = cnn;
            comando.CommandText = "INSERT into GruposEntidades (Descripcion,Comentario,Status) values (@Descripcion,@Comentario,@Status)";
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Status", Status);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void gpInsertar(string descripcion, string comentario, string status)
        {
            String sql = "insert into GruposEntidades (Descripcion,Comentario,Status) values (A,B,C)";

            comando = new SqlCommand(sql, Conectar.conexion);
            adapter.InsertCommand = new SqlCommand(sql, Conectar.conexion);
            adapter.InsertCommand.ExecuteNonQuery();
            comando.Dispose();
            Conectar.conexion.Close();
        }

        public void gpCambiar(int IdGrupoEntidad, string descripcion, string comentario, string status)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=SellPoint;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();

            comando.Connection = cnn;
            comando.CommandText = "UPDATE Entidades SET Descripcion = @Descripcion,Comentario = @Comentario,Status = @Status WHERE IdGruposEntidad = @IdGrupoEntidad";
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.Parameters.AddWithValue("@Status", status);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void gpEliminar(int IdGrupoEntidad)
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "gpEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            datos.cerrarConexion();
        }


        //------------------------------------------Metodos de TiposEntidades
        public DataTable tpConsultar()
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "tpConsultar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            datos.cerrarConexion();
            return tabla;
        }

        public void tpAgregar(string Descripcion, string Comentario, string Status)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=SellPoint;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();

            comando.Connection = cnn;
            comando.CommandText = "INSERT into TiposEntidades (Descripcion,Comentario,Status) values (@Descripcion,@Comentario,@Status)";
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Status", Status);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void tpCambiar(int @idTipoEntidad, string descripcion, string comentario, string status)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=SellPoint;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();

            comando.Connection = cnn;
            comando.CommandText = "UPDATE TiposEntidades SET Descripcion = @Descripcion,Comentario = @Comentario,Status = @Status WHERE idTipoEntidad = @idTipoEntidad";
            comando.Parameters.AddWithValue("@idTipoEntidad", idTipoEntidad);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Comentario", comentario);
            comando.Parameters.AddWithValue("@Status", status);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void tpEliminar(int idTipoEntidad)
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "tpEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTipoEntidad", @idTipoEntidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            datos.cerrarConexion();
        }

        //------------------------------------------Login
        public void login(string user,string password)
        {
            String conec;
            SqlCommand comando = new SqlCommand();
            SqlConnection cnn;

            conec = "Server=DESKTOP-LVU63JL;DataBase=SellPoint;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();
            comando.Connection = cnn;
            comando.CommandText = "SELECT UserNameEntidad,PassworEntidad FROM Entidadades WHERE UserNameEntidad = @UserNameEntidad AND PassworEntidad = @PassworEntidad";
            comando.Parameters.AddWithValue("@UserNameEntidad", user);
            comando.Parameters.AddWithValue("@PassworEntidad", password);
            comando.ExecuteNonQuery();
            comando.ExecuteReader();

            cnn.Close();
        }
    }
}
