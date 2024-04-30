using System;
using System.Security.Cryptography.X509Certificates;

public class Job
{
    public string _jobTitle;
    public string _nameofCompany;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_nameofCompany})  {_startYear}-{_endYear}");
    }
}