namespace Herencia
{
    internal class Administracion: Persona
    {
        public string Area { get;  set; }
        public string Cargo { get; set; }
    
        public Administracion ()
        {

        }

        public Administracion (string area, string cargo)
        {
            Area = area;
            Cargo = cargo;
        }
    }
}