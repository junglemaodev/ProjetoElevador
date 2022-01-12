using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Model;
using ProjetoElevador.View;

namespace ProjetoElevador.Controller
{
    public class ElevadorController
    {
        private List<Pessoa> _pessoas = new List<Pessoa>();
        private Elevador _elevador; 
        

        public ElevadorController()
        {
            _elevador = new Elevador(_pessoas);
            PainelElevador painel  = new PainelElevador(_elevador);
            painel.exibirDisplayElevador(70, 2);
            System.Threading.Thread.Sleep(1500);
            painel.LimparDisplay(70, 2);
            painel.AtualizarInfoPainel(18,10);
            Console.WriteLine("\n\n");
        }
    }
}
