using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmo
{
    public abstract class Inmueble
    {


        private String tipo;
        private String direccion;
        private String estado;
        private double metrosC;
        private int piso;
        private int antic;
        private int cVentanas;
        private double precioBase;
        private double precioFinal;
        public double Descuento;


        public Inmueble()
        {
            Tipo = Tipo;
            Direccion = Direccion;
            Estado = Estado;
            MetrosC = MetrosC;
            Piso = Piso;
            Antic = Antic;
            CVentanas = CVentanas;
            PrecioBase = PrecioBase;
            PrecioFinal = precioFinal;
        }

        public String Tipo { get; set; }
        public String Direccion { get; set; }
        public String Estado { get; set; }

        public double MetrosC { get; set; }

        public int Piso { get; set; }
        public int Antic { get; set; }
        public int CVentanas { get; set; }
        public double PrecioBase { get; set; }
        public double PrecioFinal { get; set; }

        public String getTipo()
        {
            return Tipo;
        }

        public void setTipo(String Tipo)
        {
            this.Tipo = Tipo;
        }

        public String getDireccion()
        {
            return Direccion;
        }

        public void setDireccion(String Direccion)
        {
            this.Direccion = Direccion;
        }

        public String getEstado()
        {
            return Estado;
        }

        public void setEstado(String Estado)
        {
            this.Estado = Estado;
        }

        public double getMetrosC()
        {
            return MetrosC;
        }

        public void setMetrosC(double MetrosC)
        {
            this.MetrosC = MetrosC;
        }

        public int getPiso()
        {
            return Piso;
        }

        public void setPiso(int Piso)
        {
            this.Piso = Piso;
        }

        public int getAntic()
        {
            return Antic;
        }

        public void setAntic(int Antic)
        {
            this.Antic = Antic;
        }

        public int getCVentanas()
        {
            return CVentanas;
        }

        public void setCVentanas(int CVentanas)
        {
            this.CVentanas = CVentanas;
        }

        public double getPrecioBase()
        {
            return PrecioBase;
        }

        public void setPrecioBase(double PrecioBase)
        {
            this.PrecioBase = PrecioBase;
        }

        public double getPrecioFinal()
        {
            return PrecioFinal;
        }

        public void setPrecioFinal(double PrecioFinal)
        {
            this.PrecioFinal = PrecioFinal;
        }

        public virtual double PrecioF()
        {
            
            if(antic < 15)
            {
                Descuento = 0.01;
                PrecioFinal = PrecioBase - (PrecioBase * Descuento);

            }
            else
            {
                Descuento = 0.02;
                PrecioFinal = PrecioFinal - (PrecioFinal * Descuento);
            }

            if(metrosC > 50)
            {
                Descuento = 0.01;
                PrecioFinal = PrecioFinal + (PrecioFinal * Descuento);
            }

            if (Tipo.Equals("Local"))
            {
                if(piso > 3)
                {
                    Descuento = 0.03;
                    PrecioFinal = PrecioFinal + (PrecioFinal * Descuento);
                }

            }else if (Tipo.Equals("Local"))
            {
                if(cVentanas == 1 || cVentanas == 0)
                {
                    Descuento = 0.02;
                    PrecioFinal = PrecioFinal - (PrecioFinal * Descuento);
                }
                else
                {
                    Descuento = 0.02;
                    PrecioFinal = PrecioFinal + (PrecioFinal * Descuento);
                }
            }


            return precioFinal;
        }

    }
}
