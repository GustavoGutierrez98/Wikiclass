namespace Wikiclass.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public int Año { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }
        public ICollection<Tag> tag { get; set; }
        public ICollection<Post> post { get; set; }
    }
}
