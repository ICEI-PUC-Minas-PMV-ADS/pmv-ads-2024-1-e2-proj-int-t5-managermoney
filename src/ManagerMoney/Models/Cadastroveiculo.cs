using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerMoney.Models
{

    [Table("CadastroVeiculos")]
    public class Cadastroveiculo
    { 

        [Key]
    public int Id { get; set; }
        
    [Required(ErrorMessage ="Obrigatorio informar no Nome do Veículo")]
    public string Nome { get; set; }

    [Required(ErrorMessage ="Obrigatório informar a Placa")]
    public string Placa { get; set; }

    [Required(ErrorMessage ="Obrigatório informar o Fabricante")]
    public string Fabricante { get; set; }

    [Required(ErrorMessage ="Obrigatório informar a Cor")]
    public string Cor { get; set; }

    [Required(ErrorMessage ="Obrigatório informar o Ano de Fabricação")]

        [Display(Name = "Ano de Fabricação")]
    public int AnoFabricacao { get; set; }

    [Required(ErrorMessage ="Obrigatório informar o Ano do Modelo")]

        [Display(Name = "Ano do Modelo")]
    public int AnoModelo { get; set; }

    public ICollection<Despesa> Despesa { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]

        public Usuario Usuario { get; set; }

    }

}
