using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class WebsocketsStatisticsEntry
{
    public uint Id { get; set; }

    public string AppId { get; set; } = null!;

    public int PeakConnectionCount { get; set; }

    public int WebsocketMessageCount { get; set; }

    public int ApiMessageCount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
