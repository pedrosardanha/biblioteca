using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.src.models
{

    [Table("users")]
    public class User
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}