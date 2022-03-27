namespace StackLite;

public class Issue
{

    public Issue()
    {
        Score = 0;
        _title = "";
        Content = "";
    }
    public Issue(string title, string content) : this()
    {
        _title = title;
        Content = content;
    }
    //private string title;

    //public string GetTitle()
    //{
      //  return title;
    //}

    //public void SetTitle(string titleToSet)
    //{
      //  title = titleToSet;
    private string _title;
    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    } 

    public string Content { get; set; }

    public int Score { get; set; }

    public void UpVote()
    {
        Score++;
    }

    public void DownVote()
        {
            Score--;
        }

    public override string ToString()
    {
        return $" \nTitle: {Title} \nContent: {Content} \nScore: {Score}";
    }
}
