using System;
using System.Windows.Forms;

namespace Converte_SIAxCTBLT.Models
{
    class LayOutSIA
    {
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Ficha { get; set; }
        public float Valor { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }
        public string Arrecadador { get; set; }

        public LayOutSIA() { }

        public LayOutSIA(string agencia, string conta, string ficha, float valor, string descricao, string data, string arrecadador)
        {
            Agencia = agencia;
            Conta = conta;
            Ficha = ficha;
            Valor = valor;
            Descricao = descricao;
            Data = data;
            Arrecadador = arrecadador;
        }

        public static LayOutSIA layOutLeitura(string linha)
        {
            try
            {
                var l = new LayOutSIA();
                
                if (linha.Length == 789) //verifica tamanho do arquivo
                {
                    l.Agencia = linha.Substring(0, 7).Trim();
                    l.Conta = linha.Substring(7, 19).Trim();
                    l.Ficha = linha.Substring(28, 4).Trim();
                    l.Valor = (float)Convert.ToDecimal(linha.Substring(33, 15));
                    l.Descricao = linha.Substring(48, 69);
                    l.Data = linha.Substring(118, 10);
                    l.Arrecadador = linha.Substring(504, 5).Trim();
                }
                
                return l;
            }
            catch (Exception e)
            {
                MessageBox.Show("Arro ao Carregar Layout: " + e.Message);
                return null;
            }

        }

        public override string ToString()
        {
            return Agencia.PadRight(8, ' ') +
                   Conta.PadRight(20, ' ') +
                   Ficha.PadRight(4, ' ') +
                   Valor.ToString().PadLeft(16, '0') +
                   Descricao.PadRight(70, ' ') +
                   Data.PadLeft(10, '0') +
                   "SIA".PadRight(373, ' ') +
                   Arrecadador.PadRight(6, ' ') +
                   "0".PadRight(128, ' ') +
                   "0".PadRight(149, ' ');
        }
    }


}
