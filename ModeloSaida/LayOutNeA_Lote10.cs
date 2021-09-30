using System;
using System.Collections.Generic;

namespace Converte_SIAxCTBLT.Models
{
    class LayOutNeA_Lote10
    {
        public string TipoRegistro { get; set; }
        public string Gestao { get; set; }
        public int IdLote { get; set; }
        public DateTime DataLancamento { get; set; }
        public string TipoLote { get; set; }
        public string Observacao { get; set; }
        public float ValorLote { get; set; }
        public List<LayOutNeA_Bancos11> RegistroValoresBancos { get; set; }

        public LayOutNeA_Lote10(int idLote, DateTime dataLancamento, float valorLote, List<LayOutNeA_Bancos11> registroValoresBancos)
        {
            TipoRegistro = "10";
            Gestao = "000001";
            IdLote = idLote;
            DataLancamento = dataLancamento;
            TipoLote = "O";
            Observacao = "";
            ValorLote = valorLote;
            RegistroValoresBancos = registroValoresBancos;
        }

        public override string ToString()
        {
            return TipoRegistro +
                   Gestao +
                   IdLote.ToString().PadLeft(6, '0') +
                   DataLancamento.ToString("ddMMyyyy") +
                   TipoLote +
                   Observacao.PadLeft(200, ' ') +
                   ValorLote.ToString("F2").PadLeft(13, '0');
        }
    }
}
