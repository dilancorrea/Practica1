using System;
using System.Linq;

namespace Granja.Cultivos
{
    public class Cultivo
    {
        #region Properties
        private string tipo;
        private int temperatura;
        private bool estado;
        #endregion Properties

        #region Getters & Setters
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public bool Estado
        {
            get { return estado;}
            set { estado = value; }
        }
        #endregion Getters & Setters

        #region Initialize
        public Cultivo()
        {
            Random ran = new Random();
            Temperatura = ran.Next(15,50);
            Estado = false;
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result = new string(Enumerable.Repeat(chars, 4)
                                                        .Select(s => s[random.Next(s.Length)])
                                                        .ToArray());
            Tipo = result;
        }
        #endregion Initialize
    }

}