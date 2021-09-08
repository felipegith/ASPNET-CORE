using restwithapsnet.Data.VO;
using restwithapsnet.Model;

namespace restwithapsnet.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User RefreshUserInfo(User user);
    }
}
