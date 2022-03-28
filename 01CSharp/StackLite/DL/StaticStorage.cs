using Models;

namespace DL;
public static class StaticStorage
{
    public static List<Issue> Issues { get; set; } = new List<Issue>()
    {
        new Issue
        {
            Title = "Null Reference Exception",
            Content = "I keep getting a null reference exception"
        },
        new Issue
        {
             Title = "Intellicode doesn't work",
            Content = "I am not getting any help from code editor"
        },
        new Issue
        {
             Title = "type not found, missing user directive",
            Content = "not sure what this means"
        },
        new Issue
        {
             Title = "Generic title 4",
            Content = "Generic content 4"
        },
        new Issue
        {
             Title = "Generic title 5",
            Content = "Generic content 5"
        },
    };
}

