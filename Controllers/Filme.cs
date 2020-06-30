using System;
using Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controllers
{
    public class FilmeController
    //cadastra filme
    {
        public static void CadastrarFilme(
            string titulo,
            string dataLancamento,
            string sinopse,
            double valorLocacaoFilme,
            int estoqueFilme
        )
        {
            DateTime dtLanc;
            try
            {
                dtLanc = Convert.ToDateTime(dataLancamento);
            }
            catch
            {
                Console.WriteLine("FORMATO iNVÁLIDO!");
                dtLanc = DateTime.Now;
            }
            new FilmeModels(
                titulo,
                dataLancamento,
                sinopse,
                valorLocacaoFilme,
                estoqueFilme
            );
        }
        //lista de filme
        public static List<FilmeModels> GetFilmes()
        {
            return FilmeModels.GetFilmes();
        }
        public static FilmeModels GetFilme(int idFilme)
        {
            return FilmeModels.GetFilme(idFilme);
        }

        public static void AlterarFilme(
            int idFilme,
            string titulo,
            string dataLancamento,
            string sinopse,
            double valorLocacaoFilme,
            int estoqueFilme
            )
        {
            FilmeModels.AlterarFilme(
            idFilme,
            titulo,
            dataLancamento,
            sinopse,
            valorLocacaoFilme,
            estoqueFilme
            );
        }
        //deleta filme / locaçoes do cliente
        public static void DeletarFilme(int idFilme)
        {
            if (LocacaoController.LocacoesDoCliente(idFilme).Count > 0)
            {
                throw new Exception ("Existe Locações Com Esse Filme!");
            }
            FilmeModels.DeletarFilme(idFilme);
        }
    }
}