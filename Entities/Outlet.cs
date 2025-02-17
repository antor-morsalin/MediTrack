public class Outlet
{
    private int outlet_id;
    private string outlet_name;
    private string outlet_address;
    private string outlet_contact;

    public int Outlet_id
    {
        get { return outlet_id; }
        set { outlet_id = value; }
    }
    public string Outlet_name
    {
        get {return outlet_name;}
        set { outlet_name = value;}
    }
    public string Outlet_address
    {
        get { return outlet_address; }
        set { outlet_address = value; }
    }
    public string Outlet_contact
    {
        get { return outlet_contact; }
        set { outlet_contact = value; }
    }

    public Outlet(int outlet_id, string outlet_name, string outlet_address, string outlet_contact)
    {
        this.outlet_id = outlet_id;
        this.outlet_name = outlet_name;
        this.outlet_address = outlet_address;
        this.outlet_contact = outlet_contact;
    }

    


}