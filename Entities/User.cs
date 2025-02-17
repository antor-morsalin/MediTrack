public class User
{
    private string full_name;
    private string user_name;
    private string password;

    public string Full_name
    {
        get {  return full_name; }
        set { full_name = value; }  
    }
    public string User_name
    {
        get { return user_name; }
        set { user_name = value; }
    }
    public string Password
    {
        get { return password; }
        set { password = value; }
    }


    public User(string full_name, string user_name, string password)
    {
        this.full_name = full_name;
        this.user_name = user_name;
        this.password = password;
    }


}