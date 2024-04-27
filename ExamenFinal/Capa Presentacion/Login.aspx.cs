using ExamenFinal.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ExamenFinal.Capa_Presentacion;
using System.Configuration;


namespace ExamenFinal.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Usuario")) // Para liberar datos 
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind(); // refrescar la tabla
                        }
                    }
                }
            }
        }
        private void BuscarUsuario()
        {

            string nombreUsuario = Request.Form["username"];
            string contraseña = Request.Form["password"];

            ClsUsuario.Usuario = nombreUsuario;
            ClsUsuario.Clave = contraseña.ToLower();

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select NombreUsuario,Contraseña from Usuario where NombreUsuario = '" + ClsUsuario.Usuario + "'"+"and Contraseña = '"+ClsUsuario.Clave+"'",conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read()) 
            { 
                Response.Redirect("Inicio.aspx");
            }
            else 
            {
                Response.Write("Error en el inicio de sesion");

            }
            conexion.Close();
       


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}