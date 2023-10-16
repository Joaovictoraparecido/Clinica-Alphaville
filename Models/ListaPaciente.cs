using System.ComponentModel.DataAnnotations;
using System;

namespace CLINICA_ALPHAVILLE.Models
{
    public class ListaPaciente
    {

        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [EnumDataType(typeof(SexoEnum))]
        public SexoEnum Sexo { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }

        [EnumDataType(typeof(ProfissaoEnum))]
        public ProfissaoEnum Profissao { get; set; }

        [EnumDataType(typeof(EstadoEnum))]
        public EstadoEnum Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        [StringLength(8)]
        public string Cep { get; set; }

        [RegularExpression("^(Manhã|Tarde|Noite)$", ErrorMessage = "Os horários disponíveis devem ser 'manhã', 'tarde' ou 'noite.")]
        public string HorariosDisponiveis { get; set; }

        public string NomeDoPai { get; set; }

        public string NomeDaMae { get; set; }

        public string Responsavel { get; set; }

        public int Telefone { get; set; }

        public string Celular { get; set; }

        public string Observacao { get; set; }

        public string Atendimento1 { get; set; }

        public string Atendimento2 { get; set; }

        public string Atendimento3 { get; set; }

        public string Atendimento4 { get; set; }

        public string Atendimento5 { get; set; }
    }

    public enum SexoEnum
    {
        Masculino,
        Feminino,
        Outro
    }

    public enum ProfissaoEnum
    {
        Médico,
        Enfermeiro,
        Engenheiro,
        Professor,
        Advogado,
        Estudante,
        Outro
    }

    public enum EstadoEnum
    {
        Acre,
        Alagoas,
        Amapá,
        Amazonas,
        Bahia,
        Ceará,
        DistritoFederal,
        EspíritoSanto,
        Goiás,
        Maranhão,
        MatoGrosso,
        MatoGrossoDoSul,
        MinasGerais,
        Pará,
        Paraíba,
        Paraná,
        Pernambuco,
        Piauí,
        RioDeJaneiro,
        RioGrandeDoNorte,
        RioGrandeDoSul,
        Rondônia,
        Roraima,
        SantaCatarina,
        SãoPaulo,
        Sergipe,
        Tocantins
    }

}
