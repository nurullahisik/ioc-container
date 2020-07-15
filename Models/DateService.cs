using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.Models
{
    public class DateService : ISingletonDateService, IScopeDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;

            _logger.LogWarning("DateService constructor girdi");
        }

        public DateTime GetDateTime { get; } = DateTime.Now; 
    }
}
