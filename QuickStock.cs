using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    public abstract class QuickStock
    {
        public abstract bool cadastrar();
        public abstract void excluir(int valor);
        public abstract void alterar(int valor);
    }
}
