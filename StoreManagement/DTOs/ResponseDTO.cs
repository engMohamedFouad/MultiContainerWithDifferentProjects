namespace StoreManagement.DTOs
{
    public class ResponseDTO{
        public string Message{get;set;}
        public bool IsSuccess { get; set; }
        public object Result{get;set;}
    }
}