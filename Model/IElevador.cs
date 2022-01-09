using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal interface IElevador
    {
        void Inicializar(int capacidade, int andares);

        int Entrar();

        int Subir();

        int Decer();

        int Sair();
    }
}
