using LeveMe.Application.InterfacesServices;
using LeveMe.Domain.InterfacesRepositories;
using LeveMv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMe.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _iClienteRepositories;

        public ClienteService(IClienteRepository iClienteRepositories)
        {
            _iClienteRepositories = iClienteRepositories;
        }

        public async Task Atualizar(Cliente cliente)
        {
            try
            {
                await _iClienteRepositories.Atualizar(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Cadastar(Cliente cliente)
        {
            try
            {
                await _iClienteRepositories.Cadastar(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Excluir(Guid clienteId)
        {
            try
            {
                await _iClienteRepositories.Excluir(clienteId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Cliente>> Listar()
        {
            try
            {
                return await _iClienteRepositories.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Cliente>> ListarPorNome(string nome)
        {
            try
            {
                return await _iClienteRepositories.ListarPorNome(nome);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Cliente> PesquisarPoId(Guid clienteId)
        {
            try
            {
                return await _iClienteRepositories.PesquisarPoId(clienteId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
