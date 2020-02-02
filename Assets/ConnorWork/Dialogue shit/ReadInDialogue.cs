using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInDialogue : MonoBehaviour
{
    public Dialogue[] dialogues;
    public TextAsset json;
    private DioTimeline globalDioTimeline;
    private string[] names = { "Jensen", "Jacob", "Reese", "Izzy", "Lucy", "Archie", "Connor", "Collin", "Fanta", "Collette", "Rogger", "Omaga", "Omega", "Xenon", "Zendaya", "Gretta"};
    private string[] colors = { "black", "orange", "red", "yellow", "green", "blue", "indigo", "violet", "purple", "pink" };
    private string[] events = {"our anniversary", "the day of our first date", "my mother's birthday", "my birthday", "the day we met", "the day you met my parents", "the day of our honeymoon"};
    private string[] foods = { "oranges", "strawberries", "apple pie", "filet mignon", "buffalo wings", "mac n cheese", "human blood" };
    private string[] dates = { "January 3rd", "February 29th", "October 1st", "June 6th", "December 24th", "July 2nd", "June 15th", "November 18th", "March 8th", "April 1st", "May 20th", "April 20th" };
    // Start is called before the first frame update
    void Start()
    {
        globalDioTimeline = FindObjectOfType<DioTimeline>();
        string text = json.text;
        
        //handle names
        string name = names[(int)Random.Range(0, names.Length)];
        while (text.Contains("%Name%"))
        {
            text = text.Replace("%Name%", name);
        }
        List<string> n = new List<string>(names);
        n.Remove(name);
        names = n.ToArray();
        while (text.Contains("%RandName%")) {
            name = names[(int)Random.Range(0, names.Length)];
            text = text.Replace("%RandName%", name);
            n = new List<string>(names);
            n.Remove(name);
            names = n.ToArray();
        }


        //handle colors
        string color = colors[(int)Random.Range(0, colors.Length)];
        while (text.Contains("%Color%"))
        {
            text = text.Replace("%Color%", color);
        }
        n = new List<string>(colors);
        n.Remove(color);
        colors = n.ToArray();
        while (text.Contains("%RandColor%"))
        {
            color = colors[(int)Random.Range(0, colors.Length)];
            text = text.Replace("%RandColor%", color);
            n = new List<string>(colors);
            n.Remove(color);
            colors = n.ToArray();
        }

        //handle events
        Debug.Log("events "+events.Length);
        string event1 = events[(int)Random.Range(0, events.Length)];
        while (text.Contains("%Event%"))
        {
            text = text.Replace("%Event%", event1);
        }
        n = new List<string>(events);
        n.Remove(event1);
        events = n.ToArray();
        while (text.Contains("%RandEvent%"))
        {
            event1= events[(int)Random.Range(0, events.Length)];
            text = text.Replace("%RandEvent%", event1);
            n = new List<string>(events);
            n.Remove(event1);
            events = n.ToArray();
        }

        //handle foods
        string food = foods[(int)Random.Range(0, foods.Length)];
        while (text.Contains("%Food%"))
        {
            text = text.Replace("%Food%", food);
        }
        n = new List<string>(foods);
        n.Remove(food);
        foods = n.ToArray();
        while (text.Contains("%RandFood%"))
        {
            food = foods[(int)Random.Range(0, foods.Length)];
            text = text.Replace("%RandFood%", food);
            n = new List<string>(foods);
            n.Remove(food);
            foods = n.ToArray();
        }

        //handle dates
        string date = dates[(int)Random.Range(0, dates.Length)];
        while (text.Contains("%Date%"))
        {
            text = text.Replace("%Date%", date);
        }
        n = new List<string>(dates);
        n.Remove(date);
        dates = n.ToArray();
        while (text.Contains("%RandDate%"))
        {
            date = dates[(int)Random.Range(0, dates.Length)];
            text = text.Replace("%RandDate%", date);
            n = new List<string>(dates);
            n.Remove(date);
            dates = n.ToArray();
        }
        
        DialogueRead dr = JsonUtility.FromJson<DialogueRead>(json.text);
        dialogues = dr.dialogue;
        globalDioTimeline.ReadInReady();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


