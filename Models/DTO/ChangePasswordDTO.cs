using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.DTO
{
    public class ChangePasswordDTO
    {
        [DisplayName("Current Password")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [DisplayName("New Password")]
        [DataType(DataType.Password)]
        public string NewPassword1 { get; set; }
        [DisplayName("Retype New Password")]
        [DataType(DataType.Password)]
        public string NewPassword2 { get; set; }

    }
}
