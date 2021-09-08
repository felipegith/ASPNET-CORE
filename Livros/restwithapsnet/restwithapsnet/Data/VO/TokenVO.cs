namespace restwithapsnet.Data.VO
{
    public class TokenVO
    {
        public TokenVO(bool authenticated, string created, string expirated, string accessToken, string refreshToken)
        {
            Authenticated = authenticated;
            Created = created;
            Expirated = expirated;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public bool Authenticated { get; set; }
        public string Created { get; set; }
        public string Expirated { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
