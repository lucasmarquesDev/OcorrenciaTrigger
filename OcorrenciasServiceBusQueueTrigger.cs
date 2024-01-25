using System;
using System.Text.Json;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using OcorrenciaTrigger.Models;
using OcorrenciaTrigger.Validators;

namespace OcorrenciaTrigger
{
    public class OcorrenciasServiceBusQueueTrigger
    {
        [FunctionName("OcorrenciasQueueTrigger")]
        public void Run([ServiceBusTrigger("ocorrenciaqueue", Connection = "AzureServiceBusConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"Dados: {myQueueItem}");

            var ocorrencia = JsonSerializer.Deserialize<Ocorrencia>(myQueueItem,
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

            var validationResult = new OcorrenciaValidator().Validate(ocorrencia);

            if (validationResult.IsValid)
            {
                log.LogInformation("Dados validado com sucesso.");

                /*
                 * Implemente aqui a persistência dos dados no Database
                 */

                log.LogInformation("Ocorrência registrada com sucesso!");
            }
            else
            {
                log.LogInformation("Dados inválidos para a ocorrência");
            }
        }
    }
}
