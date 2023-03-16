using BMG_Schedule.Areas.Identity.Pages;
using BMG_Schedule.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BMG_Schedule.Areas.Identity
{
    //public class CalimsTransformer : IClaimsTransformation
    //{
    //    private readonly IUserStore<Employee> _UserStore;

    //    public CalimsTransformer(IUserStore<Employee> userStore)
    //    {
    //        _UserStore = userStore;
    //    }

    //    public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    //    {
    //        var clonedPrincipal = principal.Clone();

    //        if (clonedPrincipal.Identity == null)
    //        {
    //            return clonedPrincipal;
    //        }

    //        var identity = (ClaimsIdentity)clonedPrincipal.Identity;
    //        var existingClaim = identity.Claims.FirstOrDefault(c => c.Type == GloboClaimTypes.FirstName);

    //        if (existingClaim != null)
    //        {
    //            return clonedPrincipal;
    //        }

    //        var nameIdClaim = identity.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
    //        if (nameIdClaim == null)
    //        {
    //            return clonedPrincipal;
    //        };

    //        //var user = await _UserStore.FindByIdAsync(nameIdClaim.Value, CancellationToken.None);

    //        //if(user != null)
    //        //{
    //        //    identity.AddClaim(new Claim(GloboClaimTypes.FirstName, user.FirstName!.ToString()));
    //        //}

    //        identity.AddClaim(new Claim("Foo", "Bar"));

    //        return clonedPrincipal;
    //    }
    //}
}
