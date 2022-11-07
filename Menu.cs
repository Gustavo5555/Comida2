using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_2
{
    class Menu 
    {
        private string nombre;
        private float precio;

        public string Nombre { get; set; }
        public float Precio { get;set; }

        

        public void HamburguesaSimple(float v)
        {
            var h = new Menu();
            h.nombre = "Hamburguesa";
            h.precio = 500;
            
            float valor1 = v * h.precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(v + "            " + h.nombre);
            archivo.Close();
            
            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor1);
            archivoPrecios.Close();


        }

        public void HamburguesaQueso(float v)
        {
            var h = new Menu();
            h.nombre = "Hamburguesa c/ Queso";
            h.precio = 650;

            float valor1 = v * h.precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(v + "            " + h.nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor1);
            archivoPrecios.Close();
        }

        public void PapasFritasSimple(float pa)
        {
            var p = new Menu();
            p.nombre = "Papas Fritas";
            p.precio = 300;

            float valor1 = pa * p.precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(pa + "            " + p.nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor1);
            archivoPrecios.Close();
        }

        public void CocaCola(float g)
        {
            var gaseosa = new Menu();
            gaseosa.nombre = "Coca Cola";
            gaseosa.precio = 250;

            float valor1 = g * gaseosa.precio;

            StreamWriter archivo = new StreamWriter("Archivo.txt", true);
            archivo.WriteLine(g + "            " + gaseosa.nombre);
            archivo.Close();

            StreamWriter archivoPrecios = new StreamWriter("Precio.txt", true);
            archivoPrecios.WriteLine(valor1);
            archivoPrecios.Close();
        }


    }
}
