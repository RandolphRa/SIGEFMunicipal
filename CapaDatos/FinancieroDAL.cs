﻿using System;
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
    public class FinancieroDAL:CadenaDAL
    {
       

        //Servicio que llena la data pasarle Entidad
        public List<FinancieroClasificadoresCLS> ListarClasificadores() { 
            List<FinancieroClasificadoresCLS> listaUsuarios = new List<FinancieroClasificadoresCLS>(); 
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            { 
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });

            return listaUsuarios;
        
        }

        public List<FinancieroCatalogoFuncionesCLS> ListarFinancieroCatalogo()
        {
            List<FinancieroCatalogoFuncionesCLS> listaUsuarios = new List<FinancieroCatalogoFuncionesCLS>();
            listaUsuarios.Add(new FinancieroCatalogoFuncionesCLS
            {
                ID = 1,
                codigo = 1245,
                finalidad = 1234,
                funcion = 25,
                subFuncion = 23123,
                denominacion = "OPERACION FALCON",

            });
         

            return listaUsuarios;

        }

        //public List<UsuarioEntity> ListarUsuarios2()
        //{
        //    List<UsuarioEntity> listaUsuarios = null;

        //    using (SqlConnection cn = new SqlConnection(cadena))
        //    {
        //        try
        //        {
        //            cn.Open();
        //            using (SqlCommand cmd = new SqlCommand("Select * from prueba",cn)) {
        //                cmd.CommandType = CommandType.Text;
        //                SqlDataReader drd = cmd.ExecuteReader();
        //                if (drd != null) {
        //                    UsuarioEntity oUsuarioEntity;
        //                    while (drd.Read()) {
        //                        oUsuarioEntity = new UsuarioEntity();
        //                        oUsuarioEntity.ID = drd.GetInt32(0);
        //                        oUsuarioEntity.Name = drd.GetString(1);
        //                        listaUsuarios.Add(oUsuarioEntity);
        //                    }
        //                    cn.Close();
        //                }
        //            }
        //        }
        //        catch(Exception ex)
        //        { 
        //            cn.Close();
        //            listaUsuarios = null;
        //        }
        //    }

        //    return null;

        //}
    }
}
