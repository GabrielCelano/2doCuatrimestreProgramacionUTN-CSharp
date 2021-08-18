using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion

        #region Conversiones
        public static explicit operator Dolar(Euro p)
        {
            return new Dolar(p.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        public static implicit operator Euro(double d)
        {
            Euro euro = new Euro(d);
            return euro;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1 == e2;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1.cantidad == e2.cantidad);
        }
        #endregion
    }
    public class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion

        #region Conversiones
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Dolar d, Euro e)
        {
            return e == (Dolar)d;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(e == d);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1 == d2;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        #endregion
    }
    public class Pesos
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion

        #region Conversiones
        public static explicit operator Euro(Pesos p)
        {
            double convDolar = (p.GetCantidad() / GetCotizacion());
            return new Euro(convDolar * Euro.GetCotizacion());
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / GetCotizacion());
        }

        public static implicit operator Pesos(double d)
        {
            Pesos peso = new Pesos(d);
            return peso;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)e).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)e).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Pesos p, Euro e)
        {
            return e == (Pesos)p;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(e == p);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(d == p);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1 == p2;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }

}
