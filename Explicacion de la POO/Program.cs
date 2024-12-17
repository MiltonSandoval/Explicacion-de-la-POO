using System;
using System.Collections.Generic;

namespace Explicacion_de_la_POO
{
    /*
     * CLASE:
     * Una clase es una plantilla o modelo que define atributos y comportamientos.
     * La clase "Album" define las propiedades de un álbum musical.
     */
    class Album
    {
        /*
         * ENCAPSULAMIENTO:
         * Se protegen los atributos usando "private" y se permite acceso controlado
         * mediante propiedades (getters y setters).
         */

        // Atributos privados
        private string titulo;
        private string artista;
        private int anioLanzamiento;

        // Propiedades públicas para acceder a los atributos
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set { anioLanzamiento = value; }
        }

        /*
         * MÉTODO:
         * Un método define un comportamiento o acción de un objeto.
         */
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Álbum: {Titulo}, Artista: {Artista}, Año: {AnioLanzamiento}");
        }
    }

    /*
     * HERENCIA:
     * La clase "AlbumDigital" hereda de la clase "Album" y añade atributos específicos.
     */
    class AlbumDigital : Album
    {
        public string Formato { get; set; } // Atributo adicional para álbum digital

        /*
         * POLIMORFISMO:
         * Sobrescribimos el método "MostrarInformacion" para personalizar su comportamiento.
         */
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Álbum Digital: {Titulo}, Artista: {Artista}, Formato: {Formato}");
        }
    }

    /*
     * ABSTRACCIÓN:
     * La clase abstracta "Cancion" define un modelo general para las canciones.
     * No se puede instanciar, solo se utiliza como base para otras clases.
     */
    abstract class Cancion
    {
        // Método abstracto: obliga a las clases derivadas a implementarlo
        public abstract void Reproducir();
    }

    /*
     * La clase "CancionPop" implementa la clase abstracta "Cancion".
     */
    class CancionPop : Cancion
    {
        public string Nombre;
        public string Duracion;
        public string Artista; 
        public CancionPop(string nombre, string duracion, string artista)
        {
            Nombre = nombre;
            Duracion = duracion;
            Artista = artista;
        }

       

        public override void Reproducir()
        {
            Console.WriteLine($"🎵 Reproduciendo canción pop: {Nombre} -  De: {Artista} - Duración: {Duracion}");
        }
    }

    /*
     * OBJETO:
     * Un objeto es una instancia concreta de una clase. A partir de la clase "Album"
     * o "CancionPop", podemos crear objetos con atributos específicos.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un OBJETO de la clase Album
            Album album1 = new Album();
            album1.Titulo = "Vice Versa";
            album1.Artista = "Rauw Alejandro";
            album1.AnioLanzamiento = 2021;
            album1.MostrarInformacion();

            // Creamos un OBJETO de la clase heredada AlbumDigital
            AlbumDigital albumDigital = new AlbumDigital();
            albumDigital.Titulo = "The Last";
            albumDigital.Artista = "Aventura";
            albumDigital.AnioLanzamiento = 2009;
            albumDigital.Formato = "MP3";
            albumDigital.MostrarInformacion();

            // Creamos un OBJETO de la clase CancionPop
            CancionPop cancion = new CancionPop("Blinding Lights", "3:20", "The Weeknd");
            cancion.Reproducir();

            Console.ReadLine(); // Evita que la consola se cierre automáticamente
        }
    }
}
