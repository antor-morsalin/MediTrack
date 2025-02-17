using System;

public class Stock
{
    private int stock_id;
    private int outlet_id;
    private int medicine_id;
    private int quantity;
    private DateTime exp_date;

    public int StockId
    {
        get { return stock_id; }
        set { stock_id = value; }
    }

    public int OutletId
    {
        get { return outlet_id; }
        set { outlet_id = value; }
    }

    public int MedicineId
    {
        get { return medicine_id; }
        set { medicine_id = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public DateTime ExpDate
    {
        get { return exp_date; }
        set { exp_date = value; }
    }

    public Stock(int stockId, int outletId, int medicineId, int quantity, DateTime expDate)
    {
        this.stock_id = stockId;
        this.outlet_id = outletId;
        this.medicine_id = medicineId;
        this.quantity = quantity;
        this.exp_date = expDate;
    }



}