using CadastrosAPI.Context;
using CadastrosAPI.Entities;
using CadastrosAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrosAPI.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SqlContext _sqlContext;

        public ProdutoRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
            _sqlContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void Add(Produto produto)
        {
            _sqlContext.Produtos.Add(produto);            
            _sqlContext.SaveChanges();
        }


        public void Delete(Produto produto)
        {
            _sqlContext.Produtos.Remove(produto);
            _sqlContext.SaveChanges();
        }

        public List<Produto> GetAllProdutos()
        {
            return _sqlContext.Produtos.ToList();
        }

        public Produto GetProdutoById(int id)
        {
            return _sqlContext.Produtos.Where(p => p.IdProduto == id).FirstOrDefault();
        }

        public void Update(Produto produto)
        {
            _sqlContext.Produtos.Update(produto);
            _sqlContext.SaveChanges();
        }
    }
}
