using System;
using System.Collections.Generic;
using System.Text;

namespace LavaderoEjercicio
{
    public class Moto:Vehiculo
    {
        protected float cilindrada;

        public Moto(float cilindrada , string patente, Byte cantRuedas, eMarca marca) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cantidad de cilindradas: " + this.cilindrada);
            sb.AppendLine(Mostrar());
            return sb.ToString();
        }
    }
}
