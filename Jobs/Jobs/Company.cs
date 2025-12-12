using System.Collections.Generic;

class Company
{
    //Properties
    public string Name { get; private set; }
    public string Address { get; private set; }
    public string Phone { get; private set; }

    private List<IJob> lstJobs;

    //Constructor
    private Company(string Name, string Address, string Phone)
    {
        this.Name = Name;
        this.Address = Address;
        this.Phone = Phone;
        lstJobs = new List<IJob>();

    } //ctor

    //Singleton members
    private static Company _instance;
    private static readonly object _lock = new object();

    //Thread-safe creation
    public static Company GetInstance(string Name, string Address, string Phone)
    {
        if (_instance == null)
        {
            lock (_lock) //Creates a lock. If a lock exists already, wait here.
            {
                if (_instance == null) //Maybe an instance was created while we waited.
                    _instance = new Company(Name, Address, Phone);
            } //Release the lock
        }

        return _instance;
    } //GetInstance

    public IEnumerable<IJob> Jobs()
    {
        foreach (IJob job in lstJobs)
            yield return job;
    } //Jobs

    public void AddJob(IJob job)
    {
        lstJobs.Add(job);
    } //AddJob

} //class Company


