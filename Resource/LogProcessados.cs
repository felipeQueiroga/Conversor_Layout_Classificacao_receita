using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Converte_SIAxCTBLT.Models
{
    class LogProcessados
    {
        public static string Path = @"C:\LayOut CTBL\log.txt";
        public static int Count = 0;
        public int Lote { get; set; }
        public string Data { get; set; }
        public string PeriodoInicial { get; set; }
        public string PeriodoFinal { get; set; }
        public string ArquivoGerado { get; set; }

        public LogProcessados(int lote, string data, string periodoInicial, string periodoFinal, string arquivoGerado)
        {
            Lote = lote;
            Data = data;
            PeriodoInicial = periodoInicial;
            PeriodoFinal = periodoFinal;
            ArquivoGerado = arquivoGerado;
            Count += 1;
        }

        public static LogProcessados layOutLeitura(string linhaTxt)
        {
            LogProcessados log = new LogProcessados(0, null, null, null, null);
            string[] dadosTxt = linhaTxt.Split(";");
            try
            {
                log.Lote = int.Parse(dadosTxt[0]);
                log.Data = dadosTxt[1];
                log.PeriodoInicial = dadosTxt[2];
                log.PeriodoFinal = dadosTxt[3];
                log.ArquivoGerado = dadosTxt[4];
            }
            catch (Exception)
            {
            }
            return log;
        }

        public override string ToString()
        {
            return Lote + ";" + Data + ";" + PeriodoInicial + ";" + PeriodoFinal + ";" + ArquivoGerado;
        }
    }
}