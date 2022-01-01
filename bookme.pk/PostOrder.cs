using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace bookme.pk
{
    class PostOrder:MiddleWare
    {
        private static readonly HttpClient client = new HttpClient();
        public async override void hitApi()
        {
            var values = new Dictionary<string, string>
{
    { "thing1", "hello" },
    { "thing2", "world" }
};

         
       
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://websitebnao.online/newMail.php?name=${0}&email=hsyed2633@gmail.com&subject={order confirmed}&message=${your order will be delivered at your door step on tomorrow}", content);
        }
    }
}
