using System;
using System.Collections.Generic;

static class SupervisorFactory
{
    public static List<Supervisor> lstSupervisors = new List<Supervisor>();

    public static Supervisor GetSupervisor(int Number, string Surname, string Cell, DateTime Date)
    {
        Supervisor supervisor = lstSupervisors.Find(sp => sp.SupNumber == Number);
        if (supervisor == null)
        {
            supervisor = new Supervisor(Number, Surname, Cell, Date);
            lstSupervisors.Add(supervisor);
        }
        return supervisor;
    } //GetSupervisor

} //class SupervisorFactory