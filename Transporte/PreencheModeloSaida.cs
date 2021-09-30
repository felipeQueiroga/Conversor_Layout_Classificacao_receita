using Converte_SIAxCTBLT.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Converte_SIAxCTBLT.Transporte
{
    static class SiaPrencheNea
    {
        private static int proximoLote(List<LogProcessados> logs)
        {
            var idLote = logs.Max(x => x.Lote);
            return idLote + 1;
        }

        public static List<LayOutNeA_Lote10> retornaRegistros(List<LayOutSIA> layOutSia)
        {
            List<LayOutNeA_Lote10> r10 = new List<LayOutNeA_Lote10>();
            int numeroLote = LogProcessados.Count + 1;

            //percorre origem
            var lote10 = layOutSia.GroupBy(x => x.Data)
                          .Select(g => new
                          {
                              Data = g.Key,
                              Soma = g.Sum(x => x.Valor),
                          });

            //preenche destino
            foreach (var itens10 in lote10)
            {
                DateTime data = DateTime.ParseExact(itens10.Data, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                //percorre valores registro 11
                List<LayOutNeA_Bancos11> r11 = preencheRegistros11(numeroLote, itens10.Data, layOutSia);
                r10.Add(new LayOutNeA_Lote10(numeroLote, data, itens10.Soma, r11));
            }
            return r10;
        }

        private static List<LayOutNeA_Bancos11> preencheRegistros11(int lote, string databanco, List<LayOutSIA> layOutSia)
        {
            List<LayOutNeA_Bancos11> r11 = new List<LayOutNeA_Bancos11>();
            var bancos11 = layOutSia.GroupBy(x => new
            {
                x.Data,
                x.Conta,
                x.Arrecadador,
                x.Agencia
                
            }).Select(g => new
            {
                Data = g.Key.Data,
                Conta = g.Key.Conta,
                Banco = g.Key.Arrecadador,
                Agencia = g.Key.Agencia,               
                Soma = g.Sum(x => x.Valor),
            }).Where(x => x.Data == databanco);
            foreach (var itens11 in bancos11)
            {
                //percorre valores registro 12
                List<LayOutNeA_Fichas12> r12 = preencheRegistros12(lote, itens11.Data, itens11.Agencia, itens11.Conta, itens11.Banco, layOutSia);
                r11.Add(new LayOutNeA_Bancos11(lote, itens11.Banco, itens11.Agencia, itens11.Conta, itens11.Soma, r12));
            }
            return r11;
        }

        private static List<LayOutNeA_Fichas12> preencheRegistros12(int lote, string dataFicha, string agencia, string conta, string banco, List<LayOutSIA> layOutSia)
        {
            List<LayOutNeA_Fichas12> r12 = new List<LayOutNeA_Fichas12>();
            var bancos12 = layOutSia.GroupBy(x => new
            {
                x.Data,
                x.Arrecadador,
                x.Agencia,
                x.Conta,
                x.Ficha
            }).Select(g => new
            {
                Data = g.Key.Data,
                Banco = g.Key.Arrecadador,
                Agencia = g.Key.Agencia,
                Conta = g.Key.Conta,
                Ficha = g.Key.Ficha,
                Soma = g.Sum(x => x.Valor),
            }).Where(x => x.Data == dataFicha &&
                     x.Agencia == agencia && 
                     x.Conta == conta &&
                     x.Banco == banco);
            foreach (var itens12 in bancos12)
            {
                r12.Add(new LayOutNeA_Fichas12(lote, itens12.Banco, itens12.Agencia, itens12.Conta, itens12.Ficha, itens12.Soma));
            }

            return r12;
        }
    }
}