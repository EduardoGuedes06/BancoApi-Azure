using AutoMapper;
using Banco.ApiCore.ViewModel;
using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using Banco.ApiCore.Controllers;
using Microsoft.AspNetCore.Authorization;

namespace Banco.ApiCore.V1.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/contajuridica")]
    public class ContaJuridicaController : HomeController
    {
        private readonly IContaJuridicaRepository _contaJuridicaRepository;
        private readonly IContaJuridicaService _contaJuridicaService;
        private readonly IMapper _mapper;

        public ContaJuridicaController(IContaJuridicaRepository contaJuridicaRepository,
                                       IContaJuridicaService contaJuridicaService,
                                       INotificador notificador,
                                       IMapper mapper, IUser user) : base(notificador, user)
        {
            _contaJuridicaRepository = contaJuridicaRepository;
            _contaJuridicaService = contaJuridicaService;
            _mapper = mapper;
        }
        [HttpGet]

        public async Task<IEnumerable<ContaJuridicaViewModel>> ObterTodos()
        {

            var contas = _mapper.Map<IEnumerable<ContaJuridicaViewModel>>(await _contaJuridicaRepository.ObterTodos());

            return contas;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ContaJuridicaViewModel>> ObterPorId(Guid id)
        {
            var Conta = _mapper.Map<ContaJuridicaViewModel>(await _contaJuridicaRepository.ObterPorId(id));

            if (Conta == null) return NotFound();

            return Conta;
        }
        [HttpPost]
        public async Task<ActionResult<ContaJuridicaViewModel>> Adicionar(ContaJuridicaViewModel ContaModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _contaJuridicaService.Adicionar(_mapper.Map<ContaJuridica>(ContaModel));

            return CustomResponse(ContaModel);
        }


        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ContaJuridicaViewModel>> Atualizar(Guid id, ContaJuridicaViewModel ContaModel)
        {
            if (id != ContaModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(ContaModel);
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _contaJuridicaService.Atualizar(_mapper.Map<ContaJuridica>(ContaModel));

            return CustomResponse(ContaModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ContaJuridicaViewModel>> Excluir(Guid id)
        {
            var ContaModel = _mapper.Map<ContaJuridicaViewModel>(await _contaJuridicaRepository.ObterPorId(id));

            if (ContaModel == null) return NotFound();

            await _contaJuridicaRepository.Remover(id);

            return CustomResponse(ContaModel);
        }


    }
}
