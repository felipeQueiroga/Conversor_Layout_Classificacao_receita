using System;

namespace Converte_SIAxCTBLT.Models
{
    static class LayOutNeA_ArquivoNome
    {
        static public string NomeArquivo()
        {
            DateTime Data = DateTime.Now;
            string Nome = "CTBLT";
            string Ano = Data.ToString("yy");
            string Mes = Data.ToString("MM");
            string Dia = Data.ToString("dd");
            string Hora = Data.ToString("HH");
            string Minuto = Data.ToString("mm");
            string Segundo = Data.ToString("ss");

            return Nome + Ano + Mes + Dia + Hora + Minuto + Segundo + ".txt";
        }
    }
}
