﻿namespace Companies.Common.DTOs;

public record EmployeeTitleDTO
{
    public int EmployeeId { get; set; }
    public int TitleId { get; set; }

    public EmployeeTitleDTO(int employeeId, int titleId) 
        => (EmployeeId, TitleId) = (employeeId, titleId);
}
