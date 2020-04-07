using System;
using System.Collections.Generic;

namespace labfranco3
{
    class Persona
    {
        private int Rut;
        private string Nombre;
        private string Apellido;
        private string Fecha;
        private string Nacionalidad;
        private string Estadocivil;

        public Persona(int rut,string nombre, string apellido,string fecha, string nacionalidad,string estadocivil)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha = fecha;
            this.Nacionalidad = nacionalidad;
            this.Estadocivil = estadocivil;

        }
    }
    class Cliente : Persona
    {
        private int Dinero;
        private string Domicilio;

        public Cliente(int rut, string nombre, string apellido, string fecha, string nacionalidad,string estadocivil,int dinero,string domicilio)
            : base(rut, nombre, apellido, fecha, nacionalidad, estadocivil)
        {
            this.Dinero = dinero;
            this.Domicilio = domicilio;

        }

    }
    class Trabajador : Persona
    {
        private int Sueldo;
        private string Trabajo;
        private string Horario;

        public Trabajador(int rut, string nombre, string apellido, string fecha, string nacionalidad, int sueldo, string trabajo,string horario)
            : base(rut, nombre, apellido, fecha, nacionalidad)
        {
            this.Sueldo = sueldo;
            this.Trabajo = trabajo;
            this.Horario = horario;
        }
        public void Cambiartrabajo(string trabajonuevo)
        {
            Trabajo = trabajonuevo;
        }
        public void Cambiarsueldo(int sueldonuevo)
        {
            Sueldo = sueldonuevo;
        }
        public void CambiarHorario(string horarionuevo)
        {
            Horario = horarionuevo;
        }
    }

    class Producto
    {
        private int Precio;
        private string Nombreproducto;
        private string Marca;
        private int Stockdisponible;



        public Producto(int precio,string nombreproducto,string marca, int stockdisponible)
        {
            this.Precio = precio;
            this.Nombreproducto = nombreproducto;
            this.Marca = marca;
            this.Stockdisponible = stockdisponible;
        }
    }
    class Supermercado
    {
        List<Producto> Listaproductosdisponible;
        List<Registro> Listaregistro;

        public Supermercado(List<Producto> listaproductosdisponible)
        {
            this.Listaproductosdisponible = listaproductosdisponible;
            this.Listaregistro = new List<Registro>();
        }
        public void Comprar(Cliente cliente,Trabajador cajero,List<string> listproducto)
        {
        }

    }
    
    class Registro
    {
        private string Fecharegistro;
        private string Horaregistro;
        private Cliente Cliente;
        private Trabajador Cajero;
        List<string> Listaproductoscliente = new List<string>();

        public Registro(string fecharegistro,string horaregistro,Cliente cliente,Trabajador cajero,List<string> listaproductoscliente)
        {
            this.Fecharegistro = fecharegistro;
            this.Horaregistro = horaregistro;
            this.Cliente = cliente;
            this.Cajero = cajero;
            this.Listaproductoscliente = listaproductoscliente;


        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Trabajador t1 = new Trabajador(4124, "juan", "diaz", "120922", "argentina", 100000, "cajero", "20pm");
            Console.WriteLine(t1.saludar());

        }
    }
}

