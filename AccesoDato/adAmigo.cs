using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDato
{
  public sealed class adAmigo
  {
    public static bool Grabar(Entidades.Amigo pEntidad)
    {
      using (var cn = new SqlConnection(conexion.LeerCC))
      {
        // Contamos cuantos amigos existen segun el codamigo o nombre
        using (var cmd = new SqlCommand(@"select isnull(count(codamigo),0) from amigos where codamigo=@cod or dni=@dni", cn))
        {
          //Asignar valores a los parametros
          cmd.Parameters.AddWithValue("cod", pEntidad.codamigo);
          cmd.Parameters.AddWithValue("cdis", pEntidad.edistrito.coddistrito);
          cmd.Parameters.AddWithValue("nom", pEntidad.nombre);
          cmd.Parameters.AddWithValue("dni", pEntidad.dni);
          cmd.Parameters.AddWithValue("fn", pEntidad.fecnac);
          cmd.Parameters.AddWithValue("sex", pEntidad.sexo);
          cmd.Parameters.AddWithValue("dir", pEntidad.direccion);
          cmd.Parameters.AddWithValue("telef", pEntidad.telefono);

          cn.Open();
          // Ejecutamos el comando y verificamos si el resultado es mayor a cero actualizar, caso contrario insertar
          if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
          {
            // Si es mayor a cero, quiere decir que existe al menos un registro con los datos ingresados
            // Entonces antes de actualizar, hacer las siguientes comprobaciones
            if (pEntidad.codamigo == 0)
              throw new Exception("El amigo(a) ya esta registrado en el sistema, verifique los datos por favor!...");

            // Verifica si ya existe un registro con el mismo nombre del distrito
            cmd.CommandText = @"select isnull(count(codamigo),0) from amigos where codamigo<>@cod and dni=@dni";
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
              throw new Exception("No se puede grabar un valor duplicado, verifique los datos por favor!...");

            // Si las comprobaciones anteriores resultaron ser falsa, entonces actualizar
            cmd.CommandText = @"update amigos set coddistrito=@cdis, nombre=@nom, dni=@dni, fecnac=@fn, sexo=@sex, direccion=@dir, telefono=@telef where codamigo=@cod";
          }
          else
            cmd.CommandText = @"insert into amigos (coddistrito, nombre, dni, fecnac, sexo, direccion, telefono) values (@cdis, @nom, @dni, @fn, @sex, @dir, @telef)";

          // Ejecutamos el comando que puede ser para update o insert
          return Convert.ToBoolean(cmd.ExecuteNonQuery());
        }
      }
    }

    public static bool Eliminar(Entidades.Amigo pEntidad)
    {
      using (var cn = new SqlConnection(conexion.LeerCC))
      {
        // Como nadie depende de esta entidad (amigos) no habra comprobaciones de dependencia
        using (var cmd = new SqlCommand(@"delete from amigos where codamigo=@cod", cn))
        {
          cmd.Parameters.AddWithValue("cod", pEntidad.codamigo);

          cn.Open();
          // Ejecuta el comando
          return Convert.ToBoolean(cmd.ExecuteNonQuery());
        }
      }
    }

    public static List<Entidades.Amigo> Leer(string dato)
    {
      // Crea un obj. lista de tipo Amigo
      var lista = new List<Entidades.Amigo>();
      // Crear el objeto de conexion
      using (var cn = new SqlConnection(conexion.LeerCC))
      {
        // crear el comando
        using (var cmd = new SqlCommand("select codamigo, nomdistrito, nombre, dni, fecnac, sexo, direccion, telefono from distritos inner join amigos on distritos.coddistrito = amigos.coddistrito where nombre like @nom + '%'", cn))
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
              var oAmigo = new Entidades.Amigo();
              oAmigo.codamigo = Convert.ToInt32(dr[dr.GetOrdinal("codamigo")]);

              // Aqui obtenemos el nombre del distrito para luego ser enviado al objeto amigo
              oDistrito.nomdistrito = Convert.ToString(dr[dr.GetOrdinal("nomdistrito")]);
              oAmigo.edistrito = oDistrito;

              oAmigo.nombre = Convert.ToString(dr[dr.GetOrdinal("nombre")]);
              oAmigo.dni = Convert.ToString(dr[dr.GetOrdinal("dni")]);
              oAmigo.fecnac = Convert.ToDateTime(dr[dr.GetOrdinal("fecnac")]);
              oAmigo.sexo = Convert.ToString(dr[dr.GetOrdinal("sexo")]);
              oAmigo.direccion = Convert.ToString(dr[dr.GetOrdinal("direccion")]);
              oAmigo.telefono = Convert.ToString(dr[dr.GetOrdinal("telefono")]);
              // El objeto amigo es agregado a la lista
              lista.Add(oAmigo);
              // marcamos a los objetos creamos como nulos
              oDistrito = null;
              oAmigo = null;
            }
          }

          // Retorna una lista de datos
          return lista;
        }
      }
    }
  }
}
