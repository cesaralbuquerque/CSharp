using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadernoDecoraFestas.Models
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed = false ;
        private CadastroDeFornecedoresContext context = new CadastroDeFornecedoresContext();
        private FornecedorRepository fornecedorRepository ;

        public FornecedorRepository FornecedorRepository
        {
            get
            {
                if (fornecedorRepository == null)
                {
                    fornecedorRepository = new FornecedorRepository(context);
                }
                return fornecedorRepository;
            }
        }

        public void Salva ()
        {
            context.SaveChanges ();
        }

        protected virtual void Dispose ( bool disposing )
        {
            if (! this.disposed )
            {
                if ( disposing )
                {
                    context.Dispose();
                }
            }
            this.disposed = true ;
        }

        public void Dispose ()
        {
            Dispose ( true );
            GC.SuppressFinalize ( this );
        }

    }
}