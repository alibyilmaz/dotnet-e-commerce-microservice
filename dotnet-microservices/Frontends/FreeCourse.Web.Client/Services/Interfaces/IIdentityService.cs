using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Client.Models;
using IdentityModel.Client;

namespace FreeCourse.Web.Client.Services.Interfaces
{
   public interface IIdentityService
    {
        Task<ResponseDto<bool>> SignIn(SignInInput signInInput);

        Task<TokenResponse> GetAccessTokentByRefreshToken();

        Task RevokeRefreshToken();
    }
}
