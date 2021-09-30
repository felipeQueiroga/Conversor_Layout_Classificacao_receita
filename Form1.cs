using Converte_SIAxCTBLT.Models;
using Converte_SIAxCTBLT.Transporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Converte_SIAxCTBLT

{
    public partial class Form1 : Form
    {
        List<LayOutSIA> layOutSIA = new List<LayOutSIA>();
        List<LogProcessados> logs = new List<LogProcessados>();
        List<LayOutNeA_Lote10> LayOutNea;
        string nomeAquivoNea = "";
        NLinhas nLinhas = new NLinhas();

        public Form1()
        {
            if (DateTime.Now.ToString("yy") == "21")
            {
                InitializeComponent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lida apresentacao arquivo do historico
            carregaHistorico();
            dataGridViewHist.DataSource = logs;
            tabPageHist.Focus();
        }

        private void carregaLaoutSia()
        {
            string pathArquivoEntrada = textBoxPath.Text;
            List<String> linhasArquivo = StreamArquivo.lerAquivo(pathArquivoEntrada);
            layOutSIA.Clear();
            foreach (var item in linhasArquivo)
            {
                layOutSIA.Add(LayOutSIA.layOutLeitura(item));
            }

            MessageBox.Show("Arquivo SIA carregado com Sucesso!");

            //Lida apresentacao arquivo de origem 
            dataGridViewSia.DataSource = layOutSIA;
            tabPageSia.Focus();
        }

        private void carregaHistorico()
        {
            string pathLog = LogProcessados.Path;
            List<String> linhas = StreamArquivo.lerAquivo(pathLog);
            foreach (var item in linhas)
            {
                logs.Add(LogProcessados.layOutLeitura(item));
            }

        }

        private void atualizaHistorico()
        {
            var lote = LayOutNea.Select(x => x.IdLote).Last();
            var data = DateTime.Now.ToString("dd/MM/yyyy");
            var arquivo = nomeAquivoNea;
            var dataInicial = LayOutNea.Select(x => x.DataLancamento).First();
            var dataFinal = LayOutNea.Select(x => x.DataLancamento).Last();
            LogProcessados l = new LogProcessados(lote, data,
                                                   dataInicial.ToString("dd/MM/yyyy"),
                                                   dataFinal.ToString("dd/MM/yyyy"),
                                                   arquivo);
            logs.Add(l);
        }

        private void gravaHistorico()
        {
            List<string> conteudo = new List<string>();
            //percorre log ja carregado
            foreach (var item in logs)
            {
                conteudo.Add(item.ToString());
            }
            StreamArquivo.gravarArquivo(LogProcessados.Path, conteudo);
        }

        private void processaLayoutEntrada()
        {
            LayOutNea = SiaPrencheNea.retornaRegistros(layOutSIA);
            dataGridViewFinal.DataSource = LayOutNea;
            dataGridViewFinal.Show();
        }

        private void gravarArquivoFinal()
        {
            nLinhas.defineNumeroInicio(0);
            List<String> conteudo = new List<string>();
            nomeAquivoNea = LayOutNeA_ArquivoNome.NomeArquivo();
            string pathDestino = @"C:\LayOut CTBL\Arquivos\" + nomeAquivoNea;

            //percorre registro cabecalho
            foreach (var r10 in LayOutNea)
            {
                conteudo.Add(r10.ToString() + nLinhas.getProximoN());
                //percorre gegistro filho
                foreach (var r11 in r10.RegistroValoresBancos)
                {
                    conteudo.Add(r11.ToString() + nLinhas.getProximoN());
                    //percorre gegistro detalhe
                    foreach (var r12 in r11.RegistroValoresFichas)
                    {
                        conteudo.Add(r12.ToString() + nLinhas.getProximoN());
                    }
                }
            }

            StreamArquivo.gravarArquivo(pathDestino, conteudo);
            MessageBox.Show("Arquivo Gerado com sucesso em: \n" + pathDestino);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBoxPath.Text = openFileDialog1.FileName;
            }
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            carregaLaoutSia();
            processaLayoutEntrada();
            gravarArquivoFinal();
            atualizaHistorico();
            gravaHistorico();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
