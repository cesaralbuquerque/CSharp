using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinForm.Model
{
    public class Humano
    {
        private string TipoSanguineo { get; set; }
        public int Idade { get; set; }
        public int Altura { get; set; }
        public Double Peso { get; set; }
        public string Nome { get; set; }
        
        public void Piscar()
        {
            MessageBox.Show("Piscar os olhos agora.");
        }
        public void Respirar()
        {
            MessageBox.Show("Repirar 1...2...3");
        }
        public void PensarAlgo(string pensamentos, DateTime quando)
        {
            MessageBox.Show("Estou pensando em : " + pensamentos + " pensei nisso agora : " + quando.ToShortTimeString());
        }
        public void SentirFome()
        {
            MessageBox.Show("Estou ficando com fome. Hora do Lanche.");
        }
        private void CantarNoBanheiro()
        {
            MessageBox.Show("Bla ... Bla ... Bla ...");
        }
    }
}
