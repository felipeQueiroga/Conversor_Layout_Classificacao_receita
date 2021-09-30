using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Converte_SIAxCTBLT.Models
{
    public static class StreamArquivo
    {
        public static List<string> lerAquivo(string path)
        {
            List<string> linhas = new List<string>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        linhas.Add(sr.ReadLine());
                    }

                    sr.Close();
                }
            }

            catch (IOException e)
            {
                MessageBox.Show("Um erro ocorreu ao carregar o arquivo de Origem: " + e.Message);
            }
            return linhas;
        }

        public static void gravarArquivo(string targetPath, List<string> conteudo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(targetPath))
                {
                    foreach (var l in conteudo)
                    {
                        sw.WriteLine(l);
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Um erro ocorreu ao gerar o arquivo final: " + e.Message);
            }
        }
    }
}

