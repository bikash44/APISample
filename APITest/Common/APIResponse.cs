using System;
using System.Net;

namespace APITest.Common
{
    public class APIResponse
    {
        public static APIResponse OK()
        {
            return new APIResponse(HttpStatusCode.OK, "Success");
        }

        public static APIResponse OK(string message)
        {
            return new APIResponse(HttpStatusCode.OK, message);
        }
        

        public static APIResponse OK(string message, dynamic data)
        {
            return new APIResponse(HttpStatusCode.OK, message)
            {
                Data = data
            };
        }


        public static APIResponse InternalError(Exception ex)
        {
            return new APIResponse(HttpStatusCode.InternalServerError, "Internal Server Error. Error: " + ex.Message + " StackTrace: " + ex.StackTrace);
        }
        public static APIResponse UnAuthorized()
        {
            return UnAuthorized("Unauthorized Access");
        }
        public static APIResponse UnAuthorized(string message)
        {
            return new APIResponse(HttpStatusCode.Unauthorized, message);
        }
        public static APIResponse BadRequest(string message)
        {
            return new APIResponse(HttpStatusCode.BadRequest, message);
        }

        public APIResponse(HttpStatusCode statusCode) : this(statusCode, "")
        {

        }

        public APIResponse(HttpStatusCode statusCode, string message)
        {
            this.StatusCode = (int)statusCode;
            this.StatusMessage = message;
            this.ServerTime = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.ffffffK");
        }

        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public dynamic Data { get; set; }
        public string ServerTime { get; set; }
    }

}
