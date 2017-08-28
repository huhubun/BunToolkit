# BunToolkit Sample

## Walk-On-LAN

### Magic Packet
```CSharp
using Bun.Toolkit.Net.Extensions;
using System.Net.NetworkInformation;
```


```CSharp
var macAddress = PhysicalAddress.Parse("11-22-33-44-55-66");
macAddress.Wake();
```