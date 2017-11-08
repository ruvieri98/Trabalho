using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.App
{
    abstract class AcessoArq
    {
        private FileStream arquivo;
        private BinaryFormatter bf = new BinaryFormatter();



        public void AbrirArquivo(string diretorio)
        {

            File.Delete(diretorio);
            arquivo = new FileStream(diretorio, FileMode.Append);

        }

        public void run()
        {

        }
    }
}
