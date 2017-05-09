namespace JiveTest.Models
{
    public class JivePersonInfo
    {
        public string UserName { get; set; }
        public JiveProfiles[] Profile { get; set; }
        public bool Federated { get; set; }
        public bool Enabled { get; set; }
    }
}