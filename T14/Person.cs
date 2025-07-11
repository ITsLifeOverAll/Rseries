namespace T14;

public class Person
{
    private Job _job;

    public string GetJobTitle()
    {
        return _job.GetTitle();
    }

    public string GetJobDepartment()
    {
        return _job.GetDepartment();
    }
}

public class Job
{
    public string GetTitle() => "Engineer";
    public string GetDepartment() => "R&D";
}
   


