using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerMoney.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        public string Senha { get; set; }

        [RegularExpression(@"[0-9]{11}", ErrorMessage = "CPF inválido. O CPF deve conter 11 caracteres e apenas dígitos")]
        [Required(ErrorMessage = "Obrigatório informar o CPF!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o RG!")]
        public int Rg { get; set; }

        public ICollection<Cadastroveiculo> Veiculo { get; set; }
    }
}
