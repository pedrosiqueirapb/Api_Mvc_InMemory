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
    }
}
