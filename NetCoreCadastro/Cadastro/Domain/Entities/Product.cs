namespace Cadastro.Domain.Entities
{
    public class Product: BaseModel
    {
        public string nome_Cliente { get; set; }
        public string Produto { get; set; }
        public decimal Value { get; set; }
        public bool Active { get; set; }
        public int IdCategory { get; set; }
        public virtual Category Category { get; set; }
        public int IdCliente { get; set; }
        public virtual Client Client { get; set; }
    }
}