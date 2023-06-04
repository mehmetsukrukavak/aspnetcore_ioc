using System;
namespace IOC.Web.Models
{
	public class DateService: ISingletonDateService,IScopedDateService,ITransientDateService
    {

		private ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;
            _logger.LogWarning("DateService Constructor'ına girildi");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;


	}
}

