using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Model;

namespace ProjetoElevador.View
{
    public class PainelElevador
    {

        public PainelElevador(Elevador elevador)
        {
            Console.WriteLine("Digite a quantidade de andares do Predio:");
            int andares = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a capacidade máxima do elevador:");
            int capacidade = int.Parse(Console.ReadLine());

            elevador.Inicializar(capacidade, andares);
        }

        public void exibirDisplayElevador(int x, int y)
        {
            string display = @"
                ┌──────────────────┬─────────────────┐
                │      Andar       │    Ocupantes    │
                ├──────────────────┼─────────────────┤
                │                  │                 │
                │                  │                 │
                │                  │                 │
                │                  │                 │
                │                  │                 │
                │                  │                 │
                │                  │                 │
                └──────────────────┴─────────────────┘
            ";

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(display.Trim());
        }
    }
}
