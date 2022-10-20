namespace Business.Models
{
    public class ContaFisica : Entity
    {
        public string CPF { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get;set; }
        public int Senha8dig { get; set; }
        public string Senha6dig { get; set; }

    }
}
