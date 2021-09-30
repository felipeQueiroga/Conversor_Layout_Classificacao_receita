using System.Collections.Generic;
using System.Windows.Forms;

namespace Converte_SIAxCTBLT.Models
{
    class LayOutNeA_Bancos11
    {
        public string Tipo { get; set; }
        public string Gestao { get; set; }
        public int IdLote { get; set; }
        private string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public float Valor { get; set; }
        public string Branco175 { get; set; }
        public List<LayOutNeA_Fichas12> RegistroValoresFichas { get; set; }

        public LayOutNeA_Bancos11(int idLote, string banco, string agencia, string conta, float valor, List<LayOutNeA_Fichas12> registroValoresFichas)
        {
            Tipo = "11";
            Gestao = "000001";
            IdLote = idLote;
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
            Valor = valor;
            RegistroValoresFichas = registroValoresFichas;
            Branco175 = "";
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
            return Tipo.PadLeft(2, '0') +
                   Gestao.PadLeft(6, '0') +
                   IdLote.ToString().PadLeft(6, '0') +
                   getBanco().PadLeft(8, '0') +
                   Agencia.PadRight(11, ' ') +
                   Conta.PadRight(15, ' ') +
                   Valor.ToString("F2").PadLeft(13, '0') +
                   Branco175.PadLeft(175, ' ');
        }
    }
}
