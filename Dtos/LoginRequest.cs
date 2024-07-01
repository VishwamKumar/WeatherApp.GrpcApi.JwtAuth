﻿
namespace WeatherApp.GrpcApi.JwtAuth.Dtos;

public class LoginRequest
{
    [Required]
    public string Username { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
}
