using CsvHelper.Configuration;
using System.Globalization;

namespace GloboTicket.TicketManagement.Infrastructure.FileExport;

public class CsvExporter : ICsvExporter
{
    public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            // Don't write the header again.
        };

        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter,config);
            csvWriter.WriteRecords(eventExportDtos);
        }
        return memoryStream.ToArray();
    }
}
