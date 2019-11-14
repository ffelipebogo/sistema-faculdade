using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Model;


namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticarController : ControllerBase
    {


        // GET: api/ContaReceber
        [HttpPost]
        public int Login([FromBody]UsuarioLoginModel login)
        {
            ClientesDAO DaoCLiente = new ClientesDAO();
            if(login.Cpf.Length == 11)
            {
                var Usuario = DaoCLiente.PesquisaLogin(login.Cpf, login.Senha) as Clientes;
                if (Usuario != null)
                {
                    return Usuario.codigo;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}