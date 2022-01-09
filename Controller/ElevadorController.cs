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
        }
    }
}
