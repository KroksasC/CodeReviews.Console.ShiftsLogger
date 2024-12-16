﻿using System.Text.Json.Serialization;

internal record class Shift(
    [property: JsonPropertyName("Id")] int Id,
    [property: JsonPropertyName("EmployeeName")] string EmployeeName,
    [property: JsonPropertyName("StartOfShift")] DateTime StartOfShift,
    [property: JsonPropertyName("EndOfShift")] DateTime EndOfShift,
    [property: JsonPropertyName("Duration")] TimeSpan Duration);

public class ShiftDto
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public DateTime StartOfShift { get; set; }
    public DateTime EndOfShift { get; set; }
}