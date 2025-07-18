﻿namespace eCommerce.Application.Dtos
{
    public class RegisterationRequestDto
    {
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public int RegionId { get; set; }
    }
}
