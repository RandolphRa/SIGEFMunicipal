using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using Microsoft.Extensions.Configuration;

namespace CapaDatos
{
    public class UsuarioDAT:CadenaDAL
    {
       

        public List<UsuarioEntity> ListarUsuarios() { 
            List<UsuarioEntity> listaUsuarios = new List<UsuarioEntity>(); 
            listaUsuarios.Add(new UsuarioEntity { 
                ID = 1,
                Name ="Randolph"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });
            listaUsuarios.Add(new UsuarioEntity
            {
                ID = 2,
                Name ="Randolph2"
            });

            return listaUsuarios;
        
        }

        public List<UsuarioEntity> ListarUsuarios2()
        {
            List<UsuarioEntity> listaUsuarios = null;

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("Select * from prueba",cn)) {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader();
                        if (drd != null) {
                            UsuarioEntity oUsuarioEntity;
                            while (drd.Read()) {
                                oUsuarioEntity = new UsuarioEntity();
                                oUsuarioEntity.ID = drd.GetInt32(0);
                                oUsuarioEntity.Name = drd.GetString(1);
                                listaUsuarios.Add(oUsuarioEntity);
                            }
                            cn.Close();
                        }
                    }
                }
                catch(Exception ex)
                { 
                    cn.Close();
                    listaUsuarios = null;
                }
            }

            return null;

        }
    }
}
