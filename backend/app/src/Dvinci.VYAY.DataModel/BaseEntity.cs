﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dvinci.VYAY.DataModel;

public class BaseEntity
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
