Battery battery = new("CR2032", 0.235, 100);

WriteLine(battery);

while (battery.RemainingCapacityPercentage > 0)
{
    battery.RemainingCapacityPercentage--;
}

WriteLine(battery);

public record struct Battery(string Model, 
                             double TotalCapacityAmpHours,
                             int RemainingCapacityPercentage);


