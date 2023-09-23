using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.ViewModel;

namespace TodoApi.Models.Interface
{
    public interface ILista
    {
        public Task<List<Lista>> GetAllItems();
        public Task<Lista> GetItem(int id);

        public Task PostItem(ListaViewModel listaViewModel);
        public Task PutItem(int id, ListaViewModel listaViewModel);
        public Task DeleteAll();
        public Task DeleteItem(int id);
    }
}