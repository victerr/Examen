using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListadoUsuarios
{
    [Serializable]
    class Usuario
    {
        int codigo;
        string nombre;
        string password;
        string email;
        DateTime fechaNacimiento;

        public Usuario(int codigo, string nombre, string password, string email, DateTime fechaNacimiento)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.password = password;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Usuario() : this(-1, "", "", "", DateTime.Now)
        { }

        public int Codigo { get => codigo; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public override string ToString()
        {
            return "Código: " + codigo + " Nombre: " + nombre + " E-mail: " + email + " Fecha de nacimiento: " + fechaNacimiento;
        }


        public static bool NombreValido(string nombre)
        {
            Regex patronNombre1 = new Regex(@"\A[a-zA-Z]");
            Regex patronNombre2 = new Regex("[^-]");
            return patronNombre1.IsMatch(nombre) && patronNombre2.IsMatch(nombre);
        }

        public static bool EmailValido(string email)
        {
            Regex patronEmail1 = new Regex(@"\A[a-zA-Z]");
            Regex patronEmail2= new Regex(@"[@]");
            Regex patronEmail3 = new Regex(@"[a-zA-Z]\z");
            return patronEmail1.IsMatch(email) && patronEmail2.IsMatch(email) && patronEmail3.IsMatch(email);
        }

        public bool EsMayorEdad()
        {
            return fechaNacimiento < DateTime.Today.AddYears(-18);
        }
    }
}
