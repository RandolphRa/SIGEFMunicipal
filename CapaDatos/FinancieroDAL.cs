using CapaEntidad;

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
                CLASIFICADOR = 11,
                DESCRIPCION = "IMPUESTOS",
                CUENTA_CONTROL = 11,
                TIPO = "GENERAL",
                CLASIFICACION = "INGRESOS",
                CTA_CONTABLE = 345345345
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 2,
                CLASIFICADOR = 111,
                DESCRIPCION = "IMPUESTOS SOBRE LOS INGRESOS",
                CUENTA_CONTROL = 111,
                TIPO = "GENERAL",
                CLASIFICACION = "INGRESOS",
                CTA_CONTABLE = 1565452323
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 3,
                CLASIFICADOR = 1111,
                DESCRIPCION = "IMPUESTOS SOBRE EL PATRIMONIO",
                CUENTA_CONTROL = 1111,
                TIPO = "DETALLE",
                CLASIFICACION = "INGRESOS",
                CTA_CONTABLE = 1212523365
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 4,
                CLASIFICADOR = 111,
                DESCRIPCION = "IMPUESTOS SOBRE LA PROPIEDAD",
                CUENTA_CONTROL = 111,
                TIPO = "DETALLE",
                CLASIFICACION = "INGRESOS",
                CTA_CONTABLE = 1212523365
            });
            

            return listaUsuarios;
        
        }
        public List<FinancieroProgramaticaCLS> ListarEtsProgramatico()
        {
            List<FinancieroProgramaticaCLS> listProgramatico = new List<FinancieroProgramaticaCLS>();
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id=1,
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
                id=1,
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
                id=2,
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
                id=3,
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
                id=1,
                codigo=0332,
                fuente =60,
                denominacion= "TERMOELECTRICA BARAHONA"


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
