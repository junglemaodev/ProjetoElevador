using System;
using System.Linq;
using System.Text;
using ProjetoElevador.Controller;
using ProjetoElevador.Model;
using ProjetoElevador.View;

namespace ProjetoElevador
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ElevadorController elevadorController = new ElevadorController();
        }
    }
}
