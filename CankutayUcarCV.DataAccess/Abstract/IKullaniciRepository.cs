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
        Task<Kullanici> CheckUserAsync(string userName);
        Task<Kullanici> FindByKullaniciAdiAsync(string kullanici_Adi);
    }
}
