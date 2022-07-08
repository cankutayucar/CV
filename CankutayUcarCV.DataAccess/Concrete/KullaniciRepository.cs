using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DataAccess.Abstract;
using CankutayUcarCV.Entities.Conncrete;
using Dapper;

namespace CankutayUcarCV.DataAccess.Concrete
{
    public class KullaniciRepository : Repository<Kullanici>, IKullaniciRepository
    {
        private readonly IDbConnection _dbConnection;

        public KullaniciRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<Kullanici> CheckUserAsync(string userName)
        {
            var user = await _dbConnection.QueryFirstOrDefaultAsync<Kullanici>(
                "select * from Kullanici where KULLANICI_ADI = @KULLANICI_ADI", new
                {
                    KULLANICI_ADI = userName
                });
            return user;

        }

        public async Task<Kullanici> FindByKullaniciAdiAsync(string kullanici_Adi)
        {
            var query = @"  select * from Kullanici where KULLANICI_ADI = @KULLANICI_ADI";
            return await _dbConnection.QueryFirstOrDefaultAsync<Kullanici>(query, new
            {
                KULLANICI_ADI = kullanici_Adi
            });
        }
    }
}
