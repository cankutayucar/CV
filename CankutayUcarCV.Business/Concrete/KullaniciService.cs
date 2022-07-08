using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.Business.Helpers.PasswordSecurity;
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
            var kullanici = await _repository.CheckUserAsync(userName);
            if (kullanici != null)
            {
                return PasswordSecurity.EncryptPlainTextToCipherText(password) == kullanici.SIFRE;
            }
            return false;
            
        }

        public async Task<Kullanici> FindByKullaniciAdiAsync(string kullaniciAdi)
        {
            return await _repository.FindByKullaniciAdiAsync(kullaniciAdi);
        }
    }
}
