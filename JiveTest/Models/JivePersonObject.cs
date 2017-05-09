using System.Collections.Generic;
using System.ComponentModel;

namespace JiveTest.Models
{
    public class JivePersonObject
    {
        public int Id { get; set; }

        [DisplayName("Jive Person Name")]
        public string DisplayName { get; set; }

        public JivePersonInfo Jive { get; set; }
        public List<JiveEmails> Emails { get; set; }
        public JiveName Name { get; set; }
    }
}