using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlCsharp.Models
{
    [Table("Correntista")]
    public class Correntista
    {

            [Display(Description ="Código")]     
            public int Id { get; set; }

            [Display(Name = "Nome do Usuário")]
            [Column("Nome")]
            [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
            public string Nome { get; set; }
            
            [Column("DataDeNacimento")]
            public string DataNascimento { get; set; }

            [Column("CPF")]
            public string Cpf { get; set; }

            DateTime date = new DateTime(2000, 01, 01);

    }
}
/*
            [Column("CPF")]
            public string Cpf { get; set; }

            [Column("RG")]
            public long Rg { get; set; }

            //Dados de endereço
            [Column("CEP")]
            public int Cep { get; set; }

            [Column("Rua")]
            public string Rua { get; set; }

            [Column("Cidade")]
            public string Cidade { get; set; }

            [Column("Estado")]
            public string Estado { get; set; }

            [Column("Pais")]
            public string Pais { get; set; }

            //Dados financeiros
            [Column("Salario")]
            public float Salario { get; set; }

            [Column("Patrimonio")]
            public float Patrimonio { get; set; }

            //Dados empregador
            [Column("EmpresaEmQueTrabalha")]
            public string EmpresaEmQueTrabalha { get; set; }

            [Column("TempoNoEmprego")]
            public int TempoNoEmprego { get; set; }

            [Column("Cargo")]
            public string Cargo { get; set; }

            //Conta do Correntista
            [Column("NumeroDaConta")]
            public string NumeroDaConta { get; set; }
            //public float s { get; set; }
*/