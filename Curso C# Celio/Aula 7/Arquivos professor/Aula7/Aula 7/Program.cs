using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7
{
    class Program
    {
        static void SimpleSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = from c in context.Produto select c;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

        static void SimpleSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }


/// <summary>
/// 
/// </summary>

        static void ConsultandoCincoSimpleSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = (from p in context.Produto select p.Nome.Take(5));
                foreach (var item in query)
                {
                    //Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

        static void ConsultandoCincoSimpleSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Take(5);
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

//////////////////////        

        //pula x  itens conforme o numero do skip, e pega os x itens apos o skip
        static void SkipTakeSimpleSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.OrderBy(p=>p.Nome).Skip(3).Take(5);
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }


/// <summary>
/// 
/// </summary>

        static void WhereSimpleSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = from p in context.Produto where p.Nome == "Nokia Lumia 800" select p;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

        static void WhereSimpleSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p=> p.Nome == "Nokia Lumia 800");
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

/// <summary>
/// 
/// </summary>

        static void ContainsSimpleSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = from p in context.Produto where p.Nome.Contains("Nokia") select p;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

        static void ContainsSimpleSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p => p.Nome.Contains("Nokia"));
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

/// <summary>
/// 
/// </summary>

        static void DoisWhereSimpleSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = from p in context.Produto where p.Custo < 1000 && p.Nome.Contains("Tablet") select p;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

        static void DoisWhereSimpleSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p => p.Custo < 1000 && p.Nome.Contains("Tablet"));
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

/// <summary>
/// 
/// </summary>

        static void BuscaGruposSimpleSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = from p in context.Produto where p.Grupo.Nome == "Games"  select p;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

        static void BuscaGruposSimpleSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p => p.Grupo.Nome == "Games");
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

/// <summary>
/// 
/// </summary>

        static void OrdenaSimpleSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = from p in context.Produto where p.Grupo.Nome == "Games" orderby p.Nome select p;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

        static void OrdenaSimpleSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p => p.Grupo.Nome == "Games").OrderBy(p=>p.Nome);
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }


        /// <summary>
        /// 
        /// </summary>

        static void OrdenaDecrescenteSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = from p in context.Produto where p.Grupo.Nome == "Games" orderby p.Nome, p.Custo descending select p;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1} - {2:C}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }

        static void OrdenaDecrescenteSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p => p.Grupo.Nome == "Games").OrderByDescending(p => new { p.Nome, p.Custo });
                foreach (var item in query)
                {
                    Console.WriteLine("{0} - {1} - {2:C}", item.Id, item.Nome);
                }
                Console.Read();
            }
        }


        /// <summary>
        /// 
        /// </summary>

        static void FirstSelectLinq()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = (from p in context.Produto where p.Grupo.Nome == "Games" orderby p.Nome, p.Custo descending select p).First();
                    Console.WriteLine("{0} - {1}", query.Id, query.Nome);
                Console.Read();
            }
        }

        static void FirstSelectLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.First(p => p.Grupo.Nome == "Celular");
                    Console.WriteLine("{0} - {1}", query.Id, query.Nome);
                Console.Read();
            }
        }

