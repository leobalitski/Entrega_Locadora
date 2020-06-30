using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// 'N to N' relation class
    /// </summary>
    public class LocacaoFilmeModels
    {
        [Key] // Main key
        public int Id { get; set; }
        [ForeignKey("locacoes")] // DT - Foreign Key
        public int IdLocacao { get; set; }
        public virtual LocacaoModels Locacao { get; set; }
        [ForeignKey("filmes")] // DTC - Foreign Key
        public int IdFilme { get; set; }
        public virtual FilmeModels Filme { get; set; }

    }
}