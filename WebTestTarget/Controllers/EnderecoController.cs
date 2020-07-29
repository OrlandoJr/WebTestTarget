using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebTestTarget.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {
        private readonly IEnderecosAppService _context;
        private readonly IMapper _mapper;

        public EnderecosController(IEnderecosAppService context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Enderecos
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<EnderecosModel>, IEnumerable<EnderecosViewModel>>(await _context.GetAllAsync()));
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        // GET: api/Enderecos/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            try
            {
                return Ok(_mapper.Map<EnderecosModel, EnderecosViewModel>(await _context.GetByIDAsync(Id)));

            }catch (Exception e)
            {
                return Ok(e.Message);
            }
            
        }

        // POST: api/Enderecos
        [HttpPost]
        public async Task<OkObjectResult> Post(EnderecosPostViewModel entity)
        {
            try
            {
                var Enderecos = _mapper.Map<EnderecosPostViewModel, EnderecosModel>(entity);
                return new OkObjectResult(await _context.AddAsync(Enderecos));

            }catch(Exception e)
            {
                return new OkObjectResult(e.Message);
            }
        }

        // PUT: api/Enderecos/5
        [HttpPut]
        public async Task<OkObjectResult> Put(EnderecosPutViewModel entity)
        {
            try
            {
                await _context.UpdateAsync(_mapper.Map<EnderecosPutViewModel, EnderecosModel>(entity));
                return new OkObjectResult("Atualizado");

            }
            catch (Exception e)
            {
                return new OkObjectResult(e.Message);
            }
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{Id}")]
        public async Task<OkObjectResult> Delete(int Id)
        {
            try
            {
                var entity = await _context.GetByIDAsync(Id);
                await _context.RemoveAsync(entity);

                return new OkObjectResult("Deletado");

            }
            catch (Exception e)
            {
                return new OkObjectResult(e.Message);
            }
        }
    }
}
