using System;
using System.Linq;
using Controllers;
using DbRespositorie;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LocacaoModels
    {
        [Key]
        public int IdLocacao { get; set; }
        public virtual ClienteModels Cliente { get; set; }
        [ForeignKey("clientes")]
        public int IdCliente { get; set; }
        [Required]
        public DateTime DataLocacao { get; set; }
        public List<FilmeModels> filmes = new List<FilmeModels>();

        public LocacaoModels(ClienteModels cliente, DateTime dataLocacao)
        {
            IdCliente = cliente.IdCliente;
            DataLocacao = dataLocacao;
            filmes = new List<FilmeModels>();
            cliente.AdicionarLocacao(this);

            var db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();
        }

        // Segundo Construtor 
        public LocacaoModels()
        {

        }

        public void AdicionarFilme(FilmeModels filme)
        {
            var db = new Context();
            LocacaoFilmeModels locacaoFilme = new LocacaoFilmeModels()
            {
                IdFilme = filme.IdFilme,
                IdLocacao = IdLocacao
            };

            db.LocacaoFilme.Add(locacaoFilme);
            db.SaveChanges();
        }

        public string FilmesLocados()
        {
            var db = new Context();
            IEnumerable<int> filmes =
            from filme in db.LocacaoFilme
            where filme.IdLocacao == IdLocacao
            select filme.IdFilme;

            string strFilmes = "";

            if (filmes.Count() > 0)
            {
                foreach (int IdFilme in filmes)
                {
                    FilmeModels filme = FilmeController.GetFilme(IdFilme);
                    strFilmes += $"ID: {filme.IdFilme} >>> " +
                                 $"Título: {filme.Titulo}\n";
                }
            }
            else
            {
                strFilmes += "    NÃO HÁ FILMES!";
            }
            return strFilmes;
        }

        public DateTime CalculoDataDevol()
        {
            var db = new Context();
            IEnumerable<int> filmes =
            from filme in db.LocacaoFilme
            where filme.IdLocacao == IdLocacao
            select filme.IdFilme;

            ClienteModels cliente = ClienteModels.GetCliente(IdCliente);
            return LocacaoController.CalculoDataDevolucao(DataLocacao, cliente);
        }

        public int QtdeFilmes()
        {
            var db = new Context();
            IEnumerable<int> filmes =
            from filme in db.LocacaoFilme
            where filme.IdLocacao == IdLocacao
            select filme.IdFilme;

            ClienteModels cliente = ClienteModels.GetCliente(IdCliente);

            return filmes.Count();
        }

        public double ValorTotal()
        {
            double total = 0;
            var db = new Context();
            IEnumerable<int> filmes =
            from filme in db.LocacaoFilme
            where filme.IdLocacao == IdLocacao
            select filme.IdFilme;

            foreach (int id in filmes)
            {
                FilmeModels filme = FilmeModels.GetFilme(id);
                total += filme.ValorLocacaoFilme;
            }
            return total;
        }

        public static List<LocacaoModels> GetLocacoes()
        {
            var db = new Context();
            return db.Locacoes.ToList();
        }

        public static LocacaoModels GetLocacao(int idLocacao)
        {
            var db = new Context();
            return (from locacao in db.Locacoes
                    where locacao.IdLocacao == idLocacao
                    select locacao).First();
        }

        public static void UpdateLocacao(
            int idLocacao,
            int idCliente,
            DateTime dataLocacao
        )
        {
            Context db = new Context();
            try
            {
                LocacaoModels locacao = db.Locacoes.First(locacao => locacao.IdLocacao == idLocacao);
                locacao.IdLocacao = idLocacao;
                locacao.IdCliente = idCliente;
                locacao.DataLocacao = dataLocacao;
                db.SaveChanges(); // Cria a transação do BD
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public static void DeletarLocacao(int idLocacao)
        {
            Context db = new Context();
            try
            {
                LocacaoModels locacao = db.Locacoes.First(locacao => locacao.IdLocacao == idLocacao);
                db.Remove(locacao);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public static List<LocacaoModels> LocacoesDoCliente(int IdCliente)
        {
            var db = new Context();
            return (from locacao in db.Locacoes
                    where locacao.IdCliente == IdCliente
                    select locacao).ToList();
        }
    }
}