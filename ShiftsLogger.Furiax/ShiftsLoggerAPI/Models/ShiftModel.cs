﻿namespace ShiftsLoggerAPI.Models
{
	public class ShiftModel
	{
		public int Id { get; set; }
		public string EmployeeName { get; set; }
		public DateTime StartOfShift { get; set; }
		public DateTime EndOfShift { get; set; }
		public TimeSpan Duration => EndOfShift - StartOfShift;
	}
}
