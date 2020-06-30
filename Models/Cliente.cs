using System;
using System.Linq;
using DbRespositorie;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ClienteModels
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public string NomeCliente { get; set; }
        [Required]
        public string DataNascimento { get; set; }
        [Required]
        public string CpfCliente { get; set; }
        [Required]
        public int DiasDevolucao { get; set; }
        public List<LocacaoModels> locacoes = new List<LocacaoModels>();

        public ClienteModels(string nomeCliente, string dataNascimento, string cpfCliente, int diasDevolucao)
        {
            NomeCliente = nomeCliente;
            DataNascimento = dataNascimento;
            CpfCliente = cpfCliente;
            DiasDevolucao = diasDevolucao;
            locacoes = new List<LocacaoModels>();

            var db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
        }

        // Segundo Construtor 
        public ClienteModels()
        {

        }

        public static ClienteModels GetCliente(int idCliente)
        {
            var db = new Context();
            return (from cliente in db.Clientes
                    where cliente.IdCliente == idCliente
                    select cliente).First();
        }

        public void AdicionarLocacao(LocacaoModels locacao)
        {
            locacoes.Add(locacao);
        }

        public static List<ClienteModels> GetClientes()
        {
            var db = new Context();
            return db.Clientes.ToList();
        }

        public static void AlterarCliente(
            int idCliente,
            string nomeCliente,
            string dataNascimento,
            string cpfCliente,
            int diasDevolucao
        )
        {
            Context db = new Context();
            try
            {
                ClienteModels cliente = db.Clientes.First(cliente => cliente.IdCliente == idCliente);
                cliente.NomeCliente = nomeCliente;
                cliente.DataNascimento = dataNascimento;
                cliente.CpfCliente = cpfCliente;
                cliente.DiasDevolucao = diasDevolucao;
                db.SaveChanges(); // Cria a transação do BD
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public static void DeletarCliente(int idCliente)
        {
            Context db = new Context();
            try
            {
                ClienteModels cliente = db.Clientes.First(cliente => cliente.IdCliente == idCliente);
                db.Remove(cliente);
                db.SaveChanges();
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}