/// <summary>
/// 
/// </summary>


        static void SomatorioLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                int? estoque = context.Produto.Where(p => p.Grupo.Id == 1).Sum(x=>x.Saldo);
                Console.WriteLine("Saldo: {0}", estoque);
                Console.Read();
            }
        }

        static void SomatorioAgrupadosLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var mResult = context.Produto.Where(p => p.Grupo.Id == 1).
                    GroupBy(x => x.IdGrupo).
                    Select(somatorio => new
                    {
                        TotalSaldo = somatorio.Sum(x => x.Saldo),
                        TotalVenda = somatorio.Sum(x => x.Venda),
                    }).SingleOrDefault();

                Console.WriteLine("{0} - {1}", mResult.TotalSaldo, mResult.TotalVenda);
                Console.Read();
            }
        }

        static void ComDTOSomatorioAgrupadosLambda()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                DTO mResult = context.Produto.Where(p => p.Grupo.Id == 1).
                    GroupBy(x => x.IdGrupo).
                    Select(somatorio => new DTO
                    {
                        TotalSaldo = somatorio.Sum(x => x.Saldo),
                        TotalVenda = somatorio.Sum(x => x.Venda),
                    }).SingleOrDefault();

                Console.WriteLine("{0} - {1}", mResult.TotalSaldo, mResult.TotalVenda);
                Console.Read();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void TesteConexao()
        {
            List<Produto> produtos = null;
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p => p.Nome.Contains("Sony"));

                produtos = query.ToList();
            }
                //vai dar erro pois a conexao encerrou com o } acima.
                //foreach (var item in produtos)
                //{
                //    Console.WriteLine("{0} - {1} - {2}", item.Id, item.Nome, item.Grupo.Nome);
                //}

                //esta avaixo representa o maneira que não ira dar erro, pois, 
                //o using foi encerrado e não foi possivel pegar o nome do grupo conforme o exemplo acima.
                foreach (var item in produtos)
                {
                    Console.WriteLine("{0} - {1}", item.Id, item.Nome);
                }

                Console.Read();
        }

        /// <summary>
        /// 
        /// </summary>
        
        static void ExemploEdit()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var mresult = context.Produto.Single(x => x.Id == 1);
                mresult.Nome = "Alterado";
                mresult.Saldo = 12;
                context.SaveChanges();//salva as alterações
            }
            Console.Read();
        }

        /// <summary>
        /// 
        /// </summary>
        
        static void AddGrupo()
        {
            Grupo grupo = new Grupo();
            grupo.Nome = "informatica";

            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                context.Grupo.Add(grupo);
                context.SaveChanges();//salva as alterações
            }
            Console.Read();
        }

        static void AddList()
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo grupo2 = new Grupo();
            grupo2.Nome = "informatica2";

            Grupo grupo3 = new Grupo();
            grupo3.Nome = "informatica3";

            grupos.Add(grupo2);
            grupos.Add(grupo3);


            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                context.Grupo.AddRange(grupos);
                context.SaveChanges();//salva as alterações
            }
            Console.Read();
        }
        /// <summary>
        /// 
        /// </summary>

        static void AddProdutoEGrupo()
        {
            Produto produto = new Produto
            {
                Nome = "produto 3",
                Custo = 100,
                Venda = 200,
                Saldo = 400,
                Grupo = new Grupo
                {
                    Nome = "grupo teste",
                }
            };
                using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
                {
                    context.Produto.Add(produto);
                    context.SaveChanges();//salva as alterações
                }
            Console.Read();
        }

        static void ExemploJoin()
        {

            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p=> p.Nome == "tablet")
                    .Join(context.Grupo, 
                    produto=> produto.IdGrupo,
                    grupo => grupo.Id,
                    (qualquercoisa1, qualquercoisa2)=>new
                    {
                        IdGrupo = qualquercoisa2.Id,
                        IdProduto = qualquercoisa1.Id,
                        NomeProduto = qualquercoisa2.Nome,
                        qualquercoisa1.Saldo

                    }
                );

                foreach (var item in query)
                {

                }

            }
            

        }



        static void ExemploDelete()
        {
            using (UNIVALI_CSHARPEntities context = new UNIVALI_CSHARPEntities())
            {
                var query = context.Produto.Where(p => p.Nome == "Sony").Single();
                context.Produto.Remove(query);
                context.SaveChanges();//salva as alterações
            }
        }
       



        static void Main(string[] args)
        {
            //SimpleSelectLambda();
            //SomatorioAgrupadosLambda();
            //TesteConexao();
            //ExemploEdit();
            //AddList();
            AddProdutoEGrupo();
        }
    }
}
