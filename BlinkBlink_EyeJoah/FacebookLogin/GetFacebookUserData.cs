using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using Facebook.MiniJSON;

namespace BlinkBlink_EyeJoah.FacebookLogin
{
    class GetFacebookUserData
    {
        protected readonly FacebookClient _fb;

        private string id;
        private string name;
        private List<String> userInfo;

        public GetFacebookUserData(FacebookClient fb)
        {
            if (fb == null)
                throw new ArgumentNullException("fb");

            _fb = fb;
            userInfo = new List<String>();
        }

        public void InitUserProfile()
        {
            var result = _fb.Get("me", new
            {
                fields = new[] { "id", "name" }
            });

            var dict = Json.Deserialize(result.ToString()) as Dictionary<string, object>;

            id = dict["id"].ToString();
            name = dict["name"].ToString();
            userInfo.Add(id);
            userInfo.Add(name);
            userInfo.Add("http://graph.facebook.com/" + id + "/picture");
        }

        public List<String> getUserInfo
        {
            get { return userInfo; }
        }
        
    }
}
