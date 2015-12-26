﻿using System.Threading;

namespace TranscendenceChat.ServerClient.Entities.Ws.Requests
{
    public abstract class BaseRequest
    {
        private static long lastToken = 0;

        public long RequestToken { get; set; }

        public void AssignNewToken()
        {
            Interlocked.Increment(ref lastToken);
        }

        public T CreateResponse<T>() where T : BaseResponse, new()
        {
            var response = new T {RequestToken = RequestToken};
            return response;
        }
    }


    public class BaseResponse
    {
        private bool _success = true; 

        public bool Success
        {
            get { return _success; }
            set { _success = value; }
        }

        public long RequestToken { get; set; }

        public Errors Error { get; set; }

        public string ErrorMessage { get; set; }
        public string ErrorStackTrace { get; set; }
        public string InnerExceptionMessage { get; set; }
    }

    public enum Errors
    {
        Success,
        AccessTokenInvalid,
        AccessTokenExpired,
        ServerOnMaintenance,
        OperationIsNotPermitted,
        AutheniticationRequired,
        YouAreNotParticipantOfThatGroup,
        SendMessage_ReceiversNotFound,
        SendMessage_ProvideKeysForTheseDevices,
        SendMessage_ReceiverAndSenderAreSame,
        KickParticipants_OnlyOwnerCanKickParticipants,
        DeviceRegistrationRequired,
        InternalServerError,
    }
}
