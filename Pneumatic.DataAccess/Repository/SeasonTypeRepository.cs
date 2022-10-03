using Pneumatic.DataAccess.Repository.IRepository;
using Pneumatic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pneumatic.DataAccess.Repository
{
    public class SeasonTypeRepository : Repository<SeasonType>, ISeasonTypeRepository
    {
        private ApplicationDbContext _db; 
        public SeasonTypeRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(SeasonType obj)
        {
            _db.SeasonTypes.Update(obj); 
        }

    }
}
