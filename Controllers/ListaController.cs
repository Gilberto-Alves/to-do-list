using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Infrastruct.Repositories;
using TodoApi.Models.Interface;
using TodoApi.ViewModel;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListaController : ControllerBase
    {
        private readonly ILista _lista;

        public ListaController(ILista lista){
            this._lista = lista;
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(ListaViewModel listaViewModel){
            await _lista.PostItem(listaViewModel);

            return Created("", listaViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var lista = await _lista.GetAllItems();

            return Ok(lista);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetItem(int id){
            var item = await _lista.GetItem(id);

            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutItem(int id, ListaViewModel listaViewModel){
            
            await _lista.PutItem(id, listaViewModel);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAll(){
            await _lista.DeleteAll();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteItem(int id){

            await _lista.DeleteItem(id);

            return Ok();
        }
    }
}