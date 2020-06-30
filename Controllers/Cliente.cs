using System;
using Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controllers
{
    public class ClienteController
    //Cadastra cliente
    {
        public static void CadastrarCliente(
            string nomeCliente,
            string dataNascimento,
            string cpfCliente,
            int diasDevolucao
            )

        {
            DateTime dtNasc;
            try
            {
                dtNasc = Convert.ToDateTime(dataNascimento);
            }
            catch
            {
                Console.WriteLine("FORMATO INVÁLIDO!");
                dtNasc = DateTime.Now;
            }

            new ClienteModels(
                nomeCliente,
                dataNascimento,
                cpfCliente,
                diasDevolucao);
        }

        public static List<ClienteModels> GetClientes()
        {
            return ClienteModels.GetClientes();
        }

        public static ClienteModels GetCliente(int idCliente)
        {
            return ClienteModels.GetCliente(idCliente);
        }

        public static void AlterarCliente(
            int idCliente,
            string nomeCliente,
            string dataNascimento,
            string cpfCliente,
            int diasDevolucao
            )
        {
            ClienteModels.AlterarCliente(
            idCliente,
            nomeCliente,
            dataNascimento,
            cpfCliente,
            diasDevolucao
            );
        }
        //deleta cliente
        public static void DeletarCliente(int idCliente)
        {
            if (LocacaoController.LocacoesDoCliente(idCliente).Count > 0)
            {
                throw new Exception ("Esse Cliente Possui Locações!");
            }
            ClienteModels.DeletarCliente(idCliente);
        }
    }
}