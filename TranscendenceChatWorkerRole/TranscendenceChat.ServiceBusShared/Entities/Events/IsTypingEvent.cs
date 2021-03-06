﻿using System;

namespace TranscendenceChat.ServiceBusShared.Entities
{
    [Serializable]
    public class IsTypingEvent : Event
    {
        public bool IsTyping { get; set; }
        
        public long SenderUserId { get; set; }
        
        public Guid GroupId { get; set; }
    }
}
