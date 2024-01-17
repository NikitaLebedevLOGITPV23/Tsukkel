using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

public class Message
{
    private readonly string _content;
    private readonly string _author;
    private readonly DateTime _time;
    private int _likes;

    public Message(string content, string author, DateTime time)
    {
        this._content = content;
        this._author = author;
        this._time = time;
    }

    public int Likes { get => _likes; }
    public DateTime Time { get => _time; }
    public string Author { get => _author; }
    public string Content { get => _content; }

    public void AddLike()
    {
        _likes++;
    }

    public double GetPopularity()
    {
        double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
        if (elapsed == 0)
        {
            return _likes;
        }
        return _likes / elapsed;

    }


    public void info() 
    {
        Console.WriteLine("Sisu: {0}\nAutor: {1}\nMessageTime: {2}\n", Content, Author, Time);
    }

    public string Funct(double esimene, double teine) 
    {
        string result = "";
        if (esimene > teine) { result = "Esimene sõnu on populaarne"; };
        if (esimene < teine) { result = "Teine sõnu on populaarne"; };
        if (esimene == teine) { result = "Nad on ravni drug drugu"; };
        return result;

    }

    public string Funct2(List<Message> messages)
    {
        string result = "";
        double popularity = 0;
        for(int i = 0; i < messages.Count; i++)
        {
            if (messages[i].GetPopularity()>popularity)
            {
                popularity= messages[i].GetPopularity();
                result = messages[i].Content + "on kõige populaatsem sõnum, seda kirjutas " + messages[i].Author;
            }
        }

        return result;

    }
}