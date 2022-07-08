using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.Entities.Conncrete;

namespace CankutayUcarCV.Business.Abstract
{
    public interface IKullaniciService : IService<Kullanici>
    {
        Task<bool> CheckUserAsync(string userName, string password);
        Task<Kullanici> FindByKullaniciAdiAsync(string kullaniciAdi);

        Task<bool> UpdatePasswordAsync(string userName, string oldPassword, string newPassword,
            string ConfirmNewPassword);
    }
}
