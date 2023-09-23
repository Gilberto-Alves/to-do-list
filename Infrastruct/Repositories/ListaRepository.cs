using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using TodoApi.Models.Interface;
using TodoApi.ViewModel;

namespace TodoApi.Infrastruct.Repositories
{
    public class ListaRepository : ILista
    {

        private readonly ContextConnection _contextConnection = new ContextConnection();

        public async Task DeleteAll()
        {
            var lista = await GetAllItems();

            _contextConnection.Listas.RemoveRange(lista);

            await _contextConnection.SaveChangesAsync();
        }

        public async Task DeleteItem(int id)
        {
            var item = await GetItem(id);
            _contextConnection.Listas.Remove(item);
            await _contextConnection.SaveChangesAsync();
        }

        public async Task<List<Lista>> GetAllItems()
        {
            var lista = await _contextConnection.Listas.ToListAsync();

            return lista;
        }

        public async Task<Lista> GetItem(int id)
        {
            var item = await _contextConnection.Listas.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public async Task PostItem(ListaViewModel listaViewModel)
        {
            var lista = new Lista(listaViewModel.Descricao, listaViewModel.Conclusao, listaViewModel.Editado);

            await _contextConnection.Listas.AddAsync(lista);
            await _contextConnection.SaveChangesAsync();
        }

        public async Task PutItem(int id, ListaViewModel listaViewModel)
        {
            var item = await GetItem(id);

            item.Descricao = listaViewModel.Descricao;
            item.Conclusao = listaViewModel.Conclusao;
            item.Editado = listaViewModel.Editado;

            _contextConnection.Listas.Update(item);
            await _contextConnection.SaveChangesAsync();
        }
    }
}