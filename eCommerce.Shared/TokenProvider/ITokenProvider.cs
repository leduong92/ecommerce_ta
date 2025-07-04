﻿namespace eCommerce.Shared.TokenProvider
{
    public interface ITokenProvider
    {
        void SetToken(string token);
        string? GetToken();
        void ClearToken();
    }
}
