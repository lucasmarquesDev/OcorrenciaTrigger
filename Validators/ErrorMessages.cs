using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcorrenciaTrigger.Validators
{
    public static class ErrorMessages
    {
        public static string EnderecoObrigatorio => "Endereço não pode ser vazio!";
        public static string EnderecoTamanhoMaximo => "O endereço não pode ter mais de 30 caracteres!";
        public static string EnderecoTamanhoMinimo => "O endereço não pode ter menos de 3 caracteres!";
        public static string QuantidadeVolumesObrigatorio => "Quantidade de volumes não pode ser vazio!";
        public static string QuantidadeVolumesMinimo => "Quantidade de volumes deve ser maior que '0'!";
        public static string QuantidadeVolumesMaximo => "Quantidade de volumes não deve ser maior que '10'!";
        public static string DataCriacaoObrigatoria => "A data de criação não pode ser vazio!";
        public static string DataCriacaoMenorDataAtual => "A data de criação não pode ser menor que a data atual!";
        public static string DataAtualizacaoMenorDataAtual => "A data de atualização não pode ser menor que a data atual!";
        public static string DataAtualizacaoMenorDataCriacao => "A data de atualização não pode ser menor que a data de criação!";
        public static string DataExclusaoMenorDataAtual => "A data de exclusão não pode ser menor que a data atual!";
        public static string DataExclusaoMenorDataCriacao => "A data de exclusão não pode ser menor que a data de criação!";
    }
}
