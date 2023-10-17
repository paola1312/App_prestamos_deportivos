using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class cls_ModulosUsuarios
    {
        private string str_id;
        private string str_pnombre;
        private string str_snombre;
        private string str_papellido;
        private string str_sapellido;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;
        private string str_sexo;
        cls_Conexion objConectar = new cls_Conexion();
        public void fnt_guardar (string id, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string contacto,
            string correo, string direccion, string sexo)
        {
            if (id.Equals("") || p_nombre.Equals("") || s_nombre.Equals("") || p_apellido.Equals("") || s_apellido.Equals("") ||
                contacto.Equals("") || correo.Equals("") || direccion.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand con = new SqlCommand("sp_RegistrarPersonas", objConectar.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id",id);
                con.Parameters.AddWithValue("@nombre", p_nombre);
                con.Parameters.AddWithValue("@nombre", s_nombre);
                con.Parameters.AddWithValue("@nombre", p_apellido);
                con.Parameters.AddWithValue("@nombre", s_apellido);
                con.Parameters.AddWithValue("@contacto", contacto);
                con.Parameters.AddWithValue("@correo", correo);
                objConectar.connection.Open();
                con.ExecuteNonQuery();
                objConectar.connection.Close();
                MessageBox.Show("Persona registrada con éxito","regisro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
