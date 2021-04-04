using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MyChatApp.Models
{
    public class AppUser : IdentityUser 
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        // 1-* AppUser || Message 
        public virtual ICollection <Message>Messages { get; set; }

    }
}