using AppWebAula5.Model.entidades;
using AppWebAula5.Model.repository;
using AppWebAula5.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAula5.Model.presenter
{
    public class Presenter<T> where T:IEntidade
    {
       IView<T> view;
       IRepository<T> repositorio;


       public Presenter(IView<T> view, IRepository<T> repositorio)
       {
           this.view = view;
           this.repositorio = repositorio;
           this.AttachEventsToView();
       }

       private void AttachEventsToView()
       {
           view.Carregar += OnLoading;
           view.Adicionar += OnAdicionar;
           view.Alterar += OnAlterar;
           view.Excluir += OnExcluir;
           view.Buscar += OnBuscar;     
       }

       private void OnExcluir(object sender, helpers.CUDEventArgs<T> e)
       {
           repositorio.Excluir(e.Entidade);
       }

       private void OnBuscar(object sender, helpers.BuscarEventArgs<T> e)
       {
           e.Entidade = repositorio.Buscar(e.Codigo);
       }

       private void OnAlterar(object sender, helpers.CUDEventArgs<T> e)
       {
           repositorio.Alterar(e.Entidade);
       }

       private void OnAdicionar(object sender, helpers.CUDEventArgs<T> e)
       {
           repositorio.Adicionar(e.Entidade);
       }

       private void OnLoading(object sender, EventArgs e)
       {
           view.Lista = repositorio.Listar;
       }

    }
}