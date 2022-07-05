using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.Entities.Conncrete;

namespace CankutayUcarCV.DataAccess.Abstract
{
    public interface IKullaniciRepository : IRepository<Kullanici>
    {
        Task<bool> CheckUserAsync(string userName, string password);
        Task<Kullanici> FindByKullaniciAdiAsync(string kullanici_Adi);
    }
}
