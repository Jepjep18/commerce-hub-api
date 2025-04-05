namespace commerceHubApi.DTO
{
    public class UserDTO
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Username { get; set; }
    }

    public class UserLogin
    {
        public string Username { get; set; }
        public string Passwordhash { get; set; }
    }
}
