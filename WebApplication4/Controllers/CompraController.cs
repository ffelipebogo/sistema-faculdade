using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace WebEquipMoto.Controllers
{
    [Route("api/compra")]
    [ApiController]
    public class CompraController
    {
        public CompraController()
        {
            DaoCompra = new ComprasDAO();
        }

        public ComprasDAO DaoCompra { get; }

        [HttpGet]
        public IEnumerable<Compras> Get()
        {
            FornecedoresDAO DaoFornecedor = new FornecedoresDAO();
            CondicaoPagamentoDAO DaoCondPagamento = new CondicaoPagamentoDAO();

            var lista = DaoCompra.ListarTodos();
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new Compras()
                                 {
                                     modelo = Convert.ToString(rw["modelo"]),
                                     serie = Convert.ToString(rw["serie"]),
                                     nrNota = Convert.ToString(rw["nrNota"]),
                                     fornecedor = DaoFornecedor.BuscarPorID(Convert.ToInt64(rw["codFornecedor"])) as Fornecedores,
                                     condPagamento = DaoCondPagamento.BuscarPorID(Convert.ToInt64(rw["codCondPagamento"])) as CondicaoPagamentos,
                                     dtEmissao = Convert.ToDateTime(rw["dtEmissao"]),
                                     dtChegada = Convert.ToDateTime(rw["dtChegada"]),
                                     cfi = Convert.ToBoolean(rw["cfi"]),
                                     frete = Convert.ToDouble(Convert.ToDouble(rw["frete"]).ToString("N2")),
                                     seguro = Convert.ToDouble(Convert.ToDouble(rw["seguro"]).ToString("N2")),
                                     despesa = Convert.ToDouble(Convert.ToDouble(rw["despesa"]).ToString("N2")),
                                     situacao = Convert.ToBoolean(rw["situacao"]),
                                     observacoes = Convert.ToString(rw["observacoes"]),
                                     dtCadastro = Convert.ToDateTime(Convert.ToDateTime(rw["dtCadastro"]).ToString("dd-MM-yyyy")),
                                     dtAlteracao = Convert.ToDateTime(rw["dtAlteracao"]),
                                     totalProduto = Convert.ToDouble(Convert.ToDouble(rw["totalProduto"]).ToString("N2")),
                                     totalPagar = Convert.ToDouble(Convert.ToDouble(rw["totalPagar"]).ToString("N2")),
                                     usuario = Convert.ToString(rw["usuario"]),
                                     listaItem = DaoCompra.BuscarItem(Convert.ToString(rw["modelo"]), Convert.ToString(rw["serie"]), Convert.ToString(rw["nrNota"]), Convert.ToInt64(rw["codFornecedor"])),
                                     listaContasPagar = DaoCompra.BuscarContasPagar(Convert.ToString(rw["modelo"]), Convert.ToString(rw["serie"]), Convert.ToString(rw["nrNota"]), Convert.ToInt64(rw["codFornecedor"])),
                                 }).ToList();
            return convertedList;
        }

        [Route("filter")]
        [HttpGet]
        public IEnumerable<Compras> GetFilters( [FromQuery] string nota, [FromQuery] string fornecedor, [FromQuery] DateTime dateMin, [FromQuery] DateTime dateMax)
        {
            FornecedoresDAO DaoFornecedor = new FornecedoresDAO();
            CondicaoPagamentoDAO DaoCondPagamento = new CondicaoPagamentoDAO();

            var lista = DaoCompra.BuscarCompra_Filtro(nota, fornecedor, dateMin, dateMax);
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new Compras()
                                 {
                                     modelo = Convert.ToString(rw["modelo"]),
                                     serie = Convert.ToString(rw["serie"]),
                                     nrNota = Convert.ToString(rw["nrNota"]),
                                     fornecedor = DaoFornecedor.BuscarPorID(Convert.ToInt64(rw["codFornecedor"])) as Fornecedores,
                                     condPagamento = DaoCondPagamento.BuscarPorID(Convert.ToInt64(rw["codCondPagamento"])) as CondicaoPagamentos,
                                     dtEmissao = Convert.ToDateTime(rw["dtEmissao"]),
                                     dtChegada = Convert.ToDateTime(rw["dtChegada"]),
                                     cfi = Convert.ToBoolean(rw["cfi"]),
                                     frete = Convert.ToDouble(Convert.ToDouble(rw["frete"]).ToString("N2")),
                                     seguro = Convert.ToDouble(Convert.ToDouble(rw["seguro"]).ToString("N2")),
                                     despesa = Convert.ToDouble(Convert.ToDouble(rw["despesa"]).ToString("N2")),
                                     situacao = Convert.ToBoolean(rw["situacao"]),
                                     observacoes = Convert.ToString(rw["observacoes"]),
                                     dtCadastro = Convert.ToDateTime(Convert.ToDateTime(rw["dtCadastro"]).ToString("dd-MM-yyyy")),
                                     dtAlteracao = Convert.ToDateTime(rw["dtAlteracao"]),
                                     totalProduto =  Convert.ToDouble(Convert.ToDouble(rw["totalProduto"]).ToString("N2")),
                                     totalPagar =  Convert.ToDouble(Convert.ToDouble(rw["totalPagar"]).ToString("N2")),
                                     usuario = Convert.ToString(rw["usuario"]),
                                     listaItem = DaoCompra.BuscarItem(Convert.ToString(rw["modelo"]), Convert.ToString(rw["serie"]), Convert.ToString(rw["nrNota"]), Convert.ToInt64(rw["codFornecedor"])),
                                     listaContasPagar = DaoCompra.BuscarContasPagar(Convert.ToString(rw["modelo"]), Convert.ToString(rw["serie"]), Convert.ToString(rw["nrNota"]), Convert.ToInt64(rw["codFornecedor"])),
                                 }).ToList();
            return convertedList;
        }
    }
}
