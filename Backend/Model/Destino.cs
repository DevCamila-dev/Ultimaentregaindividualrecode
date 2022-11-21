using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Viajar.Model
{



    [Table("destinos")]
    public class Destino
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("nome_destino")]
        public string Nome { get; set; } 

        [Column("estado_destino")]
        public string Estado { get; set; }

        [Column("pais_destino")]
        public string Pais { get; set; }  

        [Column("dataIda_destino")]
        public string dataIda { get; set; } 

        
        [Column("dataVolta_aluno")]
        public string dataVolta { get; set; } 

        [Column("Valor_destino")]
        public string Valor { get; set; } 





    }
}
