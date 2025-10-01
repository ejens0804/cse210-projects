public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        //displays job information in the format:
        //"Job Title (Company) StartYear-EndYear"
        //ex. "Software Engineer (Microsoft) 2019-2022"
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}