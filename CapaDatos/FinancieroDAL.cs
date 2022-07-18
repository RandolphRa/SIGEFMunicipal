using System;
using System.Collections.Generic;
using System.Data;
//SqlConnection
using System.Data.SqlClient;
using System.IO;
using CapaEntidad;
using Microsoft.Extensions.Configuration;

namespace CapaDatos
{
    public class FinancieroDAL : CadenaDAL
    {

//        List<TipoMedicamentoCLS> lista = null;
//            using (SqlConnection cn = new SqlConnection(cadena))
//            {
//                try
//                {
//                    cn.Open();
//                    using (SqlCommand cmd = new SqlCommand("select iidtipomedicamento, descripcion, nombre" +
//                        " from TipoMedicamento where BHABILITADO = 1 and nombre like '%"+ nombretipo + "%' ", cn))
//                    {
//                        cmd.CommandType = CommandType.Text;
//                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
//                        if (drd != null)
//                        {
//                            TipoMedicamentoCLS oTipoMedicamentoCLS;
//    lista = new List<TipoMedicamentoCLS>();
//                            int postId = drd.GetOrdinal("iidtipomedicamento");
//    int postNombre = drd.GetOrdinal("nombre");
//    int postDescripcion = drd.GetOrdinal("descripcion");
//                            while (drd.Read())
//                            {
//                                oTipoMedicamentoCLS = new TipoMedicamentoCLS();
//    oTipoMedicamentoCLS.idtipomedicamento = drd.IsDBNull(postId)? 0 : drd.GetInt32(postId);
//                                oTipoMedicamentoCLS.nombre = drd.IsDBNull(postNombre)? "" : drd.GetString(postNombre);
//                                oTipoMedicamentoCLS.descripcion = drd.IsDBNull(postDescripcion)? "" : drd.GetString(postDescripcion);
//                                lista.Add(oTipoMedicamentoCLS);
//                            }
////Cerrar conexiòn
//cn.Close();
//                        }
//                    }
//                }
//                catch (Exception ex)
//{
//    cn.Close();
//    lista = null;
//}



//            }
        //Servicio que llena la data pasarle Entidad
        public List<FinancieroClasificadoresCLS> ListarClasificadores() {
            List<FinancieroClasificadoresCLS> listaUsuarios = new List<FinancieroClasificadoresCLS>();
            //List<TipoMedicamentoCLS> lista = null;
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try {
                    cn.Open();
                    using (SqlCommand cmd= new SqlCommand("select  top 10* from catalogo", cn))
                    {
                    cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                        if(drd != null)
                        {
                            FinancieroClasificadoresCLS ofinancieroClasificadoresCLS;
                            listaUsuarios =  new List<FinancieroClasificadoresCLS>();
                            int postid = drd.GetOrdinal("Numero");
                            int postnombre = drd.GetOrdinal("Nombre");
                            int postorigen = drd.GetOrdinal("Origen");
                            int posttipo = drd.GetOrdinal("Tipo");
                            int postcontrol = drd.GetOrdinal("control");
                            int postcuentA_CONTROl = drd.GetOrdinal("CTA_CONTAG");
                            int postDETALLE = drd.GetOrdinal("DETALLE");
                            while (drd.Read())
                            {
                                ofinancieroClasificadoresCLS = new FinancieroClasificadoresCLS();
                                ofinancieroClasificadoresCLS.CLASIFICADOR = drd.IsDBNull(postid) ? "" : drd.GetString(postid);
                                ofinancieroClasificadoresCLS.DESCRIPCION = drd.IsDBNull(postnombre) ? "" : drd.GetString(postnombre);
                                ofinancieroClasificadoresCLS.CUENTA_CONTROL = drd.IsDBNull(postcontrol) ? "" : drd.GetString(postcontrol);
                                ofinancieroClasificadoresCLS.TIPO = drd.IsDBNull(posttipo) ? "" : drd.GetString(posttipo);
                               ofinancieroClasificadoresCLS.CLASIFICACION = drd.IsDBNull(postorigen) ? "" : drd.GetString(postorigen);
                                ofinancieroClasificadoresCLS.CUENTA_CONTROL = drd.IsDBNull(postcuentA_CONTROl) ? "" : drd.GetString(postcuentA_CONTROl);
                                ofinancieroClasificadoresCLS.CTA_CONTABLE = drd.IsDBNull(postDETALLE) ? "" : drd.GetString(postDETALLE);
                                listaUsuarios.Add(ofinancieroClasificadoresCLS);
                            }
                            cn.Close();

                        }
                    }
                }
                catch(Exception ex) {
                    cn.Close();
                    listaUsuarios = null;
                }
            }

