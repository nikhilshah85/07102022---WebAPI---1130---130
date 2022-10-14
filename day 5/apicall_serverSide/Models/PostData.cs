namespace apicall_serverSide.Models
{
    public class PostData
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        List<PostData> postDataResult = new List<PostData>();

        public List<PostData> GetPostData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear(); //differnt browsers and devises has default data formate, xml,binary, json, etc...
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(url); //make a call
            if (response.Result.IsSuccessStatusCode) //if the call is successfull, start to to read the data
            {
                var data = response.Result;
                var details = data.Content.ReadAsAsync<List<PostData>>();
                details.Wait();
                postDataResult = details.Result;
                return postDataResult;
                
            }
            else
            {
                throw new Exception("Could not connect server");
            }



        }
    }
}
