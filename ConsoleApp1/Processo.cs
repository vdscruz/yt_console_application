using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Processo : IProcesso
    {
        public Processo()
        {

        }

        public string getProcesso()
        {
            return "Processo rodando...";
        }
    }
}
