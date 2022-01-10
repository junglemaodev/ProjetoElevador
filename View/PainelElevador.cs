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
    }
}
