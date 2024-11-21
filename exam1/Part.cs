using exam1;
using System;

public class Part : IBillable
{
    public int PartID { get; }
    public string Description { get; }
    public int Quantity { get; }
    public decimal Cost { get; }

    public Part(int partID, string description, int quantity, decimal cost)
    {
        if (quantity <= 0) throw new ArgumentException("Quantity must be a positive number.");
        if (cost <= 0) throw new ArgumentException("Cost must be a positive amount.");

        PartID = partID;
        Description = description;
        Quantity = quantity;
        Cost = cost;
    }

    public decimal Bill() => Quantity * Cost;

    public bool Validate() => PartID.ToString().StartsWith("14") || PartID.ToString().StartsWith("15")
                               || PartID.ToString().StartsWith("16") || PartID.ToString().StartsWith("17");

    public override string ToString() => $"PartID: {PartID}, Description: {Description}, Quantity: {Quantity}, Cost: {Cost:C}";
}
