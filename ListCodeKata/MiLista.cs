/*
 * http://www.solveet.com/exercises/Kata-Simple-List/15
    
 * Aquí tienes un conjunto básico de pruebas unitarias para ilustrar su comportamiento:
        list = List.new
        assert_nil(list.find("fred"))

        list.add("fred")
        assert_equal("fred", list.find("fred").value())
        assert_nil(list.find("wilma"))

        list.add("wilma")
        assert_equal("fred",  list.find("fred").value())
        assert_equal("wilma", list.find("wilma").value())
        assert_equal(["fred", "wilma"], list.values())

        list = List.new
        list.add("fred")
        list.add("wilma")
        list.add("betty")
        list.add("barney")
        assert_equal(["fred", "wilma", "betty", "barney"], list.values())

        list.delete(list.find("wilma"))
        assert_equal(["fred", "betty", "barney"], list.values())

        list.delete(list.find("barney"))
        assert_equal(["fred", "betty"], list.values())

        list.delete(list.find("fred"))
        assert_equal(["betty"], list.values())

        list.delete(list.find("betty"))
        assert_equal([], list.values())

Para la kata, donde la idea es practicar, vamos a escribir 3 implementaciones de la lista:

    Una lista enlazada (cada nodo tiene una referencia al siguiente nodo)
    Una lista doblemente enlazada (cada nodo tiene una referencia a los nodos anterior y siguiente)
    Cualquier otra implementación a tu elección, salvo que no debes utilizar referencias (punteros) para almacenar las relaciones entre los nodos de la lista.


Obviamente, no debes utilizar clases de tu lenguaje de programación ya existentes, como implementaciones de tus propias listas :)
Objetivos
No hay nada mágico o sorprendente en las implementaciones de las listas, pero hay un buen número de condiciones particulares a su alrededor. Por ejemplo, para eliminar de una lista enlazada simple, tendrás que lidiar con el caso particular de eliminar el primer elemento de la lista.

Para esta kata, concéntrate en la manera de eliminar el mayor número de estas condiciones particulares en la manera de lo posible. Luego pregúntate:
¿Es código resultante que contiene los menos casos particulares posibles más fácil de leer y mantener?
¿Cómo de fácil ha sido eliminar estos casos particulares?
¿Existe algún lugar concreto e interesante cuando se trata de simplificar el código? 
 
    Una lista formada por nodos. Cada noDo tiene un valor de tipo string.
    Los nuevos nodos se añaden al final de la lista.
    Podrás preguntarle a la lista si contiene un string concreto. Si es así, devolverá el nodo que contiene el string.
    Podrás eliminar un nodo cualquiera de la lista.
    Podrás preguntarle a la lista que devuelva un array con todos los valores de sus nodos.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ListCodeKata
{
    class MiLista
    {        
        private int count;
        public Nodo nodo_ini;
        public Nodo nodo_fin;
        public Nodo nodo;
       
        /// <summary>        
        /// Constructor lista enlazada
        /// </summary>
        
        public MiLista()
        {
            nodo = null;
            count = 0;
        }
        
        /// <summary>
        /// Metodo para añadir un nodo a la lista
        /// Los nuevos nodos se añaden al final de la lista.
        /// </summary>
        public void Add(string texto)
        {
            if (count <= 0)
            {
                nodo = new Nodo(texto);
                nodo_ini = nodo ; 
            }
            else
            {
                while (nodo.next != nodo)
                    nodo = nodo.next;
                nodo.next = new Nodo(texto);
                nodo_fin = nodo.next;
            }
            count++;
        }

        /// <summary>
        /// Podrás preguntarle a la lista si contiene un string concreto. Si es así, devolverá el nodo que contiene el string.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>
        /// El nodo que contiene el string
        /// </returns>
        public Nodo Find(string texto)
        {
            if (count == 1)
            {
                if (nodo.Contains(texto))
                {
                    return nodo;
                }                    
            }
            if (count > 1)
            {
                nodo = nodo_ini;                
                while (nodo.next != nodo)
                {
                    if (nodo.next.Contains(texto))
                    {
                        return nodo.next;                        
                    }                    
                    nodo = nodo.next;
                }
                return new Nodo(); // nodo con valores null y string empty            
            }
            else
                return new Nodo();// nodo con valores null y string empty
        }

        /// <summary>
        /// Podrás eliminar un nodo cualquiera de la lista.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>
        /// true si se ha podido borrar
        /// false en caso contrario
        /// </returns>
        public Boolean Delete(string texto)
        {
            if (count > 0)
            {
                nodo = Find(texto);
                if (nodo.texto == String.Empty) // es decir no lo he encontrado
                {
                    return false;
                }
                else
                {
                    nodo.Dispose(); // la lista se rompe porque no es doblemente enlazada.                    
                    return true;
                }
            }
            else
            {
                return false;
            }     
        }
    }
}
