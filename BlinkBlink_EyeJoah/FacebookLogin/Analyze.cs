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
    public partial class Analyze : Form
    {
        protected readonly FacebookClient _fb;

        private string id;
        private string name;
        public Analyze(FacebookClient fb)
        {
            if (fb == null)
                throw new ArgumentNullException("fb");

            _fb = fb;

            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {

            var result = _fb.Get("me", new { fields = new[] { "id", "name", "posts.limit(" + (Convert.ToInt32(textBoxPostNum.Text) + 2).ToString() + "){comments.limit(1000){id,message},likes.limit(1000){id,name},message,sharedposts,picture,link}" } });

            //JsonResult res = JsonConvert.DeserializeObject<JsonResult>(result.ToString());

            var dict = Json.Deserialize(result.ToString()) as Dictionary<string, object>;

            id = dict["id"].ToString();
            name = dict["name"].ToString();

            object objData;
            if (dict.TryGetValue("posts", out objData))
            {
                var dataDict = ((Dictionary<string, object>)(objData));

                object objPosts;
                if (dataDict.TryGetValue("data", out objPosts))
                {
                    int cnt = 0;

                    var listPost = (List<object>)(objPosts);

                    dataGridViewAnalyze.Rows.Clear();

                    foreach (var pair in listPost)
                    {
                        var dataPosts = ((Dictionary<string, object>)(pair));

                        dataGridViewAnalyze.Rows.Add();

                        dataGridViewAnalyze.Rows[cnt].Cells[0].Value = (cnt + 1).ToString();

                        if (dataPosts.ContainsKey("message"))
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[1].Value = dataPosts["message"].ToString();
                        }
                        else
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[1].Value = "";
                        }

                        if (dataPosts.ContainsKey("link"))
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[2].Value = dataPosts["link"].ToString();
                        }
                        else
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[2].Value = "";
                        }

                        if (dataPosts.ContainsKey("picture"))
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[3].Value = dataPosts["picture"].ToString();
                        }
                        else
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[3].Value = "";
                        }

                        if (dataPosts.ContainsKey("sharedposts"))
                        {
                            object objSharedPosts;
                            if (dataPosts.TryGetValue("sharedposts", out objSharedPosts))
                            {
                                var dictSharedPosts = ((Dictionary<string, object>)(objSharedPosts));

                                object shared;
                                if (dictSharedPosts.TryGetValue("data", out shared))
                                {
                                    var listSharedPosts = (List<object>)(shared);
                                    dataGridViewAnalyze.Rows[cnt].Cells[6].Value = listSharedPosts.Count.ToString();
                                }
                            }
                        }
                        else
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[6].Value = 0.ToString();
                        }

                        if (dataPosts.ContainsKey("likes"))
                        {
                            object objLikes;
                            if (dataPosts.TryGetValue("likes", out objLikes))
                            {
                                var dictLikes = ((Dictionary<string, object>)(objLikes));

                                object likes;
                                if (dictLikes.TryGetValue("data", out likes))
                                {
                                    var listLikes = (List<object>)(likes);
                                    dataGridViewAnalyze.Rows[cnt].Cells[5].Value = listLikes.Count.ToString();
                                }
                            }
                        }
                        else
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[5].Value = 0.ToString();
                        }

                        if (dataPosts.ContainsKey("comments"))
                        {
                            object objComments;
                            if (dataPosts.TryGetValue("comments", out objComments))
                            {
                                var dictComments = ((Dictionary<string, object>)(objComments));

                                object comments;
                                if (dictComments.TryGetValue("data", out comments))
                                {
                                    var listComments = (List<object>)(comments);
                                    dataGridViewAnalyze.Rows[cnt].Cells[4].Value = listComments.Count.ToString();
                                }
                            }
                        }
                        else
                        {
                            dataGridViewAnalyze.Rows[cnt].Cells[4].Value = 0.ToString();
                        }

                        cnt = cnt + 1;
                    }
                }
            }

        }
        
    }
}
