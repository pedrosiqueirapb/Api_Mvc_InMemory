namespace Api_Mvc_Entity.Models
{
    public class UsuarioModel
    {
        public int Id { get; init; }
        public string NomeUsuario { get; set; }
        public DateOnly NascimentoUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string EnderecoUsuario { get; set; }
        public char SexoUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string LembreteSenha { get; set; }
        /*
        public UsuarioModel(string NomeUsuario, DateOnly NascimentoUsuario, string EmailUsuario, string EnderecoUsuario, char SexoUsuario, string SenhaUsuario, string LembreteSenha)
        {
            this.NomeUsuario = NomeUsuario;
            this.NascimentoUsuario = NascimentoUsuario;
            this.EmailUsuario = EmailUsuario;
            this.EnderecoUsuario = EnderecoUsuario;
            this.SexoUsuario = SexoUsuario;
            this.SenhaUsuario = SenhaUsuario;
            this.LembreteSenha = LembreteSenha;
        }
        */
    }
}
