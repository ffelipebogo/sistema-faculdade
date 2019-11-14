using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using EquipMotos.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaReceberController : ControllerBase
    {
        public ContaReceberController()
        {
            ContasReceberDAO = new ContasReceberDAO();
        }

        public ContasReceberDAO ContasReceberDAO { get; }


        // GET: api/ContaReceber
        [HttpGet]
        public IEnumerable<EquipMotos.MODEL.ContasReceber> Get([FromQuery(Name = "codigo")] int codigo)
        {
            EquipMotos.DAO.ContasReceberDAO DaoContaReceber = new EquipMotos.DAO.ContasReceberDAO();
            EquipMotos.DAO.ClientesDAO DaoCliente = new EquipMotos.DAO.ClientesDAO();
            EquipMotos.DAO.FormaPagamentoDAO DaoFormaPagamento = new EquipMotos.DAO.FormaPagamentoDAO();

            var lista = DaoContaReceber.ListaPorCliente(codigo);
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new EquipMotos.MODEL.ContasReceber()
                                 {
                                     nrNota = Convert.ToString(rw["nrNota"]),
                                     modelo = Convert.ToString(rw["modelo"]),
                                     serie = Convert.ToString(rw["serie"]),
                                     cliente = DaoCliente.BuscarPorID(rw["codCliente"]) as EquipMotos.MODEL.Clientes,
                                     nrParcela = Convert.ToInt32(rw["nrParcela"]),
                                     vlrParcela = Convert.ToInt32(rw["valorParcela"]),
                                     formaPagamento = DaoFormaPagamento.BuscarPorID(rw["codFormaPagamento"]) as EquipMotos.MODEL.FormaPagamentos,
                                     dtEmissao = Convert.ToDateTime(rw["dtEmissao"]),
                                     dtVencimento = Convert.ToDateTime(rw["dtVencimento"])
                                 }).ToList();

            return convertedList;
        }

     
    }
}
