using System;
using System.Collections.Generic;
using System.Text;

namespace LavaderoEjercicio
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(int asientos, string patente, Byte cantRuedas, eMarca marca) : base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = asientos;
        }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cantidad de asientos: " + this.cantidadAsientos);
            sb.AppendLine(Mostrar());
            return sb.ToString();
        }


    }
}
