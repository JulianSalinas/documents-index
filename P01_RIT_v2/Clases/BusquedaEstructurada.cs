﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace P01_RIT_v2.Clases
{
    [Serializable]
    public class BusquedaEstructurada
    {
        /// <summary>
        /// Fecha y hora de la consulta estructurada.
        /// </summary>
        public DateTime FechaHoraBusquedaEstructurada;

        /// <summary>
        /// Ruta del archivo con el escalafón de la consulta vectorial utilizada.
        /// </summary>
        public string RutaBusquedaVectorial;

        /// <summary>
        /// Ruta del archivo donde se almacena la búsqueda estructurada (si esta ha sido exportada o importada).
        /// </summary>
        [NonSerialized]
        private string RutaBusquedaEstructurada;

        /// <summary>
        /// Lista de cláusulas de la consulta estructurada.
        /// </summary>
        public List<ClausulaEstructurada> ClausulasConsulta;

        /// <summary>
        /// Fecha y hora de la consulta vectorial utilizada.
        /// </summary>
        public DateTime FechaHoraBusquedaVectorial;

        /// <summary>
        /// Ruta de la colección de documentos del escalafón vectorial utilizado.
        /// </summary>
        public string RutaColeccionDocumentos;

        /// <summary>
        /// Consulta vectorial en bruto del escalafón vectorial utilizado.
        /// </summary>
        public string ConsultaVectorial;

        /// <summary>
        /// Ranking de documentos utilizados para la consulta estructurada.
        /// </summary>
        public List<RankingDocumento> RankingDocumentos;
   
        public BusquedaEstructurada()
        {
            FechaHoraBusquedaEstructurada = System.DateTime.Now;
            RutaBusquedaEstructurada = "";

            FechaHoraBusquedaVectorial = System.DateTime.Now;
            RutaBusquedaVectorial = "";
            ConsultaVectorial = "";

            RutaColeccionDocumentos = "";

            ClausulasConsulta = new List<ClausulaEstructurada>();
            RankingDocumentos = new List<RankingDocumento>();
        }

        public BusquedaEstructurada(string rutaArchivoConsultaVectorial, string consultaEstructurada)
        {
            FechaHoraBusquedaEstructurada = System.DateTime.Now;
            RutaBusquedaEstructurada = "";

            ClausulasConsulta = new List<ClausulaEstructurada>();
            importarConsultaVectorial(rutaArchivoConsultaVectorial);

            ejecutar(consultaEstructurada);
        }

        public BusquedaEstructurada(BusquedaVectorial consultaVectorial, string consultaEstructurada)
        {
            FechaHoraBusquedaEstructurada = System.DateTime.Now;
            RutaBusquedaEstructurada = "";

            ClausulasConsulta = new List<ClausulaEstructurada>();
            importarConsultaVectorial(consultaVectorial);

            ejecutar(consultaEstructurada);
        }

        /// <summary>
        /// Importa el contenido de un archivo XML con la consulta vectorial a utilizar.
        /// </summary>
        /// <param name="busquedaVectorial">Consulta vectorial importada.</param>
        private void importarConsultaVectorial(BusquedaVectorial busquedaVectorial)
        {
            
            RutaBusquedaVectorial = busquedaVectorial.RutaBusquedaVectorial;
            FechaHoraBusquedaVectorial = busquedaVectorial.FechaHoraBusqueda;
            RutaColeccionDocumentos = busquedaVectorial.RutaDocumentos;
            ConsultaVectorial = busquedaVectorial.Consulta;

            RankingDocumentos = new List<RankingDocumento>(busquedaVectorial.RankingDocumentos);
        }

        /// <summary>
        /// Importa el contenido de un archivo XML con la consulta vectorial a utilizar.
        /// </summary>
        /// <param name="rutaArchivo">Ruta absoluta del archivo.</param>
        private void importarConsultaVectorial(string rutaArchivo)
        {
            BusquedaVectorial consultaImportada = BusquedaVectorial.importarDesdeXml(rutaArchivo, true);
            importarConsultaVectorial(consultaImportada);
        }

        /// <summary>
        /// Revisa un documento del escalafón para saber si cumple la cláusula.
        /// </summary>
        /// <param name="rankingDocumento">Documento en escalafón.</param>
        /// <param name="clausula">Cláusula para evaluar el documento.</param>
        /// <returns>True si el documento contiene la estructura consultada. False en caso contrario.</returns>
        private bool revisarDocumento(RankingDocumento rankingDocumento, ClausulaEstructurada clausula)
        {
            Documento documento = new Documento(rankingDocumento.IdDocumento, rankingDocumento.RutaDocumento);
            documento.cargarDocumento();

            // Obtiene todos los valores del atributo "name" para las etiquetas "biological_entity"
            List<string> bioEntitiesDocumento = documento.getBiologicalEntitiesNames();
            foreach (string bioEntityNameDoc in bioEntitiesDocumento)
            {
                // Coincide el "name" de "biological_entity".
                if (bioEntityNameDoc.ToLower().Equals(clausula.BiologicalEntity))
                {
                    // La consulta tiene más de un término.
                    if (!clausula.CharacterName.Equals(""))
                    {
                        List<string[]> charactersBioEntity = documento.getBiologicalEntityCharacters(bioEntityNameDoc);
                        foreach (string[] characterBioEntity in charactersBioEntity)
                        {
                            // Hay coincidencia en el atributo "name" de "character".
                            if (characterBioEntity[0].ToLower().Equals(clausula.CharacterName))
                            {
                                // La cláusula tiene tres términos.
                                if (!clausula.CharacterValue.Equals(""))
                                {
                                    // La consulta tiene coincidencia en el atributo "value" de "character".
                                    if (characterBioEntity[1].ToLower().Equals(clausula.CharacterValue))
                                    {
                                        return true;
                                    }
                                }
                                else
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Divide la cláusula
        /// </summary>
        /// <param name="clausulaEncontrada"></param>
        /// <returns></returns>
        private ClausulaEstructurada procesarClausula(string clausulaEncontrada)
        {
            // Se convierten a minúsculas para quitar sensibilidad a mayúsculas/minúsculas.
            clausulaEncontrada = clausulaEncontrada.ToLower();

            string[] terminosClausula = clausulaEncontrada.Split(' ');
            if (terminosClausula.Length < 1)
            {
                throw new Exception("La cláusula recibir tiene un formato inválido y no puede ser procesada.");
            }
            else
            {
                ClausulaEstructurada nuevaClausula = new ClausulaEstructurada(terminosClausula[0]);
                if (terminosClausula.Length > 1)
                {
                    nuevaClausula.CharacterName = terminosClausula[1];
                }
                if (terminosClausula.Length > 2)
                {
                    nuevaClausula.CharacterValue = terminosClausula[2];
                }

                return nuevaClausula;
            }
        }

        /// <summary>
        /// Procesa la consulta estructurada en bruto para obtener las cláusulas válidas.
        /// </summary>
        /// <param name="consulta">Consulta en bruto recibida.</param>
        private void procesarConsulta(string consulta)
        {
            string patronSeparador = @"\,\s*";
            Regex regExSeparador = new Regex(patronSeparador, RegexOptions.Compiled);
            consulta = regExSeparador.Replace(consulta, ", ");

            // RegEx para separa términos de clausulas en grupos de 1 a 3 términos.
            string patronSeparadorClausulas = @"((\d*\d\,?\d+)|(\w+))(\s((\d*\d\,?\d+)|(\w+))){0,2}";
            Regex regExSeparadorClausulas = new Regex(patronSeparadorClausulas, RegexOptions.Compiled);

            MatchCollection matches = regExSeparadorClausulas.Matches(consulta);
            foreach (Match match in matches)
            {
                string clausulaEncontrada = match.Value;
                ClausulaEstructurada nuevaClausula = procesarClausula(clausulaEncontrada);
                ClausulasConsulta.Add(nuevaClausula);
            }
        }

        /// <summary>
        /// Elimina las entradas del escalafón que no cumplen con las cláusulas de la consulta estructurada.
        /// </summary>
        public void filtrarEscalafon()
        {
            // Recorrido para cada cláusula procesada.
            foreach(ClausulaEstructurada clausula in ClausulasConsulta)
            {
                // Elimina todos los documentos en el escalafón que no cumplen la cláusula actual.
                RankingDocumentos.RemoveAll(ranking => !revisarDocumento(ranking, clausula));
            }
        }

        
        public void ejecutar(string consultaEnBruto)
        {
            // Procesa la consulta en bruto para generar las cláusulas de filtrado de la consulta estructurada.
            procesarConsulta(consultaEnBruto);
            // Luego filtra el escalafón, eliminando los documentos que no cumplan las cláusulas obtenidas.
            filtrarEscalafon();

        }


        /// <summary>
        /// Exporta los resultados de la búsqueda vectorial a un archivo XML.
        /// </summary>
        /// <param name="nombreArchivoPostings">
        /// Nombre del archivo XML que será creado.
        /// Si no se ingresa un nombre se utiliza la fecha y hora del sistema y el archivo será guardado en la carpeta por defecto (...\\Archivos).
        /// </param>
        /// <param name="rutaAbsoluta">
        /// Parámetro opcional para indicar si se utiliza una ruta absoluta. True para usar una ruta absoluta, False para usar una ruta relativa.
        /// Utilizar una ruta relativa implica que el archivo será guardado en la carpeta por defecto (...\\Archivos) y no se debe agregar la extensión (*.xml).
        /// Utilizar una ruta absoluta debe incluir la extensión del archivo.
        /// </param>
        public void exportarComoXml(string rutaArchivo, bool rutaAbsoluta = false)
        {
            RutaBusquedaEstructurada = EntradaSalidaXml.exportarComoXml(this, rutaArchivo, rutaAbsoluta);
        }

        /// <summary>
        /// Importa el contenido de un archivo XML para generar el resultado de una búsqueda vectorial.
        /// </summary>
        /// <param name="rutaArchivo">
        /// Ruta del archivo que será abierto.
        /// </param>
        /// <param name="rutaAbsoluta">
        /// Indica si se utiliza una ruta absoluta (completa) de archivo. True para usar una ruta absoluta o false para usar una ruta relativa.
        /// Si utiliza una ruta relativa implica que el archivo ingresado está guardado en la carpeta por defecto (...\\Archivos).
        /// Si utiliza una ruta absoluta debe incluir la extensión del archivo.
        /// </param>
        /// <returns>
        /// Resultado de búsqueda vectorial importado.
        /// </returns>
        public static BusquedaEstructurada importarDesdeXml(string rutaArchivo, bool rutaAbsoluta = false)
        {
            BusquedaEstructurada busquedaImportada = EntradaSalidaXml.importarDesdeXml<BusquedaEstructurada>(rutaArchivo, rutaAbsoluta);
            if (!rutaAbsoluta)
            {
                rutaArchivo = Opciones.Instance.RutaArchivos + rutaArchivo;
            }

            busquedaImportada.RutaBusquedaEstructurada = rutaArchivo;
            return busquedaImportada;
        }

        /// <summary>
        /// Genera un archivo HTML con el resultado de una búsqueda estructurada.
        /// </summary>
        /// <param name="nombreArchivoPostings">
        /// Nombre del archivo XML que será creado.
        /// Si no se ingresa un nombre se utiliza la fecha y hora del sistema y el archivo será guardado en la carpeta por defecto (...\\Archivos).
        /// </param>
        /// <param name="usarRutaAbsoluta">
        /// Parámetro opcional para indicar si se utiliza una ruta absoluta. True para usar una ruta absoluta, False para usar una ruta relativa.
        /// Utilizar una ruta relativa implica que el archivo será guardado en la carpeta por defecto (...\\Archivos) y no se debe agregar la extensión (*.xml).
        /// Utilizar una ruta absoluta debe incluir la extensión del archivo.
        /// </param>
        public void generarHTML()
        {
            // Información básica del HTML.
            string strFechaHoraBusquedaEstruct = FechaHoraBusquedaEstructurada.ToString("dd/MM/yyyy hh:mm:ss.fff tt");
            string strFechaHoraBusquedaVect = FechaHoraBusquedaVectorial.ToString("dd/MM/yyyy hh:mm:ss.fff tt");
            string strRutaDocumentos = RutaColeccionDocumentos;
            string strConsulaVectorial = ConsultaVectorial;

            // Contenido de cada cláusula usada en la búsqueda estructurada.
            List<string[]> clausulas = new List<string[]>();
            foreach (ClausulaEstructurada clausula in ClausulasConsulta)
            {
                // Formato de cada entrada de las cláusulas utilizadas:
                clausulas.Add(new string[] { clausula.BiologicalEntity, clausula.CharacterName, clausula.CharacterValue });
            }

            // Obtiene la información de los primeros 30 elementos del escalafón.
            List<string[]> top30 = new List<string[]>();

            int longitudEscalafon = (RankingDocumentos.Count < 30) ? RankingDocumentos.Count : 30;

            for (int pos = 0; pos < longitudEscalafon; pos++)
            {
                RankingDocumento rankingObtenido = RankingDocumentos[pos];
                string strPosicion = rankingObtenido.Posicion.ToString();
                string strSimilitud = rankingObtenido.Similitud.ToString("F3");
                string strDocId = rankingObtenido.IdDocumento.ToString();
                string strTaxonName = rankingObtenido.TaxonNameDocumento;
                string strTaxonRank = rankingObtenido.TaxonRank;

                Documento documento = new Documento(rankingObtenido.IdDocumento, rankingObtenido.RutaDocumento);
                documento.cargarDocumento();

                string strTaxonDescription = documento.getTaxonDescription(true);

                // Formato de cada entrada del escalafón para las primeras 30 posiciones.
                top30.Add(new string[] { strPosicion, strSimilitud, strDocId, strTaxonName, strTaxonRank, strTaxonDescription });
            }

            // Generar el html
            string html = "<head><meta charset =\"UTF-8\"></head><h1>Consulta estructurada</h1><pre>";
            html += "Fecha de la consulta estructurada: \t" + strFechaHoraBusquedaEstruct + "\n";
            html += "Fecha de la consulta vectorial: \t" + strFechaHoraBusquedaVect + "\n";
            html += "Ruta de la coleccion consultada: \t" + strRutaDocumentos + "\n";
            html += "Texto de la consulta: \t" + strConsulaVectorial + "\n";
            html += "Listas de cláusulas de la consulta: \n";
            foreach (string[] clausula in clausulas) {
                html += "Bilogical entity: " + clausula[0] + "\n";
                html += "Character Name: " + clausula[1] + "\n";
                html += "Character Value: " + clausula[2] + "\n";
            }
            foreach (string[] doc in top30) { 
                html += "\nID del documento: " + doc[2] + "\n";
                html += "Posicion obtenida: " + doc[0] + "\n";
                html += "Similitud: " + doc[1] + "\n";
                html += "Taxon Name: " + doc[3] + "\n";
                html += "Taxon Rank: " + doc[4] + "\n";
                html += "Taxon Description:\n" + doc[5] + "\n";
            }
            html += "</pre>";

            try {
                string fullpath =
                    Opciones.Instance.RutaConsultas +
                    Opciones.Instance.Prefijo + " Busqueda Estruc " + DateTime.Now.ToString() +".html";
                StreamWriter file = new StreamWriter(fullpath);
                file.WriteLine(html);
                file.Close();
            }
            catch ( Exception e ) {
                throw new Exception("No se ha podido crear el archivo html: \n" + e.Message);
            }


        }
    }

    /// <summary>
    /// Clase para almacenar consulta estructurada.
    /// </summary>
    [Serializable]
    public class ClausulaEstructurada
    {
        public string BiologicalEntity;
        public string CharacterName;
        public string CharacterValue;

        public ClausulaEstructurada()
        {
            BiologicalEntity = "";
            CharacterName = "";
            CharacterValue = "";
        }

        public ClausulaEstructurada(string biologicalEntity, string characterName = "", string characterValue = "")
        {
            BiologicalEntity = biologicalEntity;
            CharacterName = characterName;
            CharacterValue = characterValue;
        }
    }
}