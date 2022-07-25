using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


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
        //listarCombosClasificadores
        public ComboCLS listarCombosClasificadores()
        {
            ComboCLS  ocomboCLS = new ComboCLS();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("upslistarcomboscatalogo", cn))
                    {
                        //Le indico que es un procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader drd = cmd.ExecuteReader();
                        if (drd != null)
                        {
                            List<FinancieroClasificadoresCLS> listaclasificadores = new List<FinancieroClasificadoresCLS>();
                            int posId = drd.GetOrdinal("numero");
                            int posNombre = drd.GetOrdinal("NOMBRE");

                            FinancieroClasificadoresCLS ofinancieroClasificadoresCLS;
                            while (drd.Read())
                            {
                                ofinancieroClasificadoresCLS = new FinancieroClasificadoresCLS();
                                ofinancieroClasificadoresCLS.CLASIFICADOR = drd.IsDBNull(posId) ? "" : drd.GetString(posId);
                                ofinancieroClasificadoresCLS.DESCRIPCION = drd.IsDBNull(posNombre) ? "" : drd.GetString(posNombre);

                                listaclasificadores.Add(ofinancieroClasificadoresCLS);
                            }
                            //oMedicamentoComboCLS.listaclasificadores = listalaboratorio;
                            ocomboCLS.listaclasificadores = listaclasificadores;
                        }
                        
                        cn.Close();
                    }

                }
                catch (Exception ex)
                {
                    cn.Close();
                    //null para mi es error
                    ocomboCLS = null;
                }
            }

                return ocomboCLS;
        }

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
            List<IngresosCLS> ListaIngresos = null;
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from PRESUP_INGRESOS", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                        if (drd != null)
                        {
                            IngresosCLS oingresosCLS;
                            ListaIngresos = new List<IngresosCLS>();
                            int postClasificador = drd.GetOrdinal("CLASIFICADOR");
                            int postFuenteFinanciamiento = drd.GetOrdinal("FTE_FINANCIAMIENTO");
                            int postFuenteEspecifica = drd.GetOrdinal("FTE_ESPECIFICA");
                            int postOrganismoFinancamiento = drd.GetOrdinal("ORG_FINANCIADOR");
                            int postInstitucionOtorgante = drd.GetOrdinal("INST_OTORGANTE");
                            int postDenominacion = drd.GetOrdinal("DETALLE");
                            int postAnoAnterior = drd.GetOrdinal("PRESUP_ANTERIOR");
                            //int postAnoAnterior = drd.GetOrdinal("CONTROL");
                            int postEstimado = drd.GetOrdinal("ESTIMADO_ACTUAL");
                            int postFormulado = drd.GetOrdinal("VALOR_PRESUPUESTO");

                           // int postTipo = drd.GetOrdinal("VALOR_PRESUPUESTO");
                            while (drd.Read())
                            {
                                oingresosCLS = new IngresosCLS();
                                oingresosCLS.Clasificador = drd.IsDBNull(postClasificador) ? "" : drd.GetString(postClasificador);
                                oingresosCLS.FuenteFinanciamiento = drd.IsDBNull(postFuenteFinanciamiento) ? "" : drd.GetString(postFuenteFinanciamiento);
                                oingresosCLS.FuenteEspecifica = drd.IsDBNull(postFuenteEspecifica) ? "" : drd.GetString(postFuenteEspecifica);
                                oingresosCLS.OrganismoFinancamiento = drd.IsDBNull(postOrganismoFinancamiento) ? "" : drd.GetString(postOrganismoFinancamiento);
                                oingresosCLS.InstitucionOtorgante = drd.IsDBNull(postInstitucionOtorgante) ? "" : drd.GetString(postInstitucionOtorgante);
                                oingresosCLS.Denominacion = drd.IsDBNull(postInstitucionOtorgante) ? "" : drd.GetString(postInstitucionOtorgante);
                                oingresosCLS.Denominacion = drd.IsDBNull(postDenominacion) ? "" : drd.GetString(postDenominacion);
                                oingresosCLS.AnoAnterior = drd.IsDBNull(postAnoAnterior) ? 0 : drd.GetDecimal(postAnoAnterior);
                                oingresosCLS.Estimado = drd.IsDBNull(postEstimado) ? 0 : drd.GetDecimal(postEstimado);
                                oingresosCLS.Formulado = drd.IsDBNull(postFormulado) ? 0 : drd.GetDecimal(postFormulado);
                                //oingresosCLS.Presupuesto = drd.IsDBNull(postPresupuesto) ? 0 : drd.GetDecimal(postPresupuesto);

                                ListaIngresos.Add(oingresosCLS);
                            }
                        }
                    }
                    cn.Close();



                }
                catch (Exception ex)
                {
                    cn.Close();
                    ListaIngresos = null;
                }
            }
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
        public List<AnoFiscalCLS> ListarAnoFiscal()
        {
            List<AnoFiscalCLS> ListaAno = new List<AnoFiscalCLS>();
            ListaAno.Add(new AnoFiscalCLS
            {
                AnoFiscal= "01",
                Desde="1/01/2022",
                Hasta ="31/12/2022",
                Estatus ="Actual"

            });
            ListaAno.Add(new AnoFiscalCLS
            {
                AnoFiscal = "02",
                Desde = "1/01/2023",
                Hasta = "31/12/2023",
                Estatus = "ABIERTO"

            });
            return ListaAno;
        }
    

    public List<EntradaIngresoCLS> ListarEntradaIngreso()
    {
        List<EntradaIngresoCLS> ListaEntradaIngreso = new List<EntradaIngresoCLS>();
            ListaEntradaIngreso.Add(new EntradaIngresoCLS
            {
            Clasificaficador="151504",
            Detalle= "LOCALES Y CASETAS A BUHONEROS",
            DescResumida= "BUHONEROS"

            });
            ListaEntradaIngreso.Add(new EntradaIngresoCLS
                {
                Clasificaficador = "151314",
                Detalle = "Inhamacion y echumacion",
                DescResumida = "Inh/exhaumac"

            });
            ListaEntradaIngreso.Add(new EntradaIngresoCLS
            {
                Clasificaficador = "114333",
                Detalle = "Licencias de construccion",
                DescResumida = "Lic. Const"

            });
            ListaEntradaIngreso.Add(new EntradaIngresoCLS
            {
                Clasificaficador = "151516",
                Detalle = "Matanzas y espendio de carnes",
                DescResumida = "Matanza"

            });
            ListaEntradaIngreso.Add(new EntradaIngresoCLS
            {
                Clasificaficador = "142503",
                Detalle = "Ordinaria segun la Ley",
                DescResumida = "Ord. 40%"

            });
            return ListaEntradaIngreso;
    }
        public List<TiposRetencionesCLS> ListarTiposRetenciones()
        {
            List<TiposRetencionesCLS> ListaTiposRetenciones = new List<TiposRetencionesCLS>();
            ListaTiposRetenciones.Add(new TiposRetencionesCLS
            {
                Codigo = "1",
                Detalle = "N/A",
                TipoRetencion = "",
                Operacion ="",
                Valor = "",
                Calculada = "",
                ModoAfecta = "",
                Beneficiario = ""
            });
            ListaTiposRetenciones.Add(new TiposRetencionesCLS
            {
                Codigo = "2",
                Detalle = "Afp",
                TipoRetencion = "Proceso",
                Operacion = "N/A",
                Valor = "",
                Calculada = "",
                ModoAfecta = "Restando",
                Beneficiario = "Tesoreria de la seguridad social"

            });
            ListaTiposRetenciones.Add(new TiposRetencionesCLS
            {
                Codigo = "3",
                Detalle = "Ars",
                TipoRetencion = "Proceso",
                Operacion = "N/A",
                Valor = "",
                Calculada = "",
                ModoAfecta = "Restando",
                Beneficiario = "Tesoreria de la seguridad social"

            });
            ListaTiposRetenciones.Add(new TiposRetencionesCLS
            {
                Codigo = "4",
                Detalle = "Imp./Renta",
                TipoRetencion = "Proceso",
                Operacion = "Multiplicar",
                Valor = "0.50",
                Calculada = "S",
                ModoAfecta = "Restando",
                Beneficiario = "Direccion General de Imp. Internos"

            });
            ListaTiposRetenciones.Add(new TiposRetencionesCLS
            {
                Codigo = "5",
                Detalle = "10% Alquileres",
                TipoRetencion = "Proceso",
                Operacion = "Multiplicar",
                Valor = "10.00",
                Calculada = "S",
                ModoAfecta = "Restando",
                Beneficiario = "Direccion General de Imp. Internos"

            });
            return ListaTiposRetenciones;
        }
        public List<DestinoGastoCLS> ListarDestinoGasto()
        {
            List<DestinoGastoCLS> ListaDestinoGasto = new List<DestinoGastoCLS>();
            ListaDestinoGasto.Add(new DestinoGastoCLS
            {
                Codigo = "1",
                DestinoGasto="INTERNET"
               
            });
            ListaDestinoGasto.Add(new DestinoGastoCLS
            {
                Codigo = "2",
                DestinoGasto = "Cta. por Pagar"


            });
            ListaDestinoGasto.Add(new DestinoGastoCLS
            {
                Codigo = "3",
                DestinoGasto = "Nomina Cheque"

            });
            ListaDestinoGasto.Add(new DestinoGastoCLS
            {
                Codigo = "4",
                DestinoGasto = "Nomina Banco"
               

            });
            ListaDestinoGasto.Add(new DestinoGastoCLS
            {
                Codigo = "5",
                DestinoGasto ="Tranferencias"
                

            });
            return ListaDestinoGasto;
        }
        public List<GruposPagoCLS> ListarGruposPago()
        {
            List<GruposPagoCLS> ListaGruposPago = new List<GruposPagoCLS>();
            ListaGruposPago.Add(new GruposPagoCLS
            {
                Codigo= "1",
                Descripcion ="Combustible",
                Estatus = "A",
                FechaIni = "1/03/2022",
                FechaFin = "",
                UsuarioCrea ="Supervisor"

            });
            return ListaGruposPago;
        }
        public List<BeneficiarioCLS> ListarBeneficiario()
        {
            List<BeneficiarioCLS> ListaBeneficiario = new List<BeneficiarioCLS>();
            ListaBeneficiario.Add(new BeneficiarioCLS
            {
                Codigo = "188",
                Beneficiario="Alcide Rosado Rosado",
                Cedula = "04800810808",
                Tipo = "Empleado",
                Contacto="Depto. RRHH",
                Telefono = "",
                Telefono1= ""
                

            });
            ListaBeneficiario.Add(new BeneficiarioCLS
            {
                Codigo = "192",
                Beneficiario = "ALEJANDRO DIAZ ARIAS",
                Cedula = "4800425219",
                Tipo = "Empleado",
                Contacto = "Depto. RRHH",
                Telefono = "",
                Telefono1 = ""

            });
            ListaBeneficiario.Add(new BeneficiarioCLS
            {
                Codigo = "121",
                Beneficiario = "ALEJANDRO DIAZ ARIAS",
                Cedula = "04800425219",
                Tipo = "Empleado",
                Contacto = "Depto. RRHH",
                Telefono = "",
                Telefono1 = ""

            });
            ListaBeneficiario.Add(new BeneficiarioCLS
            {
                Codigo = "170",
                Beneficiario = "ALEJANDRO ROQUE SERRADO",
                Cedula = "08700107819",
                Tipo = "Empleado",
                Contacto = "Depto. RRHH",
                Telefono = "",
                Telefono1 = ""

            });
            ListaBeneficiario.Add(new BeneficiarioCLS
            {
                Codigo = "110",
                Beneficiario = "ALEJO ABREU",
                Cedula = "000000000000110",
                Tipo = "Empleado",
                Contacto = "Depto. RRHH",
                Telefono = "",
                Telefono1 = ""

            });

            return ListaBeneficiario;
        }
        public List<BeneficiariosGruposCLS> ListarBeneficiariosGrupos()
        {
            List<BeneficiariosGruposCLS> ListaBeneficiariosGrupos = new List<BeneficiariosGruposCLS>();
            ListaBeneficiariosGrupos.Add(new BeneficiariosGruposCLS
            {
                Codigo = "110",
                Beneficiario = "ALEJO ABREU",
                Cedula = "04800550735",
                GrupoPago = "Combustible",
                Cargo = "Director Contabilidad",
                Valor = "1,500.00",
                


            });


            return ListaBeneficiariosGrupos;
        }
        public List<ComprobantesIngresosCLS> ListarComprobantesIngresos()
        {
            List<ComprobantesIngresosCLS> ListaComprobantesIngresos = new List<ComprobantesIngresosCLS>();
            ListaComprobantesIngresos.Add(new ComprobantesIngresosCLS
            {
                Comprobante = "2000001",
                Fecha = "05/05/2022",
                Etapa="Ingreso",
                Recibo = "2000001",
                Contribuyente = "Liga Municipal Dominicana",
                Detalle = "Resumen De Ingresos 05/05/2022",
                Valor = "16,000.00",
            });
            ListaComprobantesIngresos.Add(new ComprobantesIngresosCLS
            {
                Comprobante = "200002",
                Fecha = "09/05/2022",
                Etapa = "Ingreso",
                Recibo = "2000002",
                Contribuyente = "Liga Municipal Dominicana",
                Detalle = "Resumen De Ingresos 09/05/2022",
                Valor = "70.00",
            });
            ListaComprobantesIngresos.Add(new ComprobantesIngresosCLS
            {
                Comprobante = "2100001",
                Fecha = "12/01/2022",
                Etapa = "Ingreso",
                Recibo = "2100001",
                Contribuyente = "Catalina Peña",
                Detalle = "Recoleccion de desechos Solidos",
                Valor = "500.00",
            });
            ListaComprobantesIngresos.Add(new ComprobantesIngresosCLS
            {
                Comprobante = "2100002",
                Fecha = "18/01/2022",
                Etapa = "Ingreso",
                Recibo = "2100002",
                Contribuyente = "Brenda Espinal",
                Detalle = "Recogida de desechos solidas",
                Valor = "1,000.00",
            });
            ListaComprobantesIngresos.Add(new ComprobantesIngresosCLS
            {
                Comprobante = "2100003",
                Fecha = "22/01/2022",
                Etapa = "Ingreso",
                Recibo = "2100003",
                Contribuyente = "Grupo super alba",
                Detalle = "Recogida de desechos solidas",
                Valor = "5,000.00",
            });
            return ListaComprobantesIngresos;
        }
        public List<ComprobantesGastosCLS> ListarComprobantesGastos()
        {
            List<ComprobantesGastosCLS> ListaComprobantesGastos = new List<ComprobantesGastosCLS>();
            ListaComprobantesGastos.Add(new ComprobantesGastosCLS
            {
                Comprobante = "2000001",
                Fecha = "05/04/2022",
                Etapa = "Devengado",
                Pago = "Cheque",
                Beneficiario = "Angela Guillermina Aquino",
                Cuenta = "01 Cuenta General",
                Bruto= "250,000.00",
                Retencion = "",
                Valor = "250,000.00",
                No = ""

            });
            ListaComprobantesGastos.Add(new ComprobantesGastosCLS
            {
                Comprobante = "2000002",
                Fecha = "31/01/2022",
                Etapa = "Devengado",
                Pago = "Cheque",
                Beneficiario = "Ayuntamiento municipal de villa",
                Cuenta = "01 Cuenta General",
                Bruto = "11,540,657.27",
                Retencion = "",
                Valor = "11,540,657.2",
                No = ""
            });
            ListaComprobantesGastos.Add(new ComprobantesGastosCLS
            {
                Comprobante = "2000003",
                Fecha = "31/01/2022",
                Etapa = "Pagado",
                Pago = "Cheque",
                Beneficiario = "Ayuntamiento municipal de villa",
                Cuenta = "01 Cuenta General",
                Bruto = "11,540,657.27",
                Retencion = "",
                Valor = "11,540,657.2",
                No = ""
            });
            ListaComprobantesGastos.Add(new ComprobantesGastosCLS
            {
                Comprobante = "2000002",
                Fecha = "31/01/2022",
                Etapa = "Devengado",
                Pago = "Transferencia",
                Beneficiario = "Charles Rafael Tavarez Arias",
                Cuenta = "01 Cuenta General",
                Bruto = "707,000.00",
                Retencion = "",
                Valor = "707,000.00",
                No = ""
            });
            ListaComprobantesGastos.Add(new ComprobantesGastosCLS
            {
                Comprobante = "2000002",
                Fecha = "31/01/2022",
                Etapa = "Devengado",
                Pago = "Transferencia",
                Beneficiario = "Charles Rafael Tavarez Arias",
                Cuenta = "01 Cuenta General",
                Bruto = "707,000.00",
                Retencion = "30,932.81",
                Valor = "676,067.19",
                No = "Cks. Nomina"
            });
            return ListaComprobantesGastos;
        }
                public List<CategoriaCLS> ListarCategoria()
        {
            List<CategoriaCLS> ListaCategoria = new List<CategoriaCLS>();
            ListaCategoria.Add(new CategoriaCLS
            {
                codigo= "1",
                Descripcion = "Edificios y Oficinas",
                CuentaGasto = "1",
                Acumulado = "1"

            });
            ListaCategoria.Add(new CategoriaCLS
            {
                codigo= "2",
                Descripcion = "Terrenos",
                CuentaGasto = "1",
                Acumulado = "1"

            });
            ListaCategoria.Add(new CategoriaCLS
            {
                codigo= "3",
                Descripcion = "Infraestructura",
                CuentaGasto = "1",
                Acumulado = "1"

            });
            ListaCategoria.Add(new CategoriaCLS
            {
                codigo= "4",
                Descripcion = "Vehiculo Livianos",
                CuentaGasto = "1",
                Acumulado = "1",
                Corte="160,847.18",
                Monto="160,847.18",
                Despreciable ="S"

            });
            ListaCategoria.Add(new CategoriaCLS
            {
                codigo= "5",
                Descripcion = "Vehiculo de Transporte",
                CuentaGasto = "1",
                Acumulado = "1",
                Corte="80,596.32",
                Monto="80,596.32",
                Despreciable ="S"

            });
            return ListaCategoria;
        }
                public List<AreasCLS> ListarAreas()
        {
            List<AreasCLS> ListaAreas = new List<AreasCLS>();
            ListaAreas.Add(new AreasCLS
            {
                Codigo = "1",
                Descripcion ="Activo Fijo"
            });
            ListaAreas.Add(new AreasCLS
            {
                Codigo = "2",
                Descripcion ="Aduanas y Exoneraciones"
            });
            ListaAreas.Add(new AreasCLS
            {
                Codigo = "3",
                Descripcion ="Almacen"
            });
            ListaAreas.Add(new AreasCLS
            {
                Codigo = "4",
                Descripcion ="Archivo y Correpondencia"
            });
            ListaAreas.Add(new AreasCLS
            {
                Codigo = "5",
                Descripcion ="Asesoria de Construcciones Mun"
            });
            return ListaAreas;
        }
        public List<MarcasCLS> ListarMarcas()
        {
            List<MarcasCLS> ListaMarcas = new List<MarcasCLS>();
            ListaMarcas.Add(new MarcasCLS
            {
                codigo = "1",
                Marca= "N/A"
            });
            return ListaMarcas;
        }
        public List<ClasificadorGastoCLS> ListarClasificadorGasto()
        {
            List<ClasificadorGastoCLS> ListaClasificadorGasto = new List<ClasificadorGastoCLS>();
            ListaClasificadorGasto.Add(new ClasificadorGastoCLS
            {
                Codigo ="2114",
                Denominacion = "Regalalia Pascual"
            });
            ListaClasificadorGasto.Add(new ClasificadorGastoCLS
            {
                Codigo = "211101",
                Denominacion = "Sueldo Fijos"
            });
            ListaClasificadorGasto.Add(new ClasificadorGastoCLS
            {
                Codigo = "211201",
                Denominacion = "Sueldos Personal Contracto y/o Igualados"
            });
            ListaClasificadorGasto.Add(new ClasificadorGastoCLS
            {
                Codigo = "211202",
                Denominacion = "Sueldos Personal Nominal"
            });
            ListaClasificadorGasto.Add(new ClasificadorGastoCLS
            {
                Codigo = "211204",
                Denominacion = "Sueldos por  Serv. Especiales"
            });
            return ListaClasificadorGasto;
        }
        public List<GrupoProgramasCLS> ListarGrupoProgramas()
        {
            List<GrupoProgramasCLS> ListaGrupoProgramas = new List<GrupoProgramasCLS>();
            ListaGrupoProgramas.Add(new GrupoProgramasCLS
            {
                Codigo = "01",
                Descripcion = "Personal Fijo"
            });
            ListaGrupoProgramas.Add(new GrupoProgramasCLS
            {
                Codigo = "02",
                Descripcion = "Contratados"
            });
            ListaGrupoProgramas.Add(new GrupoProgramasCLS
            {
                Codigo = "03",
                Descripcion = "Proceso De Pension"
            });
            return ListaGrupoProgramas;
        }
        public List<ProgramasCLS> ListarProgramas()
        {
            List<ProgramasCLS> ListaProgramas = new List<ProgramasCLS>();
            ListaProgramas.Add(new ProgramasCLS
            {
                Codigo = "01",
                Programa = "1-COMITE EJECUTIVO",
                EstructuraProgram= "00010000003",
                Activo="S"
            });
            ListaProgramas.Add(new ProgramasCLS
            {
                Codigo = "02",
                Programa = "2-SECRETARIA GENERAL",
                EstructuraProgram = "00010000003",
                Activo = "S"
            });
            ListaProgramas.Add(new ProgramasCLS
            {
                Codigo = "03",
                Programa = "3-DIRECCION JURIDICA",
                EstructuraProgram = "00010000003",
                Activo = "S"
            });
            ListaProgramas.Add(new ProgramasCLS
            {
                Codigo = "03",
                Programa = "4-DIRECCION DE COMUNICACIONES",
                EstructuraProgram = "00010000003",
                Activo = "S"
            });
            ListaProgramas.Add(new ProgramasCLS
            {
                Codigo = "03",
                Programa = "5-SUB-SEC. DE PLAN Y DES. INSTITUCIONAL",
                EstructuraProgram = "00010000003",
                Activo = "S"
            });
            return ListaProgramas;
        }
        public List<DepartamentoCLS> ListarDepartamento()
        {
            List<DepartamentoCLS> ListaMarcas = new List<DepartamentoCLS>();
            ListaMarcas.Add(new DepartamentoCLS
            {
                Codigo= "1",
                Departamento ="1-Comite Ejecutico",
                Programa = "1-Comite Ejecutico",
                GrupoNomina = "",
                EstructuraProg = "00010000003",
            });
            ListaMarcas.Add(new DepartamentoCLS
            {
                Codigo = "2",
                Departamento = "2-Secretaria General",
                Programa = "2-Secretaria General",
                GrupoNomina = "",
                EstructuraProg = "00010000003",
            });
            ListaMarcas.Add(new DepartamentoCLS
            {
                Codigo = "3",
                Departamento = "3-Direccion Juridica",
                Programa = "3-Direccion Juridica",
                GrupoNomina = "",
                EstructuraProg = "00010000003",
            });
            ListaMarcas.Add(new DepartamentoCLS
            {
                Codigo = "4",
                Departamento = "4-Direccion De Comunicaciones",
                Programa = "4-Direccion De Comunicaciones",
                GrupoNomina = "",
                EstructuraProg = "00010000003",
            });
            ListaMarcas.Add(new DepartamentoCLS
            {
                Codigo = "5",
                Departamento = "5-Sub-Sec. De La Relaciones Int.",
                Programa = "5-Sub-Sec. De La Relaciones Int.",
                GrupoNomina = "",
                EstructuraProg = "00010000003",
            });
            return ListaMarcas;
        }
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

