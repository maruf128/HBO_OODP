using System.Text.RegularExpressions;
public static class EmailParser
{
    public readonly static string pattern;
    static EmailParser()
    {
        pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    }
    public static (string recipient, string domain, string topLevelDomain) ParseEmail(string mail)
    {
        mail = mail.Trim(); // trim het voor white spaces
        if (!Regex.IsMatch(mail, pattern))
        {
            // is dus niet correct
            return (null, null, null);
        }
        else
        {
            // email is in the correct format
            int index = mail.IndexOf("@");
            int punt = mail.LastIndexOf(".");
            string username = mail.Substring(0, index); // pak alles voor de index
            string domein = mail.Substring(index + 1); //(na codegrade kwam ik erachter dat ie alles na @ wou)
            string domeinEinde = mail.Substring(punt + 1); // pak alles na de punt
            return (username, domein, domeinEinde); // stuur alles terug
        }
    }
}