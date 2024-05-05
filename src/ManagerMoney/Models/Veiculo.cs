using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerMoney.Models
{

    [Table("Veiculos")]
    public class Veiculo
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome")]
        public string Nome { get; set; }
        
        [Key]
        [Required(ErrorMessage = "Obrigatório informar a Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Fabricante ")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Cor ")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação ")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano do Modelo")]
        public int AnoModelo { get; set; }




    }
}
