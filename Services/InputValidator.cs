public class InputValidator
{
    public bool ValidateVehicleType(string vehicleType)
    {
        vehicleType = vehicleType.ToLower();
        return vehicleType == "bike" || vehicleType == "car" || vehicleType == "bus" || vehicleType == "truck";
    }

    public bool ValidateJourneyType(string journeyType)
    {
        journeyType = journeyType.ToLower();
        return journeyType == "one way" || journeyType == "round trip";
    }

    public bool ValidateYesNo(string input)
    {
        input = input.ToLower();
        return input == "yes" || input == "no";
    }
}