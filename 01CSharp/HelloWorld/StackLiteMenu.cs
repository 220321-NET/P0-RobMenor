namespace StackLite;

public class StackLiteMenu
{
    public void MainMenu()
    {
        List<Issue> issues = new List<Issue>();

        Console.WriteLine("Welcome to StackLite!");
        
        bool exit = false;

        do
        {
            EnterTitle:
            Console.WriteLine("What brings you here today?");

            string title = Console.ReadLine() ?? "";

            if(String.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title cannot be empty");
                goto EnterTitle;
            }

            // string? n = null;
            //string input = n ?? "Other value";

            Enterbody:
            Console.WriteLine("Tell us more about your issue");
            string content = Console.ReadLine() ?? "";

            if(String.IsNullOrWhiteSpace(content))
            {
                Console.WriteLine("Body cannnot be empty");
                goto Enterbody;
            }

            //Issue newIssue = new Issue();
            //newIssue.Title = title;
            //newIssue.Content = content;
            //newIssue.Score = 0;

            Issue createdIssue = new Issue(title, content);

            issues.Add(createdIssue);

            // for(int i = 0; i < issues.Count; i++)
            // {
            //     Console.WriteLine(issues[i]);
            // }

            foreach(Issue issueToDisplay in issues)
            {
                Console.WriteLine(issueToDisplay);
            }

            Another:
            Console.WriteLine("Would you like to enter another? [Y/N]");
            
            string enterAnother = Console.ReadLine() ?? "";

            char responseChar;

            try
            {
                responseChar = enterAnother.Trim().ToUpper()[0];
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please enter valid input");
                goto Another;
            }

            if(responseChar == 'N')
            {
                Console.WriteLine("Goodbye!");
                exit = true;
            }
            else if(responseChar != 'Y')
            {
                Console.WriteLine("Please enter valid response");
                goto Another;
            }
        }while(!exit);
    }
        
}