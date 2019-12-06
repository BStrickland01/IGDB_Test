using IGDB_API.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace IGDB_API
{
   public class API
    {
        public List<GameInfo_Short> GetGameTitles(string gameName)
        {
            var result = CallAPI_JArray("games", string.Format("?search={0}", gameName));
            List<GameInfo_Short> lstGameInfo = new List<GameInfo_Short>();

            foreach (var item in result)
            {
                GameInfo_Short gameInfo = GetGameInfo_Short((int)item["id"]);
                lstGameInfo.Add(gameInfo);
            }
            return lstGameInfo;
        }

        private GameInfo_Short GetGameInfo_Short(int id)
        {
            var result = CallAPI("games", string.Format("{0}?Fields=*", id));
            var gameInfo = JsonConvert.DeserializeObject<List<GameInfo_Short>>(result);

            //var data = result.Select(c => new { id = (string)c["id"], name = (string)c["name"] }).FirstOrDefault();
            return gameInfo.FirstOrDefault();
        }

        public List<Game> GetGameInfo(int id)
        {
            var result = CallAPI("games", string.Format("{0}?Fields=*", id));

            var gameInfo = JsonConvert.DeserializeObject<List<Game>>(result);
            return gameInfo;
        }

        public string GetGenre(long id)
        {
            var result = CallAPI_JArray("genres", string.Format("{0}?id=*", id));

            var data = result.Select(c => new { id = (int)c["id"], name = (string)c["name"] }).FirstOrDefault();
            return data.name;
        }

        private JArray CallAPI_JArray(string endPoint, string param)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                client.DefaultRequestHeaders.Add("user-key", "f10bdd92c9ab47aee35f515863d45909");

                var url = "https://api-2445582011268.apicast.io";
                var page = endPoint;
                var parameter = param;

                var fullUrl = string.Format("{0}/{1}/{2}", url, page, parameter);
                var response = client.GetStringAsync(new Uri(fullUrl)).Result;
                JArray o = JArray.Parse(response);
                return o;
            }
        }

        private string CallAPI(string endPoint, string param)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                client.DefaultRequestHeaders.Add("user-key", "f10bdd92c9ab47aee35f515863d45909");

                var url = "https://api-2445582011268.apicast.io";
                var page = endPoint;
                var parameter = param;

                var fullUrl = string.Format("{0}/{1}/{2}", url, page, parameter);
                var response = client.GetStringAsync(new Uri(fullUrl)).Result;
                return response;
            }
        }
    }
}
