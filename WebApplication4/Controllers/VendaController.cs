using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebEquipMoto.Controllers
{
    [Route("api/venda")]
    [ApiController]
    public class VendaController: ControllerBase
    {
        public VendaController()
        {
            DaoVenda = new VendasDAO();
        }

        public VendasDAO DaoVenda { get; }

        [HttpGet]
        public  IEnumerable<EquipMotos.MODEL.Vendas> Get()
        {
            ClientesDAO DaoCliente = new ClientesDAO();
            CondicaoPagamentoDAO DaoCondicaoPagamento = new CondicaoPagamentoDAO();

            var lista = DaoVenda.ListarTodos();
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new Vendas()
                                 {
                                        modelo = Convert.ToString(rw["modelo"]),
                                        serie = Convert.ToString(rw["serie"]),
                                        nrNota = Convert.ToString(rw["nrNota"]),
                                        cliente = DaoCliente.BuscarPorID(Convert.ToInt64(rw["codCliente"])) as Clientes,
                                        condPagamento = DaoCondicaoPagamento.BuscarPorID(Convert.ToInt64(rw["codCondPagamento"])) as CondicaoPagamentos,
                                        dtEmissao = Convert.ToDateTime(rw["dtEmissao"]),
                                        desconto = Convert.ToDouble(Convert.ToDouble(rw["desconto"]).ToString("N2")),
                                        totalReceber = Convert.ToDouble(Convert.ToDouble(rw["totalReceber"]).ToString("N2")),
                                        observacoes = Convert.ToString(rw["observacoes"]),
                                        dtCadastro = Convert.ToDateTime(Convert.ToDateTime(rw["dtCadastro"]).ToString("dd-MM-yyyy")),
                                        dtAlteracao = Convert.ToDateTime(rw["dtAlteracao"]),
                                        usuario = Convert.ToString(rw["usuario"]),
                                        listaItem = DaoVenda.BuscarItem(Convert.ToString(rw["nrNota"])),
                                        listaContasReceber = DaoVenda.BuscarContasReceber(Convert.ToString(rw["modelo"]), Convert.ToString(rw["serie"]), Convert.ToString(rw["nrNota"]), Convert.ToInt64(rw["codCliente"])),

                                }).ToList();
            return convertedList;
        }

        [Route("filter")]
        [HttpGet]
        public IEnumerable<Vendas> GetFilters([FromQuery] string nota, [FromQuery] string cliente, [FromQuery] DateTime dateMin, [FromQuery] DateTime dateMax)
        {
            ClientesDAO DaoCliente = new ClientesDAO();
            CondicaoPagamentoDAO DaoCondicaoPagamento = new CondicaoPagamentoDAO();

            var lista = DaoVenda.BuscarVenda_Filtro(nota, cliente, dateMin, dateMax);
            var convertedList = (from rw in lista.AsEnumerable()
                                 select new Vendas()
                                 {
                                     modelo = Convert.ToString(rw["modelo"]),
                                     serie = Convert.ToString(rw["serie"]),
                                     nrNota = Convert.ToString(rw["nrNota"]),
                                     cliente = DaoCliente.BuscarPorID(Convert.ToInt64(rw["codCliente"])) as Clientes,
                                     condPagamento = DaoCondicaoPagamento.BuscarPorID(Convert.ToInt64(rw["codCondPagamento"])) as CondicaoPagamentos,
                                     dtEmissao = Convert.ToDateTime(rw["dtEmissao"]),
                                     desconto = Convert.ToDouble(Convert.ToDouble(rw["desconto"]).ToString("N2")),
                                     totalReceber = Convert.ToDouble(Convert.ToDouble(rw["totalReceber"]).ToString("N2")),
                                     observacoes = Convert.ToString(rw["observacoes"]),
                                     dtCadastro = Convert.ToDateTime(Convert.ToDateTime(rw["dtCadastro"]).ToString("dd-MM-yyyy")),
                                     dtAlteracao = Convert.ToDateTime(rw["dtAlteracao"]),
                                     usuario = Convert.ToString(rw["usuario"]),
                                     listaItem = DaoVenda.BuscarItem(Convert.ToString(rw["nrNota"])),
                                     listaContasReceber = DaoVenda.BuscarContasReceber(Convert.ToString(rw["modelo"]), Convert.ToString(rw["serie"]), Convert.ToString(rw["nrNota"]), Convert.ToInt64(rw["codCliente"])),

                                 }).ToList();
            return convertedList;
        }


    }
}
