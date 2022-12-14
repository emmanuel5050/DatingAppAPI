using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace DatingAppAPI.Extensions
{
    public static class IdentityServiceExtension
    {
        public static IServiceCollection AppIdentityService(this IServiceCollection services, IConfiguration _config)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["TokenKey"])),
                        ValidateAudience = false,
                        ValidateIssuer = false
                    };
                });

            return services;
        }
    }
}
