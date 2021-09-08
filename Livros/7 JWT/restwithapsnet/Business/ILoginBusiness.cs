using restwithapsnet.Data.VO;

namespace restwithapsnet.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);
    }
}
