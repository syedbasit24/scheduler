using EmployeeGreeting.data;
using System;
using System.Collections.Generic;
using System.Timers;

public class EmailScheduler
{
    private readonly List<ScheduledEmail> scheduledEmails;
    private readonly Timer emailTimer;

    public EmailScheduler()
    {
        scheduledEmails = new List<ScheduledEmail>();
        emailTimer = new Timer();
        emailTimer.Elapsed += SendScheduledEmails;
        emailTimer.Interval = 60000; // Interval in milliseconds (adjust as needed)
    }

    public void ScheduleEmail(ScheduledEmail email)
    {
        scheduledEmails.Add(email);
    }

    public void StartScheduler()
    {
        emailTimer.Start();
    }

    private void SendScheduledEmails(object sender, ElapsedEventArgs e)
    {
        DateTime currentTime = DateTime.Now;

        foreach (var email in scheduledEmails)
        {
            if (currentTime >= email.ScheduledDateTime)
            {
                SendEmail(email);
                scheduledEmails.Remove(email);
            }
        }
    }

    private void SendEmail(ScheduledEmail email)
    {


        Console.WriteLine($"Sending email to {email.RecipientEmail}...");
        Console.WriteLine($"Subject: {email.Subject}");
        Console.WriteLine($"Body:\n{email.Body}\n");

    }
}
