using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDoperations.Models
{
    public class UserModel
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }




        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }




        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }





        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Contact No")]

        public string ContactNo { get; set; }






   
    }
}
