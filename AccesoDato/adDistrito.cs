using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDato
{
  public sealed class adDistrito
  {
    public static bool Grabar(Entidades.Distrito pEntidad)
    {
      using (var cn = new SqlConnection(conexion.LeerCC))
      {
        // Contamos cuantos distritos existen segun el coddistrito o nomdistrito
        using (var cmd = new SqlCommand(@"select isnull(count(coddistrito),0) from distritos where coddistrito=@cod or nomdistrito=@nom", cn))
        {
          cmd.Parameters.AddWithValue("cod", pEntidad.coddistrito);
          cmd.Parameters.AddWithValue("nom", pEntidad.nomdistrito);

          cn.Open();
          // Ejecutamos el comando y verificamos si el resultado es mayor a cero actualizar, caso contrario insertar
          if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
          {
            // Si es mayor a cero, quiere decir que existe al menos un registro con los datos ingresados
            // Entonces antes de actualizar, hacer las siguientes comprobaciones
            if (pEntidad.coddistrito == 0)
              throw new Exception("El distrito ya esta registrado en el sistema, verifique los datos por favor!...");

            // Verifica si ya existe un registro con el mismo nombre del distrito
            cmd.CommandText = @"select isnull(count(coddistrito),0) from distritos where coddistrito<>@cod and nomdistrito=@nom";
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
              throw new Exception("No se puede grabar un valor duplicado, verifique los datos por favor!...");

            // Si las comprobaciones anteriores resultaron ser falsa, entonces actualizar
            cmd.CommandText = @"update distritos set nomdistrito=@nom where coddistrito=@cod";
          }
          else
            cmd.CommandText = @"insert into distritos (nomdistrito) values (@nom)";

          // Ejecutamos el comando que puede ser para update o insert
          return Convert.ToBoolean(cmd.ExecuteNonQuery());
        }
      }
    }

    public static bool Eliminar(Entidades.Distrito pEntidad)
    {
      using (var cn = new SqlConnection(conexion.LeerCC))
      {
        // Contar la cantidad de amigos que existe en un determinado distrito
        using (var cmd = new SqlCommand(@"select isnull(count(codamigo),0) from amigos where coddistrito=@cod", cn))
        {
          cmd.Parameters.AddWithValue("cod", pEntidad.coddistrito);

          cn.Open();
          // Si es mayor a cero, quiere decir que existen amigos en dicho distrito que intentamos eliminar
          if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            throw new Exception("No es posible eliminar el registro, ya que éste se encuentra en uso...");

          cmd.CommandText = "delete from distritos where coddistrito=@cod";
          return Convert.ToBoolean(cmd.ExecuteNonQuery());
        }
      }
    }

    public static List<Entidades.Distrito> Leer(string dato)
    {
      // Crea un obj. lista de tipo Distrito
      var lista = new List<Entidades.Distrito>();
      // Crear el objeto de conexion
      using (var cn = new SqlConnection(conexion.LeerCC))
      {
        // crear el comando
        using (var cmd = new SqlCommand("select coddistrito, nomdistrito from distritos where nomdistrito like @nom + '%'", cn))
        {
          //Asignar valores a los parametros
          cmd.Parameters.AddWithValue("nom", dato);

          // Abrir el objeto de conexion
          cn.Open();
          using (var dr = cmd.ExecuteReader())
          {
            while (dr.Read())
            {
              // Crea un objeto del distrito
              var oDistrito = new Entidades.Distrito();
              oDistrito.coddistrito = Convert.ToInt32(dr[dr.GetOrdinal("coddistrito")]);
              oDistrito.nomdistrito = Convert.ToString(dr[dr.GetOrdinal("nomdistrito")]);
              // El objeto distrito es agregado a la lista
              lista.Add(oDistrito);
              oDistrito = null;
            }
          }

          // Retorna una lista de datos
          return lista;
        }
      }
    }
  }
}
