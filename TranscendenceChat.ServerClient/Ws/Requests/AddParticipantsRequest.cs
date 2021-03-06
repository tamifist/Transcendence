﻿using System;
using System.Collections.Generic;

namespace TranscendenceChat.ServerClient.Entities.Ws.Requests
{
    public class AddParticipantsRequest : BaseRequest
    {
        public Guid GroupId { get; set; }

        public List<long> ParticipantIds { get; set; }
    }

    public class AddParticipantsResponse : BaseResponse
    {
    }
}