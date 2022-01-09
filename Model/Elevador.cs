using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador : IElevador
    {
        // O andar em que o elevador está.
        private int _andar;

        // A capacidade máxima de pessoas.
        private int _capacidade;

        // Ocupantes do elevador.
        private List<Pessoa> _pessoas = new List<Pessoa>();

        // O total de andares que o elevador poderá percorrer.
        private static int _totalAndares = 0;

        public Elevador(List<Pessoa> pessoas)
        {
            _pessoas.AddRange(pessoas);
            
        }

        // Método acessor para o atributo _andar.
        public int Andar
        {
            get { return _andar; }
            set { _andar = value; }
        }

        // Método acessor para o atributo _capacidade.
        public int Capacidade {
            get { return _capacidade; }
            set { _capacidade = value; }
        }

        // Método acessor para a quantidade de ocupantes do elevador.
        public int Pessoas
        {
            get { return _pessoas.Count; }
        }

        // Método estático que retorna o total de andares.
        public static int TotalAndares
        {
            get { return _totalAndares; }
        }

        public int Decer()
        {
            throw new NotImplementedException();
        }

        // Adiciona um ocupante ao elevador
        // e retorna a qtde de ocupantes.
        public int Entrar(Pessoa pessoa)
        {
            try
            {
                _pessoas.Add(pessoa);
            } 
            catch (Exception ex) 
            {
                string msg = ex.Message;
                throw new ArrayTypeMismatchException(msg);
            }

            return _pessoas.Count;
        }

        public void Inicializar(int capacidade, int andares)
        {
            try 
            {
                _capacidade = capacidade;
            } 
            catch (NullReferenceException e) when (capacidade == 0) 
            {
                throw new NullReferenceException(e.Message);
            }
            catch (ArgumentException e) when (capacidade.GetType().Name != "Int")
            {
                throw new ArgumentException($"{e.GetType().Name}: {e.Message}");
            }

            try
            {
                _totalAndares = andares;
            }
            catch (NullReferenceException e) when (andares == 0)
            {
                throw new NullReferenceException(e.Message);
            }
            catch (ArgumentException e) when (andares.GetType().Name != "Int")
            {
                throw new ArgumentException($"{e.GetType().Name}: {e.Message}");
            }
        }

        public int Sair()
        {
            throw new NotImplementedException();
        }

        public int Subir()
        {
            throw new NotImplementedException();
        }
    }
}
