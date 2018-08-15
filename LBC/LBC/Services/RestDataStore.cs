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

        public async Task<string> getPageContent(string contentId)
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
                //responseJSON = "<div class=\"fw-page-builder-content\"><section id=\"section-5b737bfcd28d1\" class=\" fw-main-row-custom fw-main-row-top  auto  tf-sh-a6ae41dc9de046f0a751dc4bb3451155 \" style=\"   \"><div class=\"fw-container-fluid\"><div class=\"fw-row\"><div id=\"column-2a3e0d3a3fce650f57615356af766ec1\" class=\"fw-col-sm-12 tf-sh-2a3e0d3a3fce650f57615356af766ec1\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-heading fw-heading-center  tf-sh-968e3508983d81e065a6442632f60480\"><h2 class=\"fw-special-title\">Lakeland Events</h2></div>	</div></div></div><div class=\"fw-row\"><div id=\"column-5f5ce2ce52f0d96822f630184e61c08f\" class=\"fw-col-sm-6 tf-sh-5f5ce2ce52f0d96822f630184e61c08f\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-heading fw-heading-left  fw-heading-with-subtitle tf-sh-b0a407b8218755a04f3c9a947569df5e\"><h2 class=\"fw-special-title\">Corporate Night of Prayer and Worship</h2><div class=\"fw-special-subtitle\">June 25, 2018 - 6pm</div></div><div class=\"fw-text-box tf-sh-bd4e15c281a0d0f1e3a951427b9b4413 \"><div class=\"fw-text-inner\"><p>When: 6-7pm, Every last Sunday of the month</p><p>Corporate worship matters. Many times in the Scripture God's people are called to assemble before the Lord (Joel 1:14, 2:15, Heb. 10:25, Acts 2:42). At Lakeland, we fully believe in setting aside times for the entire congregation to assemble to sing, pray, and observe the Lord's Supper together.</p><p>Every last Sunday evening of the month, Lakeland will gather for a night of praying, singing, and reading Scripture. These are reflective times to focus on the gospel of Christ and specific prayer concerns in our church, community, and government.</p><p>Typically, you can find some coffee, and an occasional snack food in the foyer. However, the focus of these times is to cry out to God and fellowship with one another.</p><p>We hope to see you join us as we make a habit of seeking the Lord together!</p></div></div>	</div></div><div id=\"column-60f56e250a789cd3e9ba4b038b6bbfb0\" class=\"fw-col-sm-6 tf-sh-60f56e250a789cd3e9ba4b038b6bbfb0\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-block-image-parent  \" style=\"width: 100%; \"><span class=\"fw-block-image-child fw-ratio-16-10 fw-ratio-container\"><noscript><img itemprop=\"image\" src=\"http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1.png\"  alt=\"Night of Worship\" data-maxdpr=\"1.7\" class=\"lazyload\" /></noscript><img src=\"data:image/gif;base64,R0lGODlhAQABAIAAAAAAAP///yH5BAEAAAAALAAAAAABAAEAAAIBRAA7\" data-sizes=\"auto\" data-srcset=\"http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1-300x188.png 300w, http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1-768x480.png 768w, http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1-1024x640.png 1024w, http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1.png 1920w\" alt=\"Night of Worship\" data-maxdpr=\"1.7\" class=\"  lazyautosizes lazyloaded\" sizes=\"1887px\" srcset=\"http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1-300x188.png 300w, http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1-768x480.png 768w, http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1-1024x640.png 1024w, http://lakelandchurch.org/wp-content/uploads/2018/01/Night-of-Worship-1.png 1920w\">							</span></div></div></div></div><div class=\"fw-row\"><div id=\"column-79415824b921d288049c92b49737ada5\" class=\"fw-col-sm-6 tf-sh-79415824b921d288049c92b49737ada5\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-heading fw-heading-left  fw-heading-with-subtitle tf-sh-cfd89ff4a471d9282e657855ab27d0ee\"><h2 class=\"fw-special-title\">Kids Summer Camp</h2><div class=\"fw-special-subtitle\">June 17-21</div></div><div class=\"fw-text-box tf-sh-6bd77b76aea7373b655316f1fdacb322 \"><div class=\"fw-text-inner\"><p>Do you have a child that just completed 3rd-6th grade that wants to experience a great week at summer camp?</p><p>IBSA offers several children camps throughout the summer. One of those camps takes place at Lake Sallateeska outside of Pinckneyville, IL. Thousands of students have been saved and grown in their faith over the years while attending a camp at Lake Sallateeska. Along with the spiritual benefits, Lake Sallateeska offers much in the area of recreation. Canoeing, basketball, kickball, and swimming are just a few of the highlights your children will experience while at camp.</p><p>Summer Camp costs $160 per child. If you have any questions or need more information, please contact the church office. Thank you!</p></div></div>	</div></div><div id=\"column-ad0f5cd3084237c3abe71c789c25c263\" class=\"fw-col-sm-6 tf-sh-ad0f5cd3084237c3abe71c789c25c263\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-block-image-parent  fw-block-image-center\" style=\"width: 450px; \"><span class=\"fw-block-image-child fw-noratio fw-ratio-container\"><noscript><img itemprop=\"image\" src=\"http://lakelandchurch.org/wp-content/uploads/2018/05/summer-kids-camp.jpg\"  alt=\"summer kids camp\" data-maxdpr=\"1.7\" width=\"450\" class=\"lazyload\" /></noscript><img src=\"data:image/gif;base64,R0lGODlhAQABAIAAAAAAAP///yH5BAEAAAAALAAAAAABAAEAAAIBRAA7\" data-sizes=\"auto\" data-srcset=\"http://lakelandchurch.org/wp-content/uploads/2018/05/summer-kids-camp.jpg 663w\" alt=\"summer kids camp\" data-maxdpr=\"1.7\" width=\"450\" class=\"  lazyautosizes lazyloaded\" sizes=\"450px\" srcset=\"http://lakelandchurch.org/wp-content/uploads/2018/05/summer-kids-camp.jpg 663w\"><span class=\"fw-after-no-ratio\" style=\"padding-bottom: 119.00452488688%\"></span>							</span></div></div></div></div><div class=\"fw-row\"><div id=\"column-a2f417b81f1e4d29f9b85cb6a24567d6\" class=\"fw-col-sm-6 tf-sh-a2f417b81f1e4d29f9b85cb6a24567d6\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-heading fw-heading-left  fw-heading-with-subtitle tf-sh-4d39e28f2abfdd5d42832dee95dec237\"><h2 class=\"fw-special-title\">Super Summer</h2><div class=\"fw-special-subtitle\">June 26-30</div></div><div class=\"fw-text-box tf-sh-0da957472f1ade2b736afb6c7e699397 \"><div class=\"fw-text-inner\"><p>Super Summer is the premier discipleship camp for the state of Illinois. Your children will be challenged in their faith along with their peers from across the state. Not only that, but they will make lifelong friends that will help them follow Jesus. Many students have received their call to ministry or missions while at Super Summer. We encourage you to consider sending your children to experience this life changing week.</p><p>Super Summer takes place at Greenville University about two hours north of Carbondale. The cost is $225 per student. Over the last two years, God has provided for each student through our annual church yard sale. We encourage your children to participate in running the two day sale as well.</p></div></div>	</div></div><div id=\"column-62152aec864d012bc1be5831a9a98ec8\" class=\"fw-col-sm-6 tf-sh-62152aec864d012bc1be5831a9a98ec8\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-divider-space space-md  clearfix\"></div><div class=\"fw-block-image-parent  fw-block-image-center\" style=\"width: 450px; \"><span class=\"fw-block-image-child fw-noratio fw-ratio-container\"><noscript><img itemprop=\"image\" src=\"http://lakelandchurch.org/wp-content/uploads/2018/05/Super-Summer.jpg\"  alt=\"Super Summer\" data-maxdpr=\"1.7\" width=\"450\" class=\"lazyload\" /></noscript><img src=\"data:image/gif;base64,R0lGODlhAQABAIAAAAAAAP///yH5BAEAAAAALAAAAAABAAEAAAIBRAA7\" data-sizes=\"auto\" data-srcset=\"http://lakelandchurch.org/wp-content/uploads/2018/05/Super-Summer.jpg 750w\" alt=\"Super Summer\" data-maxdpr=\"1.7\" width=\"450\" class=\"  lazyautosizes lazyloaded\" sizes=\"450px\" srcset=\"http://lakelandchurch.org/wp-content/uploads/2018/05/Super-Summer.jpg 750w\"><span class=\"fw-after-no-ratio\" style=\"padding-bottom: 69.466666666667%\"></span>							</span></div></div></div></div></div></section><section id=\"section-5b737bfd05a26\" class=\" fw-main-row  auto  tf-sh-ef3fb5cfebad776e8ebd79f8872cbf95 \" style=\"   \"><div class=\"fw-container\"><div class=\"fw-row\"><div id=\"column-9fc49feb7ac9e3ae910aa4dd0e0d40e6\" class=\"fw-col-sm-6 tf-sh-9fc49feb7ac9e3ae910aa4dd0e0d40e6\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-heading fw-heading-left  fw-heading-with-subtitle tf-sh-29e0ef928dd69ba4282516deb7648482\"><h2 class=\"fw-special-title\">Family Mission Trip</h2><div class=\"fw-special-subtitle\">July 13-15</div></div><div class=\"fw-text-box tf-sh-0b48338f10219ed1b5379018fe4f0aae \"><div class=\"fw-text-inner\"><p>Where: Nashville, TN</p><p>This Summer, we will be taking a family mission trip to Nashville to serve City Church Network.&nbsp;City Church Network is a missions agency located in Nashville, TN that began in 2011. The vision of CCN is to reach the unreached and unengaged peoples of the world with the Good News of Jesus. The mission of CCN is to equip individuals and churches to understand and participate in their role in accomplishing the Great Commission. We are grateful to God for the opportunity in front of us and are looking forward to seeing the fruit of this trip!</p><p>We hope you will consider joining us this summer!</p></div></div>	</div></div><div id=\"column-44ab58ab3e874d97438d7f7650d07cda\" class=\"fw-col-sm-6 tf-sh-44ab58ab3e874d97438d7f7650d07cda\"><div class=\"fw-main-row-overlay\"></div><div class=\"fw-col-inner\"><div class=\"fw-block-image-parent  \" style=\"width: 100%; \"><span class=\"fw-block-image-child fw-ratio-1 fw-ratio-container\"><noscript><img itemprop=\"image\" src=\"http://lakelandchurch.org/wp-content/uploads/2018/05/FMT-Website.jpg\"  alt=\"FMT Website\" data-maxdpr=\"1.7\" class=\"lazyload\" /></noscript><img src=\"data:image/gif;base64,R0lGODlhAQABAIAAAAAAAP///yH5BAEAAAAALAAAAAABAAEAAAIBRAA7\" data-sizes=\"auto\" data-srcset=\"http://lakelandchurch.org/wp-content/uploads/2018/05/FMT-Website-150x150.jpg 150w, http://lakelandchurch.org/wp-content/uploads/2018/05/FMT-Website-300x300.jpg 300w, http://lakelandchurch.org/wp-content/uploads/2018/05/FMT-Website-768x768.jpg 768w, http://lakelandchurch.org/wp-content/uploads/2018/05/FMT-Website-1024x1024.jpg 1024w, http://lakelandchurch.org/wp-content/uploads/2018/05/FMT-Website-800x800.jpg 800w, http://lakelandchurch.org/wp-content/uploads/2018/05/FMT-Website-300x300.jpg 300w, http://lakelandchurch.org/wp-content/uploads/2018/05/FMT-Website.jpg 1080w\" alt=\"FMT Website\" data-maxdpr=\"1.7\" class=\"lazyload\">							</span></div></div></div></div></div></section></div>";
                PageContent.Rootobject page = JsonConvert.DeserializeObject<PageContent.Rootobject>(responseJSON);
                return page.content.rendered;
            }

            catch (Exception exc)
            {
                return "Failed to Get HTML";
            }
        }

        public AppConfig GetDataFromLocalConfig()
        {
            AppConfig appConfig = new AppConfig();
            appConfig.Title = "Lakeland Baptist Church";
            Item firstItem = new Item();
            firstItem.ContentId = "623";
            firstItem.ImageURL = "https://www.xamarin.com/content/images/pages/forms/example-app.png";
            firstItem.Label = "Test";

            Item secondItem = new Item();
            secondItem.ContentId = "623";
            secondItem.ImageURL = "https://www.cartervillelions.org/vimages/shared/vnews/stories/565cc30db8f5f/563eca2b8cadf.image.jpg";
            secondItem.Label = "Test 2";


            appConfig.Menu = new List<Item>();
            appConfig.Menu.Add(firstItem);
            appConfig.Menu.Add(secondItem);

            return appConfig;
        }

    }
}
