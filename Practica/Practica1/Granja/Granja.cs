using System;
using System.Collections.Generic;
using Granja.Cultivos;
using Granja.Robots;


namespace Estructura.Granja
{
    public class Granjas
    {
        #region Properties
        public List<Cultivo> cultivos;
        public List<Robots> robots;
        public List<Cultivo> domo;
        #endregion Properties

        #region Getters & Setters
        public List<Cultivo> getCultivos()
        {
            return cultivos;
        }
        
        public void setCultivos(Cultivo cultivo)
        {
            cultivos.Add(cultivo);
        }

        public List<Robots> getRobots()
        {
            return robots;
        }

        public void setRobots(Robots robot)
        {
            robots.Add(robot);
        }

        public List<Cultivo> getDomo()
        {
            return domo;
        }

        public void setDomo(Cultivo cultivo)
        {
            domo.Add(cultivo);
        }
        #endregion Getters & Setters

        #region Initialize
        public Granjas()
        {
            robots = new List<Robots>();
            cultivos = new List<Cultivo>();
            domo = new List<Cultivo>();
        }
        #endregion Initialize
    }
}