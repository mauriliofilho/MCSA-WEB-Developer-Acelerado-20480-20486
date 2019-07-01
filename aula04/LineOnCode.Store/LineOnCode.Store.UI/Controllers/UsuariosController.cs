using LineOnCode.Store.Domain.Contracts.Repositories;
using LineOnCode.Store.UI.ViewModels.Usuarios;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _usuarioRepository.GetAllAsync();
            return View(data);
        }


        [HttpGet]
        public async Task<IActionResult> AddEdit(int? id)
        {
            AddEditVM vm = null;

            if (id != null)
            {
                var data = await _usuarioRepository.GetAsync((int)id);
                if (data == null) return NotFound();

                vm = data.ToUsuarioVM();
            }

            return View(vm);
        }

        [HttpPost]
        public IActionResult AddEdit(int Id, AddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (Id == 0)
            {
                _usuarioRepository.Add(model.ToUsuario());
            }
            else
            {
                _usuarioRepository.Edit(model.ToUsuario(Id));
            }
            return RedirectToAction("Index");

        }


        [HttpDelete]
        public async Task<IActionResult> Excluir(int id)
        {
            var data = await _usuarioRepository.GetAsync(id);

            if (data == null) return NotFound();

            _usuarioRepository.Delete(data);
            return NoContent();
        }
    }
}
