namespace LoginAPI.Models.Entities
{
    public class Cliente
    {
        public Guid ID { get; set; }
        public string UserID { get; set; }

        public string Nome { get; set; }
        public string Cidade { get; set; }

        public Cliente()
        {
            ID = Guid.NewGuid();
        }
    }
}
