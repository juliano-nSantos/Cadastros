using CadastrosAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrosAPI.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(Produto produto);
        List<Produto> GetAllProdutos();
        Produto GetProdutoById(int id);

    }
}
