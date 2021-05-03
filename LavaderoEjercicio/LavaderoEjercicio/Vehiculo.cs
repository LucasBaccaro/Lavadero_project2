using System;
using System.Text;

namespace LavaderoEjercicio
{
    public class Vehiculo
    {
        protected string patente;

        protected Byte cantRuedas;
        protected eMarca marca;

        public string Patente { get => patente;}
        public eMarca Marca{ get => marca ; }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Marca: " + this.marca);
            sb.Append("Cantidad de ruedas: " + this.cantRuedas);
            sb.Append("Patente: " + this.patente);
            return sb.ToString();
        }
        public Vehiculo(string patente, Byte cantRuedas, eMarca marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        public static bool operator ==(Vehiculo vehiculo1,Vehiculo vehiculo2)
        {
            bool retorno = false;
            if(vehiculo1.patente==vehiculo2.patente && vehiculo1.marca==vehiculo2.marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

       

    }
}
