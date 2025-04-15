﻿namespace RedFox.Application.DTO;

public record UserCreationDto(
    string Name,
    string Username,
    string Email,
    string Phone,
    string Website,
    CompanyDto Company);