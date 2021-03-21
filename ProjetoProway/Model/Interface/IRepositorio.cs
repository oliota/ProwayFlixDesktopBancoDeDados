using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProway.Model.Interface
{
    interface IRepositorio
    {
        bool Adicionar(object item);
        bool Editar(object item, object original);
        bool Deletar(object item);
        void Listar();
        void Listar(object item);
        object Buscar(object item);

    }
}
