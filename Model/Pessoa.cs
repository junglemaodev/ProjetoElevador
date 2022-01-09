using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Pessoa
    {
        // O andar para qual o ocupante irá.
        private int _andar;

        // O total de andares que limitará
        // a ação de solicitar um andar.
        private int _maxAndares = Elevador.TotalAndares;
        public int Andar 
        {
            get { return _andar; }
            set { _andar = value; }
        }

        // Ao instanciar um objeto da classe Pessoa 
        // um andar será fornecido automaticamente, 
        // desde de que não seja o mesmo andar em que
        // o elevador está (parâmetro int n).
        public Pessoa(int n)
        {
            do
            {
                Random rand = new Random();
                Andar = rand.Next(0, _maxAndares);

                if (Andar != n)
                    break;
                
            } while (true);
            
            
        }
    }
}
