using System.Net;
using System.Web;
using meraki_API;
using Newtonsoft.Json;


WebClient client = new WebClient();
string json = client.DownloadString("https://jsonplaceholder.typicode.com/todos/");


var d = JsonConvert.DeserializeObject<List<my_data>>(json);
Console.WriteLine(d[8].id);


foreach (var m  in d )
{
    Console.WriteLine(m.id);
}

 

