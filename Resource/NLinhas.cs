namespace Converte_SIAxCTBLT.Models
{
    class NLinhas
    {
        public int Numero { get; set; }

        public NLinhas()
        {
        }

        public void defineNumeroInicio(int n)
        {
            Numero = n;
        }

        public string getProximoN()
        {
            Numero += 1;
            return Numero.ToString().PadLeft(6, '0');
        }
    }
}
