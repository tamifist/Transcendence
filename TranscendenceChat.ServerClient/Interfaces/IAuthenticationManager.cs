﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranscendenceChat.ServerClient
{
    public interface IAuthenticationManager
    {
        string Status { get; }

        Task<bool> GetTokenEmail(string email);

        Task<bool> GetTokenSms(string phone);

        Task<AuthTokens> CreateUserDevice(string email, string confirmKey, string publicKey, string nickname);

        Task<bool> CreateUserDeviceViaPhoneNumber(string phone, string confirmKey, string publicKey, string nickname);

        Task<AuthResponse> Authenticate(string userDeviceId, string accessToken);
    }
}
