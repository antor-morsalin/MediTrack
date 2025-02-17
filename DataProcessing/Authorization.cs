using System.Text.RegularExpressions;

public class Authorization
{
    public static bool firstNameAuth(string s)
    {
        if (s.Length < 3) return false;
        return true;
    }
    public static bool lastNameAuth(string s)
    {
        if (s.Length < 3) return false;
        return true;
    }
    public static bool userNameAuth(string s)
    {
        if (s.Length < 3) return false;

        foreach(char c in s)
        {
            if(c == ' ')
            {
                return false;
            }
        }

        return true;
    }
    public static bool passowordAuth(string s)
    {
        if (s.Length < 6) return false;

        foreach (char c in s)
        {
            if (c == ' ')
            {
                return false;
            }
        }
        return true;
    }

    public static bool passwordAuth(string username, string password)
    {
        int userCount = DatabaseConnection.getUserCount(username, password);
        if(userCount > 0)
        {
            return true;
        }
        return false;
    }

    public static bool contactAuth(string contact)
    {
        if(contact.Length < 3 || contact.Length > 13) return false;

        bool containsNonDigits = Regex.IsMatch(contact, @"\D");
        if ((containsNonDigits))
        {
            return false;
        }
        return true;
    }
}