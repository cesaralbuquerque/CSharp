using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace CadernoDecoraFestas.Models
{
    public class FornecedorRepository : IDisposable
    {
        private bool disposed = false;
        private CadastroDeFornecedoresContext context;

        public FornecedorRepository(CadastroDeFornecedoresContext context)
        {
            this.context = context;
        }

        public void Adiciona(Fornecedor fornecedor)
        {
            context.Fornecedores.Add(fornecedor);
            Salva();
        }

        public List<Fornecedor> Fornecedores
        {
            get { return context.Fornecedores.ToList(); }
        }

        public void Salva()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Fornecedor Busca(int id)
        {
            return context.Fornecedores.Find(id);
        }

        public void Remove(int id)
        {
            Fornecedor fornecedor = Busca(id);
            context.Fornecedores.Remove(fornecedor);
            Salva();
        }

        public void Edita(Fornecedor fornecedor)
        {
            context.Entry(fornecedor).State = EntityState.Modified;
            context.Fornecedores.Attach(fornecedor);
            Salva();
        }



        public Fornecedor LocalizaLoginSenha(Fornecedor fornecedor)
        {
            try
            {
                IQueryable<Fornecedor> q = context.Fornecedores.Where(f => f.Login == fornecedor.Login && f.Senha == fornecedor.Senha);
                List<Fornecedor> l = q.ToList();
                return l[0];
            }
            catch
            {
                return null;
            }
        }

        public Fornecedor LocalizaNome(string login)
        {
            try
            {
                IQueryable<Fornecedor> q = context.Fornecedores.Where(f => f.Login == login);
                List<Fornecedor> l = q.ToList();
                return l[0];
            }
            catch
            {
                return null;
            }
        }


    }
}