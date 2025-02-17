using System;
using System.Collections.Generic;

public class Medicine
{
    private int medicine_id;
    private string medicine_name;
    private string medicine_description;
    private string manufacturer;
    private string grp;

    public int Medicine_id
    {
        get { return medicine_id; }
        set { medicine_id = value; }
    }

    public string Medicine_name
    {
        get { return medicine_name; }
        set { medicine_name = value; }
    }

    public string Medicine_description
    {
        get { return medicine_description; }
        set { medicine_description = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    public string Grp
    {
        get { return grp; }
        set { grp = value; }
    }

    public Medicine(int medicine_id, string medicine_name, string medicine_descryption, string manufacturer, string grp)
    {
        this.medicine_id = medicine_id;
        this.medicine_name = medicine_name;
        this.medicine_description = medicine_descryption;
        this.manufacturer = manufacturer;
        this.grp = grp;
    }

    
}