using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLibro
{

    public class Libro
    {
        private string titulo;
        List<Hoja> hojasLibro;

        public Libro()
        {
            this.hojasLibro = new List<Hoja>();
            this.hojasLibro.Add(new Hoja(1));
            this.hojasLibro.Add(new Hoja(1));
            for (int numero = 0; numero < 10; numero++)
            {
                this.hojasLibro.Add(new Hoja(numero));
            }
        }


        /// <summary>
        /// Titulo del libro.
        /// </summary>
        /// <remarks>
        /// set: 
        /// El título del libro no puede tomar un valor nulo ni vacío, 
        /// entiéndase vacío como un string del largo cero.
        /// En caso de no cumplir con la validación solicitada 
        /// debe lanzarse una excepción “throw new Exception()”.
        /// 
        /// get: 
        /// La lectura de la propiedad debe ser libre.
        /// </remarks>
        public string Titulo
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("No existe titulo.");
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }



        /// <summary>
        /// Hojas del libro.
        /// </summary>
        public List<Hoja> Hojas
        {
            get
            {
                return hojasLibro;
            }
        }

        /// <summary>
        /// Busca aquellas hojas que contengan el texto indicado 
        /// y colorea los renglones que contienen el texto.
        /// </summary>
        /// <param name="buscado">
        /// Texto a buscar.
        /// </param>       
        /// <param name="colorear">
        /// Indica si desea colorear el renglón que contiene el texto encontrado.
        /// </param>
        /// <remarks>
        /// Si el parámetro vale nulo (null) el método debe 
        /// retornar un una lista con cero ítems.
        /// </remarks>
        /// <returns>
        /// Lista de hojas que contienen el texto buscado, en caso de 
        /// no encontrarlo debe retornar una lista con cero ítems, 
        /// nunca retorna null.
        /// </returns>
        public List<Hoja> Buscar(string buscado, bool colorear)
        {
            List<Hoja> auxHojas = new List<Hoja>();
            bool textoEncontrado;
            if (buscado != null)
                foreach (Hoja hojita in this.hojasLibro)
                {
                    textoEncontrado = false;
                    foreach (Renglon renglon in hojita.Renglones)
                    {
                        if (renglon.Texto.Contains(buscado))
                        {
                            renglon.Coloreado = colorear;
                            textoEncontrado = true;
                        }
                    }
                    if (textoEncontrado)
                        auxHojas.Add(hojita);
                }

            return auxHojas;

        }


        /// <summary>
        /// Busca aquellas hojas del libro que contengan el texto indicado
        /// sin colorearlas, esto es colorear = false.
        /// </summary>
        /// <param name="buscado">
        /// Texto a buscar.
        /// </param>
        /// <remarks>
        /// Si el parámetro vale nulo (null) el método debe 
        /// retornar un una lista con cero ítems.
        /// </remarks>
        /// <returns>
        /// Lista de hojas que contienen el texto buscado, en caso de 
        /// no encontrarlo debe retornar una lista con cero ítems, 
        /// nunca retorna null.
        /// </returns>
        public List<Hoja> Buscar(string buscado)
        {
            return Buscar(buscado, false);
        }


        /// <summary>
        /// Reemplaza un texto por otro en cada una de las hojas del libro.
        /// </summary>
        /// <param name="buscado">
        /// Texto a buscar.
        /// </param>
        /// <param name="reemplazo">
        /// Texto de reemplazo.
        /// </param>
        /// <returns>
        /// Lista de hojas que contienen el texto buscado. 
        /// En caso de no encontrarlo debe retornar una lista con cero ítems, 
        /// nunca retorna null.
        /// Si alguno de los parámetros es nulo debe retornar una lista con cero ítems.
        /// </returns>
        public List<Hoja> Reemplazar(string buscado, string reemplazo)
        {
            List<Hoja> auxHojas = new List<Hoja>();
            bool textoEncontrado;
            if (buscado != null && reemplazo != null)
                foreach (Hoja hojita in this.hojasLibro)
                {
                    textoEncontrado = false;
                    foreach (Renglon renglon in hojita.Renglones)
                    {
                        if (renglon.Texto.Contains(buscado))
                        {
                            renglon.Texto = renglon.Texto.Replace(buscado, reemplazo);
                            textoEncontrado = true;
                        }
                    }
                    if (textoEncontrado)
                        auxHojas.Add(hojita);
                }
            return auxHojas;
        }


        /// <summary>
        /// Retorna las hojas del libro que posea la mayor cantidad de renglones.
        /// </summary>
        /// <example>
        /// Si las hojas 2 y 6 contienen 100 renglones y el resto 90 renglones, 
        /// el método debe retornar una lista con dos hojas, la 2 y la 6.
        /// </example>
        /// <returns></returns>
        public List<Hoja> TraerHojasConMasRenglones()
        {
            List<Hoja> auxHojas = new List<Hoja>();

            foreach (Hoja hoja in this.hojasLibro)
            {
                if (auxHojas.Count == 0)
                    auxHojas.Add(hoja);
                else
                {
                    if (auxHojas[0].Renglones.Count < hoja.Renglones.Count)
                    {
                        auxHojas.Clear();
                        auxHojas.Add(hoja);
                    }
                    else
                    {
                        if (auxHojas[0].Renglones.Count == hoja.Renglones.Count)
                        {
                            auxHojas.Add(hoja);
                        }
                    }
                }
            }
            return auxHojas;


        }


        /// <summary>
        /// Elimina las hojas que están repetidas.
        /// Dos hojas están repetidas cunado poseen el mismo número de hoja,
        /// en otras palabras elimina las copias y deja la original.
        /// Por ejemplo si hay 3 hojas repartidas solo deja una, 
        /// eliminando las 2 copias.
        /// </summary>
        /// <returns>
        /// Retorna la lista de hojas que fueron eliminadas. 
        /// En caso de no encontrar hojas repetidas, debe retornar una lista con cero ítems, 
        /// nunca retorna null.
        /// </returns>
        public List<Hoja> EliminarHojasRepetidas()
        {
            List<int> auxHoja = new List<int>();
            List<Hoja> auxEliminadas = new List<Hoja>();

            foreach (Hoja hoja in hojasLibro)
            {
                if (!auxHoja.Contains(hoja.Numero))
                {
                    auxHoja.Add(hoja.Numero);
                }
                else
                {
                    auxEliminadas.Add(hoja);
                }
            }
            foreach (Hoja item in auxEliminadas)
            {
                hojasLibro.Remove(item);
            }
            return auxEliminadas;
        }
    }
}
