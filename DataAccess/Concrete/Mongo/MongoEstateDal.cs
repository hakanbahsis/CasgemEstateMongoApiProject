using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Repository;
using DataAccess.Settings;
using Entities.Concrete;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Mongo
{
    public class MongoEstateDal : MongoRepositoryBase<Estate>, IEstateDal
    {
        private readonly MongoDbContext _context;
        private readonly IMongoCollection<Estate> _collection;
        public MongoEstateDal(IOptions<MongoSettings> setting) : base(setting)
        {
            _context = new MongoDbContext(setting);
            _collection=_context.GetCollection<Estate>();
        }


    }
}
