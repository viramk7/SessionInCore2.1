using Microsoft.AspNetCore.Http;
using SessionDemo.Models;

namespace SessionDemo
{
    public class SessionHelper
    {
        public static LoggedInUser LoggedInUser
        {
            get
            {
                if (AppHttpContext.Current.Session.GetString("User") == null)
                {
                    return null;
                }

                var userStr = AppHttpContext.Current.Session.GetString("User");
                return Newtonsoft.Json.JsonConvert.DeserializeObject<LoggedInUser>(userStr);
            }

            set => AppHttpContext.Current.Session.SetString("User", Newtonsoft.Json.JsonConvert.SerializeObject(value));
        }
    }
}
