using System;
using Estructura.Granja;
using Granja.Cultivos;
using Granja.Robots;

namespace GestorGranja
{    public class Gestor
    {
        #region Properties
        private Granjas granjaSeleccionada;

        private Robots robotSeleccionado;

        #endregion Properties

        #region Getters & Setters

        #endregion Getters & Setters

        #region Methods

        public void regar_Cultivo(Cultivo cultivo)
        {
            bool disponible = false;
            foreach(Robots temp in granjaSeleccionada.getRobots())
            {
                if(temp.Estado == true)
                {
                    if(cultivo.Estado == true)
                    {
                        temp.Cant_Agua = 0;
                        temp.Estado = false;
                        disponible = true;
                        cultivo.Temperatura = 18;
                        break;
                    }
                    else{
                        Console.WriteLine("El cultivo ", cultivo.Tipo ," no tiene semillas.");
                        disponible = true;
                        break;
                    }
                }
            }
            if( disponible == false )
            {
                Console.WriteLine("No hay robots libres.");
            }
        }
        public void sembrar_Cultivo(Cultivo cultivo)
        {
            bool disponible = false;
            foreach(Robots temp in granjaSeleccionada.getRobots())
            {
                if(temp.Estado == true)
                {
                    if(cultivo.Estado == false)
                    {
                        temp.Cant_Semillas = 0;
                        temp.Estado = false;
                        disponible = true;
                        break;
                    }
                    else{
                        Console.WriteLine("El cultivo ", cultivo.Tipo ," tiene semillas.");
                        disponible = true;
                        break;
                    }
                }
            }
            if( disponible == false )
            {
                Console.WriteLine("No hay robots libres.");
            }
        }

        public void calcular_Temperatura()
        {
            bool disponible = false;
            foreach(Robots temp in granjaSeleccionada.getRobots())
            {
                if( temp.Estado == true )
                {
                    disponible = true;
                    foreach(Cultivo temp2 in granjaSeleccionada.getCultivos())
                    {
                        Console.WriteLine("La temperatura del cultivo ", temp2.Tipo ," es:", temp2.Temperatura);
                        if(temp2.Temperatura > 25)
                        {
                            regar_Cultivo(temp2);
                        }
                    }
                }
            }
            if(disponible == false)
            {
                Console.WriteLine("No hay robots disponibles en el momento.");
            }
        }

        public void AbastecerRobots()
        {
            foreach(Robots temp in granjaSeleccionada.getRobots())
            {
                temp.Cant_Agua = 500;
                temp.Cant_Semillas = 500;
            }
        }

        public void DesocuparRobots()
        {
            foreach(Robots temp in granjaSeleccionada.getRobots())
            {
                temp.Estado = true;
            }
        }
        public void MandarCultivosDomo()
        {
            foreach(Cultivo temp in granjaSeleccionada.getCultivos())
            {
                granjaSeleccionada.setDomo(temp);
            }
            granjaSeleccionada.cultivos.Clear();
        }

        public void MandarDomoGranja()
        {
            foreach(Cultivo temp in granjaSeleccionada.getDomo())
            {
                granjaSeleccionada.setCultivos(temp);
            }
            granjaSeleccionada.domo.Clear();
        }

    /*
        public void LlenarRobots()
        {
            Console.WriteLine("Digite la cantidad de robots que desea: \n");
            int cant = int.Parse(Console.ReadLine());
            for(int i=0 ; i < cant ; i++)
            {
                Robots temp = new Robots();
                granjaSeleccionada.setRobots(temp);
            }
        }

        public void LlenarCultivos()
        {
            Console.WriteLine("Digite la cantidad de cultivos que desea: \n");
            int cant = int.Parse(Console.ReadLine());
            for(int i=0 ; i < cant ; i++)
            {
                Cultivo temp = new Cultivo();
                granjaSeleccionada.setCultivos(temp);
            }
        }
    */
        #endregion Methods
    }
}