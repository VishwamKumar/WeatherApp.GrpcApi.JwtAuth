﻿namespace WeatherApp.GrpcApi.JwtAuth.Configs;

public class UserCredential
{
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    
}
