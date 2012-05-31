using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ListCodeKata
{
    /// <summary>
    /// Clase que representa un nodo simplemente enlazado
    /// </summary>
    class Nodo
    {
        public string texto { get; set; }
        public Nodo next { get; set; }
        //Constructor
        public Nodo(string texto)
        {
            this.texto = texto;
            next = this;
        }
        public Nodo()
        {
            this.texto = string.Empty;
            next = null;
        }

        /// <summary>
        /// metodo que comprara el valor del texto pasado como parametro con el valor del campo texto de este f
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public Boolean Contains(string texto)
        {
            if (this.texto == texto)
                return true;            
            return false;
        }
        
        /// <summary>
        /// Pone a el campo next a null y texto a string.empty 
        /// </summary>
        public  void Dispose()
        {
            this.texto = null;
            next = null;
        }
        
    }
}