                return listaUsuarios;

        }
        public List<FinancieroProgramaticaCLS> ListarEtsProgramatico()
        {
            List<FinancieroProgramaticaCLS> listProgramatico = new List<FinancieroProgramaticaCLS>();
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 1,
                PNAP = 0,
                Programa = 01,
                Proyecto = 00,
                Actividad = 0000,
                EstProgControl = "00010000000",
                Denominacion = "normas,Politicas y Administracion",
                UnidadResponsable = "Consejo Municipal"

            });
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 1,
                PNAP = 0,
                Programa = 01,
                Proyecto = 00,
                Actividad = 0000,
                EstProgControl = "00010000000",
                Denominacion = "normas,Politicas y Administracion",
                UnidadResponsable = "Consejo Municipal"

            });
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 2,
                PNAP = 0,
                Programa = 01,
                Proyecto = 00,
                Actividad = 0000,
                EstProgControl = "00010000000",
                Denominacion = "normas y Seguimientos",
                UnidadResponsable = "Contraloria Municipal"

            });
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 3,
                PNAP = 0,
                Programa = 11,
                Proyecto = 00,
                Actividad = 0003,
                EstProgControl = "00010005000",
                Denominacion = "normas,Politicas y Administracion",
                UnidadResponsable = "Despacho del Alcalde"

            });



            return listProgramatico;

        }


        public List<FinancieroCatalogoFuncionesCLS> ListarFinancieroCatalogo()
        {
            List<FinancieroCatalogoFuncionesCLS> listaUsuarios = new List<FinancieroCatalogoFuncionesCLS>();
            listaUsuarios.Add(new FinancieroCatalogoFuncionesCLS
            {
                ID = 1,
                codigo = 1232,
                finalidad = 1,
                funcion = 1,
                subfuncion = 01,
                denominacion = "SERVICIOS GENERALES",

            });
            listaUsuarios.Add(new FinancieroCatalogoFuncionesCLS
            {
                ID = 1,
                codigo = 1232,
                finalidad = 1,
                funcion = 1,
                subfuncion = 02,
                denominacion = "ADMINISTRACION GENERAL",

            });
            listaUsuarios.Add(new FinancieroCatalogoFuncionesCLS
            {
                ID = 1,
                codigo = 1232,
                finalidad = 1,
                funcion = 2,
                subfuncion = 03,
                denominacion = "RELACIONES INTERNACIONALES",

            });



            return listaUsuarios;
        }
        public List<FinancieroFuentesFinanciamientoCLS> ListarFuentesFinanciamiento()
        {
            List<FinancieroFuentesFinanciamientoCLS> ListaFuentes = new List<FinancieroFuentesFinanciamientoCLS>();
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 0000,
                DENOMINACION = "Fuentes Internas",
                ORIGEN = "",
                FONDO = 0000,
                FUENTE = " ",
                GRUPO = "1"

            });
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 0000,
                DENOMINACION = "Fondo General",
                ORIGEN = "",
                FONDO = 0000,
                FUENTE = "10",
                GRUPO = "10"

            });
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 0000,
                DENOMINACION = "Fondos de Destino Especifico",
                ORIGEN = "",
                FONDO = 0000,
                FUENTE = "20",
                GRUPO = "1"

            });
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 0000,
                DENOMINACION = "Fondos Propios",
                ORIGEN = "",
                FONDO = 0000,
                FUENTE = "30",
                GRUPO = "1"

            });
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 0000,
                DENOMINACION = "Transferencias",
                ORIGEN = "",
                FONDO = 0000,
                FUENTE = "40",
                GRUPO = "1"

            });
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 0000,
                DENOMINACION = "Credito Internos",
                ORIGEN = "",
                FONDO = 0000,
                FUENTE = "50",
                GRUPO = "1"

            });

            return ListaFuentes;


        }
        public List<FinancieroCatalogoOrganismosFinanciadoresCLS> ListarFinancieroCatalogoOrganismos()
        {
            List<FinancieroCatalogoOrganismosFinanciadoresCLS> ListaFuentes = new List<FinancieroCatalogoOrganismosFinanciadoresCLS>();
            ListaFuentes.Add(new FinancieroCatalogoOrganismosFinanciadoresCLS
            {
                id = 1,
                grupo = 1,
                subgrupo = 1,
                orgfin = 1,
                denominacion = "Organismo Internos",


            });
            ListaFuentes.Add(new FinancieroCatalogoOrganismosFinanciadoresCLS
            {
                id = 1,
                grupo = 1,
                subgrupo = 1,
                orgfin = 1,
                denominacion = "Bancos Nacionales",


            });
            ListaFuentes.Add(new FinancieroCatalogoOrganismosFinanciadoresCLS
            {
                id = 1,
                grupo = 1,
                subgrupo = 1,
                orgfin = 1,
                denominacion = "Banco de Reservas de la Republica Dominicana (BANRESERVAS)",


            });
            ListaFuentes.Add(new FinancieroCatalogoOrganismosFinanciadoresCLS
            {
                id = 1,
                grupo = 1,
                subgrupo = 1,
                orgfin = 99,
                denominacion = "Otros Bancos Nacionales",


            });
            ListaFuentes.Add(new FinancieroCatalogoOrganismosFinanciadoresCLS
            {
                id = 1,
                grupo = 1,
                subgrupo = 2,
                orgfin = 1,
                denominacion = "Otros Organismos Internos",


            });
            ListaFuentes.Add(new FinancieroCatalogoOrganismosFinanciadoresCLS
            {
                id = 1,
                grupo = 1,
                subgrupo = 2,
                orgfin = 100,
                denominacion = "Tesoro Nacional",


            });

            return ListaFuentes;


        }


        public List<FinancieroFuenteEspecificaCLS> ListarFuentesEspecificas()
        {
            List<FinancieroFuenteEspecificaCLS> ListaEspecificas = new List<FinancieroFuenteEspecificaCLS>();
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0332,
                fuente = 60,
                denominacion = "TERMOELECTRICA BARAHONA"


            });

            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0100,
                fuente = 60,
                denominacion = "Fondo General"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0346,
                fuente = 60,
                denominacion = "Proyecto Rio Blanco del Inst. Nac. de Rec. Hidraulicos"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0374,
                fuente = 60,
                denominacion = "Proyecto Metro Santo Domingo- Opret"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0350,
                fuente = 60,
                denominacion = "Rehabilitacion de la Cde Bid 585/OC-DR"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0351,
                fuente = 60,
                denominacion = "Proyecto Para la Educacion Basica"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0352,
                fuente = 60,
                denominacion = "Proyecto de Rehabilitacion y Mantenimiento Carreteras"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0354,
                fuente = 60,
                denominacion = "2o Programa Mejoramiento Educacion Basica BIRF 3951-DO"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 0355,
                fuente = 60,
                denominacion = "Mejoramiento de la Eduacion Basica BID 897/OC-DR"


            });
            return ListaEspecificas;


        }

        public List<IngresosCLS> ListarIngresos()
        {
            List<IngresosCLS> ListaIngresos = new List<IngresosCLS>();

            ListaIngresos.Add(new IngresosCLS
            {
                id = 1,
                Clasificador = 114333,
                Denominacion = "Licencias de construcción",
                FuenteFinanciamiento = "30",
                FuenteEspecifica = "9996",
                OrganismoFinancamiento = "102",
                InstitucionOtorgante = "",
                Tipo = "DETALLE",
                AnoAnterior = "2,500,000.00",
                Fecha = "1,177,820.00",
                Estimado = "1905,465.45",
                Formulado = "2,500,000.00"


            }); ListaIngresos.Add(new IngresosCLS
            {
                id = 1,
                Clasificador = 1232,
                Denominacion = "Servicios Generales",
                FuenteFinanciamiento = "Fuentes Internas",
                OrganismoFinancamiento = "Organismo Internos",
                Tipo = "General",
                AnoAnterior = "200,000.00",
                Fecha = "100,000.00",
                Estimado = "100,000.00",
                Formulado = "200,000.00",
                FuenteEspecifica = "",
                InstitucionOtorgante = ""


            });
            return ListaIngresos;
        }


        public List<GastosCLS> ListarGastos()
        {
            List<GastosCLS> ListaGastos = null;
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from PRESUP_GASTO", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                        if (drd != null)
                        {
                            GastosCLS ogastosCLS;
                            ListaGastos = new List<GastosCLS>();
                            int postid = drd.GetOrdinal("NUMERO");
                            int postPnap = drd.GetOrdinal("PNAP");
                            int postPrograma = drd.GetOrdinal("PROGRAMA");
                            int postProyecto = drd.GetOrdinal("PROYECTO");
                            int postObra = drd.GetOrdinal("ACT_OBRA");
                            int postDenominacion = drd.GetOrdinal("NOMBRE");
                            int postFuncion = drd.GetOrdinal("FUNCION");
                            int postControl = drd.GetOrdinal("CONTROL");
                            int postTipo = drd.GetOrdinal("TIPO_GASTO");
                            int postUnidadResponsable = drd.GetOrdinal("UNIDAD_RESP");

                            int postPresupuesto = drd.GetOrdinal("VALOR_PRESUPUESTO");
                            while (drd.Read())
                            {
                                ogastosCLS = new GastosCLS();
                                ogastosCLS.numero = drd.IsDBNull(postid) ? "" : drd.GetString(postid);
                                ogastosCLS.Pnap = drd.IsDBNull(postPnap) ? "" : drd.GetString(postPnap);
                                ogastosCLS.Programa = drd.IsDBNull(postPrograma) ? "" : drd.GetString(postPrograma);
                                ogastosCLS.Proyecto= drd.IsDBNull(postProyecto) ? "" : drd.GetString(postProyecto);
                                ogastosCLS.Obra = drd.IsDBNull(postObra) ? "" : drd.GetString(postObra);
                                ogastosCLS.Denominacion = drd.IsDBNull(postDenominacion) ? "" : drd.GetString(postDenominacion);
                                ogastosCLS.Funcion = drd.IsDBNull(postFuncion) ? "" : drd.GetString(postFuncion);
                                ogastosCLS.Control = drd.IsDBNull(postControl) ? "" : drd.GetString(postControl);
                                ogastosCLS.Tipo = drd.IsDBNull(postTipo) ? "" : drd.GetString(postTipo);
                                ogastosCLS.UnidadResponsable = drd.IsDBNull(postUnidadResponsable) ? "" : drd.GetString(postUnidadResponsable);
                                ogastosCLS.Presupuesto = drd.IsDBNull(postPresupuesto) ? 0 : drd.GetDecimal(postPresupuesto) ;

                                ListaGastos.Add(ogastosCLS);
                            }
                            }
                            }
                            cn.Close();

                        
                    
                }
                catch (Exception ex)
                {
                    cn.Close();
                    ListaGastos = null;
                }
            }
            return ListaGastos;
        }



        public List<ProyectoCLS> ListarProyecto()
        {
            List<ProyectoCLS> ListaProyecto = new List<ProyectoCLS>();
            ListaProyecto.Add(new ProyectoCLS
            {
                id = 1,
                Proyecto = "01- Construccion de Vias de Comunicacion y Amexos",
                CodigoObra= "0051",
                Descripcion = "Construccion de bandenes casco urbano",
                FechaFin ="",
                FechaIninio="",
                Participacion = "No"

            });
            return ListaProyecto;
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
