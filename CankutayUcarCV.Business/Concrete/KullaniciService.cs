using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.DataAccess.Abstract;
using CankutayUcarCV.Entities.Conncrete;

namespace CankutayUcarCV.Business.Concrete
{
    public class KullaniciService : Service<Kullanici>, IKullaniciService
    {
        private readonly IKullaniciRepository _repository;
        public KullaniciService(IKullaniciRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<bool> CheckUserAsync(string userName, string password)
        {
            return await _repository.CheckUserAsync(userName, password);
        }

        public async Task<Kullanici> FindByKullaniciAdiAsync(string kullaniciAdi)
        {
            return await _repository.FindByKullaniciAdiAsync(kullaniciAdi);
        }
    }
}
