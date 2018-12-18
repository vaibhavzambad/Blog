using System;
using Microsoft.AspNet.Identity;
using JustBlog.Core.Models;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JustBlog
{
    public class AppUserManager : UserManager<AppUser, int>
    {
        public AppUserManager(IUserStore<AppUser, int> store, IdentityFactoryOptions<AppUserManager> options,
            IOwinContext context) : base(store)
        {
            this.UserValidator = new UserValidator<AppUser, int>(this)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            this.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
                RequireNonLetterOrDigit = true
            };

            this.UserLockoutEnabledByDefault = true;
            this.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(10);
            this.MaxFailedAccessAttemptsBeforeLockout = 8;

            IDataProtectionProvider dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                this.UserTokenProvider = new DataProtectorTokenProvider<AppUser,int>
                    (dataProtectionProvider.Create("ASP.NET Identity"));
            }
        }
    }

    public class AppSignInManager : SignInManager<AppUser, int>
    {
        public AppSignInManager(AppUserManager userManager,IAuthenticationManager authenticationManager)
            :base(userManager,authenticationManager)
        {

        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(AppUser user)
        {
            return user.GenerateUserIdentityAsync((AppUserManager)UserManager);
        }
    }
}