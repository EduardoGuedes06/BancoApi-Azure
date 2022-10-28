using Microsoft.AspNetCore.Mvc;
using Business.Interfaces;
using AutoMapper;
using Banco.MVC.ViewModel;

namespace Banco.MVC.Controllers
{
    //[Authorize]
    public class ContaFisicaController : BaseController
    {
        private readonly IContaFisicaRepository _contaFisicaRepository; 
        private readonly IContaFisicaService _contaFisicaService;
        private readonly IMapper _mapper;

        public ContaFisicaController(IContaFisicaRepository contaFisicaRepository,
            IContaFisicaService contaFisicaService,
            IMapper mapper,
            INotificador notificador) : base(notificador)
        {
            _contaFisicaRepository = contaFisicaRepository;
            _contaFisicaService = contaFisicaService;
            _mapper = mapper;
        }
        //[AllowAnonymous]
        [Route("lista-de-contas-fisicas")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ContaFisicaViewModel>>(await _contaFisicaRepository.ObterTodos()));
        }

        //[AllowAnonymous]
        [Route("dados-da-conta-fisica/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var contaFViewModel = await ObterContaPorId(id);

            if(contaFViewModel == null)
            {
                return NotFound();
            }

            return View(contaFViewModel);
        }

        [Route("excluir-contafisica/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var contaFViewModel = await ObterContaPorId(id);

            if (contaFViewModel == null)
            {
                return NotFound();
            }

            return View(contaFViewModel);

        }

        [Route("excluir-contafisica/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var contaF = await ObterContaPorId(id);

            if (contaF == null) return NotFound();

            await _contaFisicaService.Remover(id);

            if (!OperacaoValida()) return View(contaF);

            return RedirectToAction("Index");
        }



        private async Task<ContaFisicaViewModel> ObterContaPorId(Guid id)
        {
            return _mapper.Map<ContaFisicaViewModel>(await _contaFisicaRepository.ObterPorId(id));
        }
    }
}
