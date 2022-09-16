using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Caballo Babieca = new Caballo("blackhorse");
            Humano Brayan = new Humano("Brayan");
            Gorila Copito = new Gorila("kong");

            //Brayan.pensar(1);

            /* Brayan.getNombre();
             Brayan.nombreServivo = "lo q quiera";
             Brayan.getNombre();


             /*
             Babieca.getNombre();
             Brayan.getNombre();



             Babieca.Galopar();
             Babieca.getNombre();
             */

            /*  principio de sustitucion aplicado 

             Mamiferos animal = new Mamiferos("estrella");
             Caballo estrella = new Caballo("estrella");
             animal = estrella;

           */

            Mamiferos[] AlmacenDeAnimales = new Mamiferos[3];

            AlmacenDeAnimales[0] = Babieca;
            AlmacenDeAnimales[1] = Brayan;
            AlmacenDeAnimales[2] = Copito;

            for (int i = 0; i < 3; i++)

            {
                AlmacenDeAnimales[i].pensar();

            }

            // Mamiferos miMamifero = new Mamiferos("");
            //miMamifero.respirar();
           
            
        }
    }


    class Mamiferos
    {

   // Mamiferos miMamifero = new Mamiferos("");

        //Humano Brayan = new Humano("Brayan");
       

        public Mamiferos(String nombre)

        {
            this.nombreServivo = nombre;         

        }

        public virtual void pensar()
        {

            Console.WriteLine("pensamiento basico instintivo");

        }

        /*
        public Caballo(string nombreCaballo) : base(nombreCaballo)

        {

        }
        */

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("el nombre del ser vivo es: " + nombreServivo);
        }

        private String nombreServivo;


    }

    class Caballo : Mamiferos
    {

        public Caballo(string nombreCaballo) : base(nombreCaballo)

        {

        }
        

        public void Galopar()
        {
            Console.WriteLine("soy capaz de galopar");
        }
        
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)

        {

        }

        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");


        }

        public void pensar(string pensar)
        {
            Console.WriteLine("Soy capaz de pensar");


        }

        public void pensar(int pensar)
        {
            Console.WriteLine("pensamienro numero");


        }


        /*
                public new void pensar()
            {

            }

            */

    }

    class Gorila : Mamiferos {



        public Gorila(string nombreGorila) : base(nombreGorila)

        {
            

        }


        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void pensar()
        {
            Console.WriteLine("pensamiento instintivo avanzado");


        }

    }
}

