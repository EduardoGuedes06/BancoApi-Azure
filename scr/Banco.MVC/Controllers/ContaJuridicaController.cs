using Microsoft.AspNetCore.Mvc;
using Business.Interfaces;
using AutoMapper;
using Banco.MVC.ViewModel;

namespace Banco.MVC.Controllers
{
    //[Authorize]
    public class ContaJuridicaController : BaseController
    {
        private readonly IContaJuridicaRepository _contaJuridicaRepository;
        private readonly IContaJuridicaService _contaJuridicaService;
        private readonly IMapper _mapper;

        public ContaJuridicaController(IContaJuridicaRepository contaJuridicaRepository,
            IContaJuridicaService contaJuridicaService,
            IMapper mapper,
            INotificador notificador) : base(notificador)
        {
            _contaJuridicaRepository = contaJuridicaRepository;
            _contaJuridicaService = contaJuridicaService;
            _mapper = mapper;
        }
        //[AllowAnonymous]
        [Route("lista-de-contas-juridicas")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ContaJuridicaViewModel>>(await _contaJuridicaRepository.ObterTodos()));
        }

        //[AllowAnonymous]
        [Route("dados-da-conta-juridica/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var contaJViewModel = await ObterContaPorId(id);

            if (contaJViewModel == null)
            {
                return NotFound();
            }

            return View(contaJViewModel);
        }

        [Route("excluir-contajuridica/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var contaJViewModel = await ObterContaPorId(id);

            if (contaJViewModel == null)
            {
                return NotFound();
            }
           

            return View(contaJViewModel);

        }

        [Route("excluir-contajuridica/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var contaF = await ObterContaPorId(id);

            if (contaF == null) return NotFound();

            await _contaJuridicaService.Remover(id);

            if (!OperacaoValida()) return View(contaF);

            return RedirectToAction("Index");
        }



        private async Task<ContaJuridicaViewModel> ObterContaPorId(Guid id)
        {
            return _mapper.Map<ContaJuridicaViewModel>(await _contaJuridicaRepository.ObterPorId(id));
        }
    }
}
