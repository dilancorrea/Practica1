using System;
using System.Linq;

namespace Granja.Robots
{
    public class Robots
    {
        #region Properties
        private string idRobot;
        private bool estado;
        private int cant_Agua;

        private int cant_Semillas;
        #endregion Properties

        #region Getters & Setters
        public string IdRobot
        {
            get { return idRobot; }
            set { idRobot = value; }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Cant_Agua
        {
            get { return cant_Agua; }
            set { cant_Agua = value; }
        }

        public int Cant_Semillas
        {
            get { return cant_Semillas; }
            set { cant_Semillas = value; }
        }

        #endregion Getters & Setters

        #region Initiallize
        public Robots()
        {
        Random random = new Random();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string result = new string(Enumerable.Repeat(chars, 6)
                                            .Select(s => s[random.Next(s.Length)])
                                            .ToArray());
        IdRobot = result;
        Estado = true;
        Cant_Agua = 500;
        Cant_Semillas = 500;
        }

        

        #endregion Initiallize
    }
}