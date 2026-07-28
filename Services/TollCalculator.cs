/* Business Rules
 * Vehicle Type - Base Toll
 * Bike - 50
 * Car - 100
 * Bus - 200
 * Truck - 300
 */

/* Journey Type - Rule
 * One Way - Base Toll
 * Round Trip - Base Toll * 1.8
 */

/* FASTag - Rule (Discount)
 * If FASTag is available, apply 10% discount on the final toll amount.
 */

/* Peak Hour - Rule
 * If Peak Hour is Yes, apply 20% additional charge.
 */

public class TollCalculator
{
    public Toll CalculateToll(Vehicle vehicle)
    {
        Toll toll = new Toll();

        switch (vehicle.VehicleType.ToLower())
        {
            case "bike":
                toll.BaseToll = 50;
                break;

            case "car":
                toll.BaseToll = 100;
                break;

            case "bus":
                toll.BaseToll = 200;
                break;

            case "truck":
                toll.BaseToll = 300;
                break;
        }

        toll.FinalTollAmount = toll.BaseToll;

        if (vehicle.JourneyType.Equals("round trip", StringComparison.OrdinalIgnoreCase))
        {
            toll.FinalTollAmount *= 1.8;
        }

        if (vehicle.FASTagAvailable)
        {
            toll.Discount = toll.FinalTollAmount * 0.10;
            toll.FinalTollAmount -= toll.Discount;
        }

        if (vehicle.PeakHour)
        {
            toll.AdditionalCharges = toll.FinalTollAmount * 0.20;
            toll.FinalTollAmount += toll.AdditionalCharges;
        }

        return toll;
    }
}