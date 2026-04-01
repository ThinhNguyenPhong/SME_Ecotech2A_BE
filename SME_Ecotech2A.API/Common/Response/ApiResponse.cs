using System.Net;

namespace SME_Ecotech2A.API.Common.Response
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public List<string> Errors { get; set; }



        private ApiResponse(bool success, int statusCode, string message, T data, List<string> errors = null)
        {
            Success = success;
            StatusCode = statusCode;
            Message = message;
            Data = data;
            Errors = errors ?? new List<string>();
        }


        public static ApiResponse<T> Succeed(T data, string message = "Operation successful")
        {
            return new ApiResponse<T>(true, (int)HttpStatusCode.OK, message, data);
        }

        public static ApiResponse<T> Succeed(T data, int statusCode, string message)
        {
            return new ApiResponse<T>(true, statusCode, message, data);
        }

        public static ApiResponse<T> Fail(string message, int statusCode = (int)HttpStatusCode.BadRequest)
        {
            return new ApiResponse<T>(false, statusCode, message, default, new List<string> { message });
        }

        public static ApiResponse<T> ValidationError(List<string> errors)
        {
            return new ApiResponse<T>(false, (int)HttpStatusCode.UnprocessableEntity, "Validation failed", default, errors);
        }

        public static ApiResponse<T> NoContent(string message = "No content found")
        {
            return new ApiResponse<T>(true, (int)HttpStatusCode.NoContent, message, default);
        }
    }
}
