using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinForm.Model
{
    public class ConversorDeNumeroRomano
    {
        Dictionary<char, int> tabela = new Dictionary<char, int>();
        
        public ConversorDeNumeroRomano()
        {
            tabela.Add('I', 1);
            tabela.Add('V', 5);
            tabela.Add('X', 10);
            tabela.Add('L', 50);
            tabela.Add('C', 100);
            tabela.Add('D', 500);
            tabela.Add('M', 1000);
        }

        public int Converte(string numeroRomano)
        {
            int acumulador = 0;
            int ultimoVizinhoDaDireita = 0;

            for (int i = numeroRomano.Length - 1; i >= 0; i--)
            {
                // pega o inteiro referente ao simbolo atual
                int atual = tabela[numeroRomano[i]];
                
                // se o da direita for menor, o multiplicaremos
                // por -1 para torná-lo negativo
                int multiplicador = 1;
                if (atual < ultimoVizinhoDaDireita) multiplicador = -1;

                acumulador += atual * multiplicador;
                
                // atualiza o vizinho da direita
                ultimoVizinhoDaDireita = atual;
            }
            
            return acumulador;
        }
    }
}
