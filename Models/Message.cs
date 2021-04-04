using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
namespace MyChatApp.Models
{
    public class Message
    {
        public int ID { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Text { get; set; }
        public DateTime When { get; set; }

        public String UserID { get; set; }


        public virtual AppUser Sender   {get; set;}

}
}