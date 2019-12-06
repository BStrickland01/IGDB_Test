using System;
using System.Collections.Generic;
using System.Text;

namespace IGDB_API.Objects
{
    public class Game
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public string summary { get; set; }
        public string storyline { get; set; }
        public Int64? collection { get; set; }
        public Int64? franchise { get; set; }
        public Int64? hypes { get; set; }
        public long? rating { get; set; }
        public long? popularity { get; set; }
        public long? aggregated_rating { get; set; }
        public Int64? aggregated_rating_count { get; set; }
        public long? total_rating { get; set; }
        public Int64? total_rating_count { get; set; }
        public Int64? rating_count { get; set; }
        public Int64? game { get; set; }
        public Int64?[] games { get; set; }
        public Int64?[] tags { get; set; }
        public Int64?[] developers { get; set; }
        public Int64?[] publishers { get; set; }
        public Int64?[] game_engines { get; set; }
        public Int64? category { get; set; }
        public object time_to_beat { get; set; }
        public Int64?[] player_perspectives { get; set; }
        public Int64?[] game_modes { get; set; }
        public Int64?[] keywords { get; set; }
        public Int64?[] themes { get; set; }
        public Int64?[] genres { get; set; }
        public Int64? first_release_date { get; set; }
        public Int64? status { get; set; }
        public Int64? pulse_count { get; set; }
        //        public release_dates(Array[Inline Model 1], optional),
        //public alternative_names(Array[Inline Model 2], optional),
        //public screenshots(Array[Inline Model 3], optional),
        //public videos(Array[Inline Model 4], optional),
        //public cover(object, optional),
        //public esrb(object, optional),
        //public pegi(object, optional),
        //public websites(Array[Inline Model 5], optional)
    }

    public class Collection
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public Int64?[] games { get; set; }
    }
    public class Franchise
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public Int64?[] games { get; set; }
    }
    public class GameEngine
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public object logo { get; set; }
        public string slug { get; set; }
        public Int64?[] games { get; set; }
        public Int64?[] platforms { get; set; }
        public Int64?[] companies { get; set; }
    }

    public class PlayerPerspective
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public Int64?[] games { get; set; }
    }

    public class GameMode
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public Int64?[] games { get; set; }
    }

    public class Keyword
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public Int64?[] games { get; set; }
    }
    public class Theme
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public Int64? created_at { get; set; }
        public long? updated_at { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public Int64?[] games { get; set; }
    }
    public class Genre
    {
        public Int64? id { get; set; }
        public string name { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public Int64?[] games { get; set; }
    }

    public class GameInfo_Short
    {
        public Int64? id { get; set; }
        public string name { get; set; }
    }
}
