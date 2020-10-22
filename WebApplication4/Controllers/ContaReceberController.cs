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
    [Route("api/conta-receber")]
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
        public IEnumerable<EquipMotos.MODEL.ContasReceber> Get()
        {
            ClientesDAO DaoCliente = new ClientesDAO();
            FormaPagamentoDAO DaoFormaPagamento = new FormaPagamentoDAO();

            var lista = ContasReceberDAO.ListarTodos();
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new EquipMotos.MODEL.ContasReceber()
                                 {
                                     nrNota = Convert.ToString(rw["nrNota"]),
                                     modelo = Convert.ToString(rw["modelo"]),
                                     serie = Convert.ToString(rw["serie"]),
                                     cliente = DaoCliente.BuscarPorID(rw["codCliente"]) as EquipMotos.MODEL.Clientes,
                                     nrParcela = Convert.ToInt32(rw["nrParcela"]),
                                     vlrParcela = Convert.ToDouble(Convert.ToDouble(rw["valorParcela"]).ToString("N2")),
                                     formaPagamento = DaoFormaPagamento.BuscarPorID(rw["codFormaPagamento"]) as EquipMotos.MODEL.FormaPagamentos,
                                     dtEmissao = Convert.ToDateTime(rw["dtEmissao"]),
                                     dtVencimento = Convert.ToDateTime(Convert.ToDateTime(rw["dtVencimento"]).ToString("dd-MM-yyyy")),
                                     recebido = Convert.ToBoolean(rw["recebido"])
                                 }).ToList();

            return convertedList;
        }

        [Route("filter")]
        [HttpGet]
        public IEnumerable<EquipMotos.MODEL.ContasReceber> GetFilters([FromQuery] string nota, [FromQuery] string cliente, [FromQuery] string formaPagamento, [FromQuery] DateTime dateMin, [FromQuery] DateTime dateMax)
        {
            ClientesDAO DaoCliente = new ClientesDAO();
            FormaPagamentoDAO DaoFormaPagamento = new FormaPagamentoDAO();

            var lista = ContasReceberDAO.BuscarCompra_Filtro(nota, cliente, formaPagamento, dateMin, dateMax);
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new EquipMotos.MODEL.ContasReceber()
                                 {
                                     nrNota = Convert.ToString(rw["nrNota"]),
                                     modelo = Convert.ToString(rw["modelo"]),
                                     serie = Convert.ToString(rw["serie"]),
                                     cliente = DaoCliente.BuscarPorID(rw["codClientes"]) as EquipMotos.MODEL.Clientes,
                                     nrParcela = Convert.ToInt32(rw["nrParcela"]),
                                     vlrParcela = Convert.ToDouble(Convert.ToDouble(rw["valorParcela"]).ToString("N2")),
                                     formaPagamento = DaoFormaPagamento.BuscarPorID(rw["codFormaPagamento"]) as EquipMotos.MODEL.FormaPagamentos,
                                     dtEmissao = Convert.ToDateTime(rw["dtEmissao"]),
                                     dtVencimento = Convert.ToDateTime(Convert.ToDateTime(rw["dtVencimento"]).ToString("dd-MM-yyyy")),
                                     pago = Convert.ToBoolean(rw["pago"])

                                 }).ToList();

            return convertedList;
        }

    }
}
