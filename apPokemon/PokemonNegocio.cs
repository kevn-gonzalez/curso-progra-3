using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace apPokemon
{
    internal class PokemonNegocio
    {
        public List<Pokemon> Listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server = "; //<- Aca iria la direccion de la base de datos


            return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
                 

        }
    }
}
