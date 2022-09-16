using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStringIntObJ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);

            }
            */





            /*
            // Step 1: Array Declaration
            string[] stringarray;

            // Step 2:Array Initialization
            stringarray = new string[4] { "Element 1", "Element 2", "Element 3", "Element 4" };

            // Step 3:Accessing Array Elements
            /*Console.WriteLine(stringarray[0]);
            Console.WriteLine(stringarray[1]);
            Console.WriteLine(stringarray[2]);
            Console.WriteLine(stringarray[3]);
            */
            /*
            for (int i = 0; i < stringarray.Length; i++)
            {

                Console.WriteLine(stringarray[i]);

            */

                cubiertos[] lacocina = new cubiertos[7];
                 for (byte i = 0; i < 7; i++)
                     lacocina[i] = new cubiertos();
                

            }



        }


        
        public class cubiertos
        {


            public cubiertos()
            {
                Console.WriteLine("objetos para comer");
            }

        }

        public class cuchara : cubiertos

        {

            public cuchara()
            {
                Console.WriteLine("esta es la cuchara");
            }


        }

        public class tenedor : cubiertos

        {

            public tenedor()
            {
                Console.WriteLine("este es el tenedor");
            }


        }
        
    }



