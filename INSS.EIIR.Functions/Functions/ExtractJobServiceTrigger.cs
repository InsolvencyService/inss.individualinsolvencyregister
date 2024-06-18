using INSS.EIIR.Interfaces.DataAccess;
using INSS.EIIR.Interfaces.Services;
using INSS.EIIR.Models.ExtractModels;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus.Core;

namespace INSS.EIIR.Functions.Functions;

public class ExtractJobServiceTrigger
{
    private readonly ILogger<ExtractJobServiceTrigger> _logger;
    private readonly IExtractRepository _eiirRepository;
    private readonly IExtractDataProvider _extractService;

    public ExtractJobServiceTrigger(
        ILogger<ExtractJobServiceTrigger> log,
        IExtractRepository eiirRepository,
        IExtractDataProvider extractService)
    {
        _logger = log;
        _eiirRepository = eiirRepository;
        _extractService = extractService;
    }

    [FunctionName("ExtractJobServiceTrigger")]
    public async Task Run([ServiceBusTrigger("%servicebusextractjobqueue%", Connection = "servicebussubscriberconnectionstring", AutoComplete = false)]  ExtractJobMessage message, MessageReceiver messageReceiver, string lockToken)
    {
        var now = DateTime.Now;

        _logger.LogInformation($"ExtractJobServiceTrigger received message: {message} on {now}");

        //APP-4990 Remove message from queue otherwise it processes n times, due to time it takes to run, consuming mega SQL resource 
        await messageReceiver.CompleteAsync(lockToken);

        try
        {
            await _extractService.GenerateSubscriberFile(message.ExtractFilename);

            _eiirRepository.UpdateExtractAvailable();
            
            _logger.LogInformation($"ExtractJobServiceTrigger ran succssfully on: {now} xml/zip file created with name: {message.ExtractFilename}");
        }
        catch (Exception ex)
        {
            var error = $"ExtractJobServiceTrigger failed on: {now} with : {ex}";
            _logger.LogError(error);
            throw new Exception(error);
        }
    }


}
