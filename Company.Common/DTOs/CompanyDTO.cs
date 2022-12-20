﻿namespace Companies.Common.DTOs;

public record CompanyDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? OrganisationNumber { get; set; }
}
