using exam1;
using System;

public class Service : IBillable
{
    public string ServiceID { get; }
    public string Detail { get; }
    public decimal Price { get; }

    public Service(string serviceID, string detail, decimal price)
    {
        if (price <= 0) throw new ArgumentException("Price must be a positive amount.");

        ServiceID = serviceID;
        Detail = detail;
        Price = price;
    }

    public decimal Bill() => Price;

    public bool Validate() => ServiceID == "Debug" || ServiceID == "Configure" || ServiceID == "Restore";

    public override string ToString() => $"ServiceID: {ServiceID}, Detail: {Detail}, Price: {Price:C}";
}
