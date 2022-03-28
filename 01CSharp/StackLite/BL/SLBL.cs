using Models;
using DL;

namespace BL;
public class SLBL
{
    public void CreateIssue(Issue issueToCreate)
    {
        StaticStorage.Issues.Add(issueToCreate);
    }

    public List<Issue> GetIssue()
    {
        return StaticStorage.Issues;
    }
}
