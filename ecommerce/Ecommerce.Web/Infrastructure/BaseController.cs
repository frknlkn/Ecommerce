using System;
using System.Collections.Generic;
using System.Configuration;
using Ecommerce.Model;
using System.Linq;
using System.Web.Mvc;

namespace Ecommerce.Web.Infrastructure
{
    public class BaseController : Controller
    {
        public static readonly EcommerceEntities db = new EcommerceEntities();

        protected AspNetUser GetCurrentUser(EcommerceEntities context)
        {

            return context.AspNetUsers.FirstOrDefault(x=>x.UserName==context.UserName);
        }

        protected string GetCurrentUserId(EcommerceEntities context)
        {
            var user = GetCurrentUser(context);
            return user != null ? (string) user.Id : null;
        }

        protected string GetUser()
        {
            string userName = HttpContext.User.Identity.Name;
            if (String.IsNullOrEmpty(userName))
                userName = User.Identity.Name;
            if (userName.Contains("\\"))
                userName = userName.Split('\\')[1];
            return userName;
        }
    }
}