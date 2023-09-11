using EmployeeGreeting.data;

public class EmailComposer
{
    public string ComposeBirthdayEmail(Employee employee)
    {
        string subject = $"Happy Birthday, {employee.Name}!";
        string body = $"Dear {employee.Name},\n\n" +
                      $"Wishing you a fantastic birthday filled with joy and happiness. " +
                      $"May this year be your best one yet!\n\n" +
                      $"Best regards,\nKelevo software";

        return FormatEmail(subject, body);
    }

    public string ComposeChristmasEmail(Employee employee)
    {
        string subject = $"Merry Christmas, {employee.Name}!";
        string body = $"Dear {employee.Name},\n\n" +
                      $"Wishing you a Merry Christmas and a Happy New Year! " +
                      $"May this holiday season be filled with love, warmth, and joy.\n\n" +
                      $"Best regards,\nKelevo software";

        return FormatEmail(subject, body);
    }

    private string FormatEmail(string subject, string body)
    {
        
        return $"Subject: {subject}\n\n{body}";
    }
}
