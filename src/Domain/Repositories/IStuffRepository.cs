using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Domain.Repositories
{
    public interface IStuffRepository
    {
        IEnumerable<Stuff> Get();
    }
}
