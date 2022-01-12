using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProjetoElevador.Model;

namespace ProjetoElevador.View
{
    public class PainelElevador
    {

        private string _path;
        private string[] _display;

        // Promove a iteração a partir da tela do console
        // para obter as informações necessárias a inicialização
        // do objeto Elevador.
        public PainelElevador(Elevador elevador)
        {
            _path = @"C:\Users\adeni\Development\Samsung Ocean\";
            _path += @"Formacao_MS-Dev\ProjetoElevador\TextFiles\";

            _display = System.IO.File.ReadAllLines($"{_path}display.txt");

            Console.WriteLine("Digite a quantidade de andares do Predio:");
            int andares = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a capacidade máxima do elevador:");
            int capacidade = int.Parse(Console.ReadLine());

            elevador.Inicializar(capacidade, andares);
        }

        // Exbibe um painel à direita da tela que exibirá
        // o ANDAR e a qtde de OCUPANTES durante o funcionamento
        // do Elevador.
        public void exibirDisplayElevador(int x, int y)
        {
            Console.Clear();

            foreach(string line in _display)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(line);
                y++;
            }
        }

        // Limpará os campos do painel a cada 
        // nova exibição de informações.
        public void LimparDisplay (int x, int y)
        {
            int left = Console.WindowLeft, top = Console.WindowTop;

            Console.SetCursorPosition(left, top);
            Console.Clear();
            foreach (string line in _display)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(line.Replace("#", " "));
                y++;
            }
        }

        // Escreverá na área à esquerda do painel
        public void ExibirAndar(int n)
        {
            // Algarismos exibidos em ASCII art.
            string[] alg1;
            string[] alg2;
            string[] alg99;            

            // Carregando os respectivos algarismos
            // conforme o inteiro informado.
            alg1 = System.IO.File.ReadAllLines($"{_path}{n.ToString("00")[0]}.txt");
            alg2 = System.IO.File.ReadAllLines($"{_path}{n.ToString("00")[1]}.txt");
            alg99 = System.IO.File.ReadAllLines($"{_path}none.txt");

            // Aglutinando as linhas dos algarismos
            // alg1 e alg2 e exibindo na tela
            for (int i = 0; i < alg1.Length; i++)
            {
                alg99[i] = $"{alg1[i]}{alg2[i].Substring(1)}";
                Console.SetCursorPosition(74, 5 + i);
                Console.Write(alg99[i]);
            }
        }

        // Escreverá na área à direita do painel
        public void ExibirOcupantes(int n)
        {
            // Algarismos exibidos em ASCII art.
            string[] alg1;
            string[] alg2;
            string[] alg99;

            // Carregando os respectivos algarismos
            // conforme o inteiro informado.
            alg1 = System.IO.File.ReadAllLines($"{_path}{n.ToString("00")[0]}.txt");
            alg2 = System.IO.File.ReadAllLines($"{_path}{n.ToString("00")[1]}.txt");
            alg99 = System.IO.File.ReadAllLines($"{_path}none.txt");

            // Aglutinando as linhas dos algarismos
            // alg1 e alg2 e exibindo na tela
            for (int i = 0; i < alg1.Length; i++)
            {
                alg99[i] = $"{alg1[i]}{alg2[i].Substring(1)}";
                Console.SetCursorPosition(99, 5 + i);
                Console.Write(alg99[i]);
            }
        }

        public void AtualizarInfoPainel(int andar, int ocupantes)
        {
            ExibirAndar(andar);
            ExibirOcupantes(ocupantes);
        }
    }
}
