using System;
using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class LocacaoController
    {
        public static LocacaoModels Add(ClienteModels cliente)
        {
            return new LocacaoModels(cliente, DateTime.Now);
        }
        //Calculo data de devolução
        public static DateTime CalculoDataDevolucao(DateTime DtLocacao, ClienteModels Cliente)
        {
            return DtLocacao.AddDays(Cliente.DiasDevolucao);
        }

        public static List<LocacaoModels> GetLocacoes()
        {
            return LocacaoModels.GetLocacoes();
        }

        public static LocacaoModels GetLocacao(int idLocacao)
        {
            return LocacaoModels.GetLocacao(idLocacao);
        }

        public static ClienteModels UpdateLocacao()
        {
            return UpdateLocacao();
        }

        public static void DeleteLocacao(int idLocacao)
        {
            LocacaoController.DeleteLocacao(idLocacao);
        }

        public static List<LocacaoModels> LocacoesDoCliente(int IdCliente)
        {
            return LocacaoModels.LocacoesDoCliente(IdCliente);
        }
    }
}