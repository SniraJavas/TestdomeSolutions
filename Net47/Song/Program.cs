/********************************************************************************************************************************************************************************************************
* A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. Otherwise, the playlist will end with the last song which points to null.   *
* Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not.                                                  *
* For example, the following code prints "True" as both songs point to each other.                                                                                                                      *
*                                                                                                                                                                                                       *
*      Song first = new Song("Hello");                                                                                                                                                                  *
*      Song second = new Song("Eye of the tiger");                                                                                                                                                      *
*                                                                                                                                                                                                       *
*      first.NextSong = second;                                                                                                                                                                         *
*      second.NextSong = first;                                                                                                                                                                         *
*                                                                                                                                                                                                       *
*      Console.WriteLine(first.IsRepeatingPlaylist());                                                                                                                                                  *
********************************************************************************************************************************************************************************************************/                  

using System;
using System.Collections.Generic;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        var isRepeatingPlaylist = false;

        var set = new HashSet<string>();
        var song = this;

        while (true)
        {
            var added = set.Add(song.name);
            if (!added)
            {
                isRepeatingPlaylist = true;
                break;
            }

            song = song.NextSong;
            if (song == null)
            {
                break;
            }
        }

        return isRepeatingPlaylist;
    }

    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");

        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
    }
}