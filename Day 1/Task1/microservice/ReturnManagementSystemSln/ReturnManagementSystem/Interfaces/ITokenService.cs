﻿using ReturnManagementSystem.Models;

namespace ReturnManagementSystem.Interfaces
{
    public interface ITokenService
    {
        public string GenerateToken(User user);
    }
}
