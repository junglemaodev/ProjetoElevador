using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador : IElevador
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
            _pessoas = pessoas;
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
            try
            {
                if (Andar > 0)
                {
                    Andar--;
                    foreach (Pessoa pessoa in _pessoas)
                    {
                        if (pessoa.Andar == Andar)
                        {
                            Sair(pessoa);
                        }
                    }
                }

                return Andar;
            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.Message);
            }
        }

        // Adiciona um ocupante ao elevador,
        // desde que não exceda a capacidade
        // e retorna a qtde de ocupantes.
        public int Entrar(Pessoa pessoa)
        {
            try
            {
                if (Pessoas < Capacidade)
                {
                    _pessoas.Add(pessoa);
                }
                else
                {
                    // Exceção disparada ao atingir a capacidade máxima.
                    throw new IndexOutOfRangeException("Aguarde sua vez...\nElevador lotado.");
                }
            } 
            catch (ArrayTypeMismatchException ex) 
            {
                // A exceção é gerada caso ocorra uma tentativa de armazenar
                // um elemento do tipo errado na lista de Pessoas. 
                throw new ArrayTypeMismatchException(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.SetCursorPosition(Console.WindowLeft, Console.WindowTop);
                Console.Clear();
                Console.WriteLine(ex.Message);
            }

            return Pessoas;
        }

        public void Inicializar(int capacidade, int andares)
        {
            try
            {
                _capacidade = capacidade;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                _totalAndares = andares;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        // Remove da lista de ocupantes a pessoa 
        // correspondente ao índice informado e
        // retorna a quantidade de ocupantes.
        public int Sair(Pessoa p)
        {
            try
            {
                _pessoas.Remove(p);
            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.Message);
            }
            
            return _pessoas.Count;
        }

        public int Subir()
        {
            try
            {
                if (Andar != TotalAndares)
                {
                    Andar++;
                    foreach (Pessoa pessoa in _pessoas)
                    {
                        if (pessoa.Andar == Andar)
                        {
                            Sair(pessoa);
                        }
                    }
                }

                return Andar;
            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.Message);
            }
        }
    }
}
