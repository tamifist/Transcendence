﻿
using System;
using TranscendenceChat.ServerClient.Entities.Ws.Requests;
using TranscendenceChat.ServerClient.Ws.Events;

namespace TranscendenceChat.ServerClient.Entities.Ws.Events
{
    public class IncomingMessage : PushedEvent
    {
        public Guid EventId { get; set; }

        public DateTime Time { get; set; }

        public Guid MessageToken { get; set; }

        public long ToUserId { get; set; }

        public long FromUserId { get; set; }

        public string Text { get; set; }

        public byte[] Thumbnail { get; set; }
        
        public string FromUserName { get; set; }

        public MessageType MessageType { get; set; }
        
        public byte[] EncryptionKey { get; set; }
        
        public Guid GroupId { get; set; }
    }
}
