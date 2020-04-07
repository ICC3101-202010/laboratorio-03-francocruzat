using System;
using System.Collections.Generic;

namespace labfranco3
{
    class Persona
    {
        public int Rut;
        public string Nombre;
        public string Apellido;
        public string Fecha;
        public string Nacionalidad;
        public string Estadocivil;

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
        public int Dinero;
        public string Domicilio;

        public Cliente(int rut, string nombre, string apellido, string fecha, string nacionalidad,string estadocivil,int dinero,string domicilio)
            : base(rut, nombre, apellido, fecha, nacionalidad, estadocivil)
        {
            this.Dinero = dinero;
            this.Domicilio = domicilio;

        }

    }
    class Trabajador : Persona
    {
        public int Sueldo;
        public string Trabajo;
        public string Horario;

        public Trabajador(int rut, string nombre, string apellido, string fecha, string nacionalidad, string estadocivil, int sueldo,string trabajo,string horario)
            : base(rut, nombre, apellido, fecha, nacionalidad, estadocivil)
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
        public int Precio;
        public string Nombreproducto;
        public string Marca;
        public int Stockdisponible;



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
            for (int i = 0; i < listproducto.Count; ++i)
            {
                for (int j = 0; j < Listaproductosdisponible.Count; ++j)
                {
                    if (listproducto[i] == Listaproductosdisponible[j] && Listaproductosdisponible[j].Stockdisponiblez>0)
                    {
                        listproducto[i].Stockdisponible-=1 //falta codigo para los registros
                    }
                }
            }
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

            int rutcliente;
            string nombrecliente;
            string apellidocliente;
            string fechacliente;
            string nacionalidadcliente;
            string estadocivilcliente;
            int dinerocliente;
            string domiciliocliente;

            Console.WriteLine("Ingrese los datos del cliente");
            rutcliente = int.Parse(Console.ReadLine());
            nombrecliente= Console.ReadLine();
            apellidocliente= Console.ReadLine();
            fechacliente= Console.ReadLine();
            nacionalidadcliente= Console.ReadLine();
            estadocivilcliente= Console.ReadLine();
            dinerocliente= int.Parse(Console.ReadLine());
            domiciliocliente= Console.ReadLine();
            Cliente cliente = new Cliente(rutcliente, nombrecliente, apellidocliente, fechacliente, nacionalidadcliente, estadocivilcliente, dinerocliente, domiciliocliente);
            int ruttrabajador;
            string nombretrabajador;
            string apellidotrabajador;
            string fechatrabajador;
            string nacionalidadtrabajador;
            string estadociviltrabajador;
            int sueldotrabajador;
            string trabajotrabajador;
            string horariotrabajador

            Console.WriteLine("Ingrese los datos del trabajador");

            ruttrabajador = int.Parse(Console.ReadLine());
            nombretrabajador = Console.ReadLine();
            apellidotrabajador = Console.ReadLine();
            fechatrabajador = Console.ReadLine();
            nacionalidadtrabajador = Console.ReadLine();
            estadociviltrabajador = Console.ReadLine();
            sueldotrabajador = int.Parse(Console.ReadLine());
            trabajotrabajador = Console.ReadLine();
            horariotrabajador= Console.ReadLine();
            Trabajador trabajador = new Trabajador(ruttrabajador, nombretrabajador, apellidotrabajador, fechatrabajador, nacionalidadtrabajador, estadociviltrabajador, sueldotrabajador, trabajotrabajador,horariotrabajador);

            Console.WriteLine("Ingrese nuevo sueldo, nuevo trabajador, nuevo horario en respectivo orden");

            sueldonuevo = int.Parse(Console.ReadLine());
            trabajonuevo = Console.ReadLine();
            horarionuevo = Console.ReadLine();
            trabajador.Cambiarsueldo(sueldonuevo);
            trabajador.Cambiartrabajo(trabajonuevo);//creo que hice algo mal aqui, no alcanze a arreglarlo ;(;(;(
            trabajador.CambiarHorario(horarionuevo);// falta terminar pocas cosas en el programa que se hacer, pero no alcanze(irresponsabilidad);((((
        }
    }
}

