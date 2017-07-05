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

        public GetFacebookUserData(FacebookClient fb)
        {
            if (fb == null)
                throw new ArgumentNullException("fb");

            _fb = fb;
        }

        public void InitUserProfile()
        {
            var result = _fb.Get("me", new
            {
                fields = new[] { "id", "name", "posts.limit(" +
                (Convert.ToInt32(1)).ToString() + "){comments.limit(1000){id,message},likes.limit(1000){id,name},message,sharedposts,picture,link}" }
            });

            var dict = Json.Deserialize(result.ToString()) as Dictionary<string, object>;

            id = dict["id"].ToString();
            name = dict["name"].ToString();
        }
    }
}
