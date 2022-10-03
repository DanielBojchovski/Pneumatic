using Pneumatic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pneumatic.DataAccess.Repository.IRepository
{
    public interface ISeasonTypeRepository : IRepository<SeasonType>
    {
        void Update(SeasonType obj);
    }
}
