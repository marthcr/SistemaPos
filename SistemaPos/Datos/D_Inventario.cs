using MySql.Data.MySqlClient;
using SistemaPos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Datos
{
    public class D_Inventario
    {
        public DataTable Listado_iv(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("isp_listado_in", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable ListadoFamilias_iv(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("isp_listadofamilias_in", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Guardar_fa(int Opcion, E_Familias oPro)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("isp_guardarfamilia_iv", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("Opcion", MySqlDbType.Int32).Value = Opcion;
                Comando.Parameters.Add("nCodigo_fa", MySqlDbType.Int32).Value = oPro.Codigo_fa;
                Comando.Parameters.Add("nDescripcion", MySqlDbType.VarChar).Value = oPro.Descripcion;
                Comando.Parameters.Add("nCodigo_us", MySqlDbType.VarChar).Value = oPro.Codigo_us;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "nCodigofa_ou";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParCodigo);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParCodigo.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Guardar_articulo(int Opcion, E_Inventario oPro)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("isp_guardararticulos_iv", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("Opcion", MySqlDbType.Int32).Value = Opcion;
                Comando.Parameters.Add("nCodigopro", MySqlDbType.Int32).Value = oPro.Codigo_pro;
                Comando.Parameters.Add("nDescripcion", MySqlDbType.VarChar).Value = oPro.Descripcion_pro;
                Comando.Parameters.Add("nCodigoManual_pro", MySqlDbType.VarChar).Value = oPro.Codigomanual_pro;
                Comando.Parameters.Add("nImpuesto_pro", MySqlDbType.Int32).Value = oPro.Impuesto_pro;
                Comando.Parameters.Add("nCodigofa", MySqlDbType.VarChar).Value = oPro.Codigo_fa;
                Comando.Parameters.Add("nCabys_pro", MySqlDbType.VarChar).Value = oPro.Cabys_pro;
                Comando.Parameters.Add("nPrecioCosto_pro", MySqlDbType.Decimal).Value = oPro.Pu_costo;
                Comando.Parameters.Add("nUtilidad_pro", MySqlDbType.Int32).Value = oPro.Utilidad_pro;
                Comando.Parameters.Add("nPrecioVenta_pro", MySqlDbType.Decimal).Value = oPro.Pu_venta;
                Comando.Parameters.Add("nCantidad_pro", MySqlDbType.Int32).Value = oPro.Cantidad_pro;
                Comando.Parameters.Add("nFechaCrea_pro", MySqlDbType.DateTime).Value = oPro.FechaCrea_pro;
                Comando.Parameters.Add("nFechaMod_pro", MySqlDbType.DateTime).Value = oPro.FechaMod_pro;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "nCodigopro_ou";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParCodigo);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParCodigo.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Borrarfa(int id)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("isp_eliminarfa_in", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("id", MySqlDbType.Int32).Value = id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se realizo el proceso";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public DataTable Listado_fa()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("isp_listafa_iv", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
