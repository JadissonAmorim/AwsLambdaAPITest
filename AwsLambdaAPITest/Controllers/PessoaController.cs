using Amazon.Lambda.AspNetCoreServer;
using Amazon.Lambda.Core;
using Bogus;
using Entidade.Models;
using Infra.Cotext;
using Infra.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace AwsLambdaAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public List<Pessoa> Select([FromQuery] string input)
        {
            return _pessoaRepository.Select(input);
        }
    }
}
