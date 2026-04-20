using Authentik.Client.Api;
using AuthentikJellyfinSync.Configuration;

namespace AuthentikJellyfinSync.Sync;

public class UserUtilities
{
    public static Authentik.Client.Model.User? GetUser(CoreApi api, UserIdentifierType userIdentifierType, string oauthId)
    {
        try
        {
            switch (userIdentifierType)
            {
                case UserIdentifierType.Pk:
                    return api.CoreUsersRetrieve(int.Parse(oauthId));
                case UserIdentifierType.Uuid:
                    return GetUserByUuid(api, oauthId);
                case UserIdentifierType.Email:
                    return GetUserByEmail(api, oauthId);
                case UserIdentifierType.Username:
                    return GetUserByUsername(api, oauthId);
                default:
                    return null;
            }
        }
        catch (FormatException exception)
        {
            return null;
        }
    }

    private static Authentik.Client.Model.User? GetUserByUuid(CoreApi api, string uuid)
    {
        try
        {
            var users = api.CoreUsersList(uuid: Guid.Parse(uuid));
            if (users.Results.Count != 1)
                return null;
            
            return users.Results[0];
        }
        catch (FormatException exception)
        {
            return null;
        }
    }
    
    private static Authentik.Client.Model.User? GetUserByUsername(CoreApi api, string username)
    {
        var users = api.CoreUsersList(username: username);
        if (users.Results.Count != 1)
            return null;
            
        return users.Results[0];
    }
    
    private static Authentik.Client.Model.User? GetUserByEmail(CoreApi api, string email)
    {
        var users = api.CoreUsersList(email: email);
        if (users.Results.Count != 1)
            return null;
            
        return users.Results[0];
    }
}