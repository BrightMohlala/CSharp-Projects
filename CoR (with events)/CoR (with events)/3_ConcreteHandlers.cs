using System;

public class R50 : AHandler
{
    public override void ProcessRequest(int cents)
    {
        if (cents >= 50 * 100)
        {
            int n = cents / 5000;
            //Console.WriteLine("\t" + n + " x R50");
            RaiseOnHandle(n.ToString() + " x R50");
            cents -= n*5000;
        }
        successor.ProcessRequest(cents);
    } //ProcessRequest
} //class R50

public class R10 : AHandler
{
    public override void ProcessRequest(int cents)
    {
        if (cents >= 10 * 100)
        {
            int n = cents / 1000;
            //Console.WriteLine("\t" + n + " x R10");
            RaiseOnHandle(n.ToString() + " x R10");
            cents -= n*1000;
        }
        successor.ProcessRequest(cents);
    } //ProcessRequest
} //class R10

public class R5 : AHandler
{
    public override void ProcessRequest(int cents)
    {
        if (cents >= 5 * 100)
        {
            int n = cents / 500;
            //Console.WriteLine("\t" + n + " x R5");
            RaiseOnHandle(n.ToString() + " x R5");
            cents -= n*500;
        }
        successor.ProcessRequest(cents);
    } //ProcessRequest
} //class R5

public class R1 : AHandler
{
    public override void ProcessRequest(int cents)
    {
        if (cents >= 1 * 100)
        {
            int n = cents / 100;
            //Console.WriteLine("\t" + n + " x R1");
            RaiseOnHandle(n.ToString() + " x R1");
            cents -= n * 100;
        }
        successor.ProcessRequest(cents);
    } //ProcessRequest
} //class R1

public class c50 : AHandler
{
    public override void ProcessRequest(int cents)
    {
        if (cents >= 50)
        {
            int n = cents / 50;
            //Console.WriteLine("\t" + n + " x 50c");
            RaiseOnHandle(n.ToString() + " x 50c");
            cents -= n * 50;
        }
        successor.ProcessRequest(cents);
    } //ProcessRequest
} //class c50

public class c20 : AHandler
{
    public override void ProcessRequest(int cents)
    {
        if (cents >= 20)
        {
            int n = cents / 20;
            //Console.WriteLine("\t" + n + " x 20c");
            RaiseOnHandle(n.ToString() + " x 20c");
            cents -= n * 20;
        }
        successor.ProcessRequest(cents);
    } //ProcessRequest
} //class c20

public class c10 : AHandler
{
    public override void ProcessRequest(int cents)
    {
        if (cents >= 10)
        {
            int n = cents / 10;
            //Console.WriteLine("\t" + n + " x 10c");
            RaiseOnHandle(n.ToString() + " x 10c");
            cents -= n * 10;
        }
        successor.ProcessRequest(cents);
    } //ProcessRequest
} //class c10

public class c1 : AHandler
{
    public override void ProcessRequest(int cents)
    {
        //Console.WriteLine("\t" + cents + " x 1c");
        RaiseOnHandle(cents.ToString() + " x 1c");
    } //ProcessRequest
} //class c1