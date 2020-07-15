using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get;  }
    }

    public interface ISingletonDateService : IDateService { }


    public interface IScopeDateService : IDateService { }

    public interface ITransientDateService : IDateService { }

}
