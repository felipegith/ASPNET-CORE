using restwithapsnet.Data.VO;
using restwithapsnet.Model;
using restwithapsnet.Model.Context;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace restwithapsnet.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MySqlContext _context;

        public UserRepository(MySqlContext context)
        {
            _context = context;
        }

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.Users.FirstOrDefault(u => (u.UserName == user.UserName) && (u.Password == pass));
        }

        public User RefreshUserInfo(User user)
        {
            if (_context.Users.Any(u => u.Id.Equals(user.Id)))
            {
                return null;
            }
            var result = _context.Users.SingleOrDefault(p => p.Id.Equals(user.Id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                    return result;

                }
                catch (SystemException)
                {
                    throw;
                }
            }
            return result;
        }

        // Método responsável por incriptar a senha
        private object ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}
