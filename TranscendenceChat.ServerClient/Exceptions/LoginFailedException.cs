﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranscendenceChat.ServerClient
{
    public class LoginFailedException : Exception
    {
        public LoginFailedException()
        {
        }

        public LoginFailedException(string message)
            : base(message)
        {
        }
    }
}
