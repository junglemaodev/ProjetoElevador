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
        private Elevador _elevador = new Elevador();
        private List<Pessoa> _pessoas = new List<Pessoa>();

        public ElevadorController()
        {
            PainelElevador painel  = new PainelElevador(_elevador);
        }
    }
}
