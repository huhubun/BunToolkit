# BunToolkit Sample

## Walk-On-LAN

### Magic Packet
```CSharp
var macAddress = PhysicalAddress.Parse("11-22-33-44-55-66");
macAddress.Wake();
```

## DateTime

### In
```CSharp
var birthday = new DateTime(2017, 2, 22);
if (birthday.In(new DateTime(2017, 2, 19), new DateTime(2017, 3, 20)))
{
    Console.WriteLine("Pisces");
}

```

### EachDate
```CSharp
var allTheMonday = DateTimeHelper.EachDate(new DateTime(2017, 1, 1), new DateTime(2017, 1, 31))
                                 .Where(d => d.DayOfWeek == DayOfWeek.Monday);

```