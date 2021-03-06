﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscendenceChat.ServerClient.Entities;

namespace TranscendenceChat.ServerClient.Interfaces
{
    public interface IAdminManager
    {
        Task<List<RegDate>> TotalRegistrations();

        Task<List<User>> FlagUserList(int flagId);

        Task<int> TotalAvatarCount();

        Task<List<PopularNames>> PopularNames();

        Task<List<PopularAvatars>> PopularAvatars();
    }
}
