namespace Wikiclass.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Idcategoria { get; set; }
        public Categoria categoria { get; set; }
    }
}
