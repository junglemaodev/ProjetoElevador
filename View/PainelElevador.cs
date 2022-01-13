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
        private readonly int _top = Console.WindowTop;
        private readonly int _left = Console.WindowLeft;

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

            switch (andares)
            {
                case 0:
                    throw new ArgumentNullException("O prédio deve possuir ao menos dois andares.");

                case > 99:
                    throw new ArgumentException("A quantidade de andares não poderá exceder 99.");
            }
 
            Console.WriteLine("Digite a capacidade máxima do elevador:");
            int capacidade = int.Parse(Console.ReadLine());

             if (capacidade == 0)
                throw new ArgumentNullException("O elevador não pode ter capacidade nula.");

            elevador.Inicializar(capacidade, andares);
            Console.Clear();
        }

        // Exbibe um painel à direita da tela que exibirá
        // o ANDAR e a qtde de OCUPANTES durante o funcionamento
        // do Elevador.
        public void exibirDisplayElevador(int x, int y)
        {
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
            Console.SetCursorPosition(_left, _top);            
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

        public void ExibirElevador(int x, int y)
        {
            string[] graphElevator = System.IO.File.ReadAllLines($"{_path}ElevatorClosed2.txt");
            int h = graphElevator.Length;

            Console.SetCursorPosition(_left, _top);
            foreach(string line in graphElevator)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(line);
                y++;
            }
            Console.WriteLine();
        }


        public void AnimarPessoaIn(int x, int y)
        {
            string[] graphPeople = System.IO.File.ReadAllLines($"{_path}people.txt");
            int h = graphPeople.Length;
            
            Console.SetCursorPosition(_left, _top);
            int stopx = Console.WindowWidth - 31 - x - graphPeople[0].Length;
            for(int i = x; i > stopx; i--){
                int j = y;
                Thread.Sleep(100);
                foreach (string line in graphPeople)
                {
                    Console.SetCursorPosition(_left, _top);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(i, j);                    
                    Console.Write(line);
                    j++;
                }
                Console.ResetColor();
            }

        }
    }
}
