Battery battery = new("CR2032", 0.235, 100);

WriteLine(battery);

while (battery.RemainingCapacityPercentage > 0)
{
    Battery updatedBattery = battery with { RemainingCapacityPercentage = battery.RemainingCapacityPercentage - 1 };
    battery = updatedBattery;
}

WriteLine(battery);

public readonly record struct Battery(string Model,
                                      double TotalCapacityAmpHours,
                                      int RemainingCapacityPercentage);


