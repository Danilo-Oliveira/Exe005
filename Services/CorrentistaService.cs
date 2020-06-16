using System;
using System.Collections.Generic;
using SqlCsharp.Models;

namespace SqlCsharp.Services
{
    public class CorrentistaService : Correntista
    {
        public static List<CorrentistaService> GetCorrentistaServices()
        {
            var listaCorrentistaServices = new List<CorrentistaService>()
            {
                /*new CorrentistaService { Id = 1, Nome = "Senhor Café", Cpf = "12345678910", Rg = 12345678910,
                Cep = 12345678, Rua = "São Café", Cidade = "Caféina", Estado = "Coffee", Pais = "Grão de Café",
                Salario = 0.00f, Patrimonio = 0.00f, EmpresaEmQueTrabalha = "Nenhuma", TempoNoEmprego = 0, Cargo = "Nenhuma", 
                NumeroDaConta = "123456789"}*/

                new CorrentistaService {Id = 1, Nome = "Senhor Café", DataNascimento = "01/01/1999", Cpf = "12345678910" }
            };

            return listaCorrentistaServices;
        }
    }
}