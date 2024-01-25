using FluentValidation;
using OcorrenciaTrigger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcorrenciaTrigger.Validators
{
    public class OcorrenciaValidator : AbstractValidator<Ocorrencia>
    {
        public OcorrenciaValidator()
        {
            RuleFor(n => n.EnderecoCompleto)
                .NotEmpty().WithMessage(ErrorMessages.EnderecoObrigatorio)
                .MinimumLength(3).WithMessage(ErrorMessages.EnderecoTamanhoMinimo)
                .MaximumLength(30).WithMessage(ErrorMessages.EnderecoTamanhoMaximo);

            RuleFor(n => n.QuantidadeVolumes)
                    .NotNull().WithMessage(ErrorMessages.QuantidadeVolumesObrigatorio)
                    .GreaterThan(0).WithMessage(ErrorMessages.QuantidadeVolumesMinimo)
                    .LessThanOrEqualTo(10).WithMessage(ErrorMessages.QuantidadeVolumesMaximo);

            RuleFor(n => n.DtCriacao)
                    .NotNull().WithMessage(ErrorMessages.DataCriacaoObrigatoria)
                    .GreaterThanOrEqualTo(DateTime.Today).WithMessage(ErrorMessages.DataCriacaoMenorDataAtual);

            RuleFor(n => n.DtAtualizacao)
                    .GreaterThanOrEqualTo(DateTime.Today).WithMessage(ErrorMessages.DataAtualizacaoMenorDataAtual)
                    .GreaterThanOrEqualTo(x => x.DtCriacao).WithMessage(ErrorMessages.DataAtualizacaoMenorDataCriacao);

            RuleFor(n => n.DtExclusao)
                    .GreaterThanOrEqualTo(DateTime.Today).WithMessage(ErrorMessages.DataExclusaoMenorDataAtual)
                    .GreaterThanOrEqualTo(x => x.DtCriacao).WithMessage(ErrorMessages.DataExclusaoMenorDataCriacao);
        }
    }
}
