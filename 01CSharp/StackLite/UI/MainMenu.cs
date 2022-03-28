using Models;
using System.ComponentModel.DataAnnotations;
using BL;

namespace UI;

public class MainMenu
{
    public void Start()
    {

        bool exit = false;

        do
        {
            Console.WriteLine("Welcome to StackLite");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("[1] Submit a question");
            Console.WriteLine("[2] View all questions");
            Console.WriteLine("[3] Select an issue");
            Console.WriteLine("[x] Exit");

            string? input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    CreateNewIssue();
                break;

                case "2":
                    DisplayAllIssues();
                break;

                case "3":
                    SelectIssue();
                break;

                case "x":
                    Console.WriteLine("Have a good day!");
                    exit = true;
                break;

                default:
                    Console.WriteLine("Invalid input, please try again");
                break;
            }
        }while(!exit);
    }

    private void CreateNewIssue()
    {
        EnterIssueData:
        Console.WriteLine("Creating new question");
        Console.WriteLine("Enter title of question: ");
        string? title = Console.ReadLine();

        Console.WriteLine("Enter content: ");
        string? content = Console.ReadLine();

        Issue issueToCreate = new Issue();

        try
        {
            issueToCreate.Title = title!;
            issueToCreate.Content = content!;
        }
        catch(ValidationException ex)
        {
            Console.WriteLine(ex.Message);
            goto EnterIssueData;
        }

        new SLBL().CreateIssue(issueToCreate);
    }

    private void DisplayAllIssues()
    {
        Console.WriteLine("Here are all the questions");
        List<Issue> allIssues = new SLBL().GetIssue();

        foreach(Issue issueToDisplay in allIssues)
        {
            Console.WriteLine(issueToDisplay);
        }
    }

    private Issue SelectIssue()
    {
        Console.WriteLine("Select an issue");
        {
            List<Issue> allIssues = new SLBL().GetIssue();

            if(allIssues.Count == 0)
            {
                Console.WriteLine("No issues to display");
                return null;
            }

            SelectIssue:
            for(int i = 0; i < allIssues.Count; i++)
            {
                Console.WriteLine($"[{i}] {allIssues[i]}");
            }

            int selection;
            if(Int32.TryParse(Console.ReadLine(), out selection) && (selection >= 0 && selection < allIssues.Count))
            {
                Console.WriteLine(allIssues[selection]);
                return allIssues[selection];
            }
            else
            {
                Console.WriteLine("Please enter valid input");
                goto SelectIssue;
            }


        }
    }
}