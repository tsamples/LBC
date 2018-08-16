using LBC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LBC.Services
{
    public class RestDataStore : IDataStore
    {

        public async Task<AppConfig> GetDataFromAPI()
        {
            try
            {
                var client = new System.Net.Http.HttpClient();
                client.BaseAddress = new Uri("http://www.lakelandchurch.org");
                var response = await client.GetAsync("");

                response.EnsureSuccessStatusCode();
                var responseJSON = await response.Content.ReadAsStringAsync();

                var msg = JsonConvert.DeserializeObject<AppConfig>(responseJSON);

                return msg;
            }

            catch (Exception exc)
            {
                var msg = new AppConfig();
                return msg;
            }

        }

        public async Task<PageContent.Rootobject> GetPageContent(string contentId)
        {
            try
            {
                var client = new System.Net.Http.HttpClient();
                var responseJSON = "";
                HttpResponseMessage response = await client.GetAsync(new Uri("http://www.lakelandchurch.org/wp-json/wp/v2/pages/" + contentId));
                if (response.IsSuccessStatusCode)
                {
                    responseJSON = await response.Content.ReadAsStringAsync();
                }                
                PageContent.Rootobject page = JsonConvert.DeserializeObject<PageContent.Rootobject>(responseJSON);
                return page;
            }

            catch (Exception exc)
            {
                var page = new PageContent.Rootobject();
                page.content.rendered = "Failed to Get HTML";
                page.title.rendered = "Error Getting Page";
                return page;
            }
        }

        public AppConfig GetDataFromLocalConfig()
        {
            AppConfig appConfig = new AppConfig();
            appConfig.Title = "Lakeland Baptist Church";
            Item firstItem = new Item();
            firstItem.ContentId = "623";
            firstItem.ImageURL = "http://lakelandchurch.org/wp-content/uploads/2018/08/welcome.png";
            firstItem.Label = "Test";


            Item thirdItem = new Item();
            thirdItem.ContentId = "1708";
            thirdItem.ImageURL = "http://wodprep.com/wp-content/uploads/2016/09/wodprep-logo.png";
            thirdItem.Label = "Test";

            Item fourthItem = new Item();
            fourthItem.ContentId = "1761";
            fourthItem.ImageURL = "http://staticaltmetric.s3.amazonaws.com/uploads/2015/12/Altmetric_rgb.png";
            fourthItem.Label = "Test";

            Item secondItem = new Item();
            secondItem.ContentId = "";
            secondItem.ImageURL = "http://lakelandchurch.org/wp-content/uploads/2018/08/connect.png";
            secondItem.Label = "Test 2";
            secondItem.Menu = new List<Item>();
            secondItem.Menu.Add(thirdItem);
            secondItem.Menu.Add(fourthItem);

            appConfig.Menu = new List<Item>();
            appConfig.Menu.Add(firstItem);
            appConfig.Menu.Add(secondItem);

            return appConfig;
        }

    }
}

