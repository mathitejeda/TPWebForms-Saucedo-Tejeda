namespace Modelo
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public int IDTipo { get; set; }

        public Usuario() { }
        public Usuario(int ID, string Nombre, string Apellidos)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
        }
    }
}
