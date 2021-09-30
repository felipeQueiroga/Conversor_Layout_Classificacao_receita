using Converte_SIAxCTBLT.Config;
using System.Windows.Forms;

namespace Converte_SIAxCTBLT.Models
{
    class LayOutNeA_Fichas12
    {
        public string Tipo { get; set; }
        public string Gestao { get; set; }
        public int IdLote { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Receita { get; set; }
        public float Valor { get; set; }
        public string Branco163 { get; set; }
        private FichaReceitas Fichas { get; set; }

        public LayOutNeA_Fichas12(int idLote, string banco, string agencia, string conta, string receita, float valor)
        {
            Fichas = new FichaReceitas();
            Tipo = "12";
            Gestao = "000001";
            IdLote = idLote;
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
            Receita = receita;
            Valor = valor;
            Branco163 = "";
        }

        public string getBanco()  //relacao COD SIA e COD arrecadador
        {
            if (Banco.Trim() == "1002" || Banco.Trim() == "9016")
            {
                return "1";
            }
            if (Banco.Trim() == "1016")
            {
                return "104";
            }
            if (Banco.Trim() == "1018")
            {
                return "237";
            }
            if (Banco.Trim() == "1030")
            {
                return "748";
            }
            else
            {
                return Banco;
            }
        }

        public override string ToString()
        {
            string txt = "";
            try
            {
                txt = Tipo.PadLeft(2, '0') +
                   Gestao.PadLeft(6, '0') +
                   IdLote.ToString().PadLeft(6, '0') +
                   getBanco().PadLeft(8, '0') +
                   Agencia.PadRight(11, ' ') +
                   Conta.PadRight(15, ' ') +
                   Fichas.Fichas[Receita].Replace(".", "").PadRight(12, '0').Substring(0, 12) +
                   Valor.ToString("F2").PadLeft(13, '0') +
                   Branco163.PadLeft(163, ' ');
            }
            catch (System.Exception)
            {

                MessageBox.Show("Existem Dívidas sem configuração contabil no SIA: \n" +
                                "conta reduzida: " + Receita + "\n" +
                                "Verifi também o Arquivo: C:\\LayOut CTBL\\conf.txt");
                Application.Exit();
            }
            return txt;
        }
    }
}
