using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Domain.Repositories;

namespace Domain.Services
{
    public class StuffService
    {
        private IStuffRepository repository;
        public StuffService(IStuffRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Stuff> GetIndexStuff(int first = 1)
        {
            return repository.Get().Skip<Stuff>(first-1).Take<Stuff>(4);
        }

        public int StuffCount
        {
            get
            {
                return repository.Get().Count<Stuff>();
            }
        }
    }
}
