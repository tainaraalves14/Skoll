namespace Models.Models
{
    public class Lancamento
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Usuario? Usuario { get; set; }
        public string? UsuarioId { get; set; }

        public double Valor { get; set; }
        public double ValorReservado { get; set; }
        public DateTime? Data { get; set; }
        
        public bool isFixo { get; set; }
        public string Obs { get; set; }

        public string Natureza { get; set; }
    
        public Categoria? Categoria { get; set; }
        public int? CategoriaID { get; set; }
    }
}