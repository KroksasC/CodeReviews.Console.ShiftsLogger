﻿namespace ShiftsLogger.K_MYR;

public interface IShiftsService
{
    Task<ShiftDto> AddShiftAsync(ShiftInsertModel shiftDTO, ApplicationUser user);
    Task<bool> DeleteShiftAsync(int id, ApplicationUser user);
    Task<bool> UpdateShiftAsync(int id, ShiftInsertModel shift, ApplicationUser user);
}
