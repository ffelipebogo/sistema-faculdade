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
    [Route("api/conta-pagar")]
    [ApiController]
    public class ContaPagarController : ControllerBase
    {
        public ContaPagarController()
        {
            DaoContasPagar = new ContasPagarDAO();
        }

        public ContasPagarDAO DaoContasPagar { get; }

        [HttpGet]
        public IEnumerable<EquipMotos.MODEL.ContasPagar> Get()
        {

            FornecedoresDAO DaoFornecedor = new FornecedoresDAO();
            FormaPagamentoDAO DaoFormaPagamento = new FormaPagamentoDAO();

            var lista = DaoContasPagar.ListarTodos();
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new EquipMotos.MODEL.ContasPagar()
                                 {
                                     nrNota = Convert.ToString(rw["nrNota"]),
                                     modelo = Convert.ToString(rw["modelo"]),
                                     serie = Convert.ToString(rw["serie"]),
                                     fornecedor = DaoFornecedor.BuscarPorID(rw["codFornecedor"]) as EquipMotos.MODEL.Fornecedores,
                                     nrParcela = Convert.ToInt32(rw["nrParcela"]),
                                     vlrParcela = Convert.ToDouble(Convert.ToDouble(rw["valorParcela"]).ToString("N2")),
                                     formaPagamento = DaoFormaPagamento.BuscarPorID(rw["codFormaPagamento"]) as EquipMotos.MODEL.FormaPagamentos,
                                     dtEmissao = Convert.ToDateTime(rw["dtEmissao"]),
                                     dtVencimento = Convert.ToDateTime(Convert.ToDateTime(rw["dtVencimento"]).ToString("dd-MM-yyyy")),
                                     pago = Convert.ToBoolean(rw["pago"])

                                 }).ToList();
            return convertedList;
        }

        [Route("filter")]
        [HttpGet]
        public IEnumerable<EquipMotos.MODEL.ContasPagar> GetFilters([FromQuery] string nota, [FromQuery] string fornecedor, [FromQuery] string formaPagamento, [FromQuery] DateTime dateMin, [FromQuery] DateTime dateMax)
        {
            FornecedoresDAO DaoFornecedor = new FornecedoresDAO();
            FormaPagamentoDAO DaoFormaPagamento = new FormaPagamentoDAO();

            var lista = DaoContasPagar.BuscarCompra_Filtro(nota, fornecedor, formaPagamento, dateMin, dateMax);
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new EquipMotos.MODEL.ContasPagar()
                                 {
                                     nrNota = Convert.ToString(rw["nrNota"]),
                                     modelo = Convert.ToString(rw["modelo"]),
                                     serie = Convert.ToString(rw["serie"]),
                                     fornecedor = DaoFornecedor.BuscarPorID(rw["codFornecedor"]) as EquipMotos.MODEL.Fornecedores,
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
