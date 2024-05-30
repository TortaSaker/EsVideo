namespace EsVideo.Model.Request
{
    public class UpdateUserRequest
    {
        public int IdUser { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
