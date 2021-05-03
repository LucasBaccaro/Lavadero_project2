using System;
using System.Collections.Generic;
using System.Text;

namespace LavaderoEjercicio
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero()
        {
            vehiculos = new List<Vehiculo>();
        }
        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        public string LavaderoUno
        { get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("PRECIO AUTO" + this.precioAuto);
                sb.Append("PRECIO CAMION: " + this.precioCamion);
                sb.Append("PRECIO MOTO" + this.precioMoto);

                foreach (Vehiculo item in Vehiculos)
                {
                    if (item is Auto autito)
                    {
                        sb.AppendLine(autito.MostrarAuto());
                    }
                    else if (item is Moto motito)
                    {
                        sb.AppendLine(motito.MostrarMoto());
                    }
                    else if (item is Camion camioncito)
                    {
                        sb.AppendLine(camioncito.MostrarCamion());
                    }

                }
                return sb.ToString();
            }
        }

        public double MostrarTotalFacturado()
        {

            float total = 0;
            foreach (Vehiculo item in Vehiculos)
            {

                if (item is Auto autito)
                {
                    total += this.precioAuto;
                }
                else if (item is Moto motito)
                {
                    total += this.precioMoto;
                }
                else if (item is Camion camioncito)
                {
                    total += this.precioCamion;
                }
            }
            return (double)total;
        }

        public double MostrarTotalFacturado(eVehiculos vehiculito)
        {
            float total = 0;
           
            foreach (Vehiculo item in Vehiculos)
            {

                if (item is Auto autito && vehiculito==eVehiculos.Auto)
                {
                    total += this.precioAuto;
                }
                else if (item is Moto motito && vehiculito == eVehiculos.Moto)
                {
                    total += this.precioMoto;
                }
                else if (item is Camion camioncito && vehiculito == eVehiculos.Camion)
                {
                    total += this.precioCamion;
                }
            }
            return (double)total;

        }

        public static bool operator ==(Lavadero lav, Vehiculo veh)
        {
            bool retorno = false;
            if (((object)lav) == null && ((object)veh) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)lav) != null && ((object)veh) != null)
                {
                    foreach (Vehiculo item in lav.vehiculos)
                    {
                        if (veh == item)
                        {
                            retorno = true;
                            break;
                        }
                    }

                }        
            }
            return retorno;
        }
            
        public static bool operator !=(Lavadero lav, Vehiculo veh)
        {
            return !(lav == veh);
        }
        

        public static int OrdenarVehiculosPorPatente(Vehiculo veh1,Vehiculo veh2)
        {
            return string.Compare(veh1.Patente,veh2.Patente);

        }

        public static int OrdenarVehiculosPorMarca(Vehiculo veh1, Vehiculo veh2)
        {
            return string.Compare(veh1.Marca.ToString(), veh2.Marca.ToString());
        }

        public static Lavadero operator +(Lavadero lav, Vehiculo veh)
        {
            if(lav != veh)
            {
                lav.Vehiculos.Add(veh);
            }
            return lav;
        }
        public static Lavadero operator -(Lavadero lav, Vehiculo veh)
        {
            if (lav == veh)
            {
                lav.Vehiculos.Remove(veh);
            }
            return lav;
        }
    }
}
