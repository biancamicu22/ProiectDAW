using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using ProiectDAW.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Utilities
{
    public class JWTMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        public JWTMiddleware(IOptions<AppSettings> appSettings, RequestDelegate next)
        {
            _appSettings = appSettings.Value;
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IUserService userService, IJWTUtils jWTUtils)
        {
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", string.Empty);
            var userID = jWTUtils.ValidateJWToken(token);

            if (userID != Guid.Empty)

            {
                httpContext.Items["User"] = userService.GetById(userID);
            }

            await _next(httpContext);
        }   
    }
}
