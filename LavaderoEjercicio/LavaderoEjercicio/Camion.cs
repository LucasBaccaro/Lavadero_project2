using System;
using System.Collections.Generic;
using System.Text;

namespace LavaderoEjercicio
{
    public class Camion:Vehiculo
    {
        protected float tara;

        public Camion(float tara, string patente, Byte cantRuedas, eMarca marca) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cantidad de taras: " + this.tara);
            sb.AppendLine(Mostrar());
            return sb.ToString();
        }
    }
}
