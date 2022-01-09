using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public interface IElevador
    {
        void Inicializar(int capacidade, int andares);

        int Entrar(Pessoa pessoa);

        int Subir();

        int Decer();

        int Sair(Pessoa pessoa);
    }
}
