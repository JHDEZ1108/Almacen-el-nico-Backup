namespace consultaBD.Negocio
{
    public class DProveedores
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Estado { get; set; }

        public DProveedores() { }
        public DProveedores(string nombre, string direccion, int telefono, int estado)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Estado = estado;
        }
    }
}