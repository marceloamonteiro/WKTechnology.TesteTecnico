namespace WKTechnology.TesteTecnico.Domain.Model.Common
{
    public struct ResponseObject<TData>
    {
        public TData? Data { get; private set; }
        public readonly bool HasData => Data is not null;
        public bool Success { get; private set; }
        public bool HasError { get; private set; }
        public List<NotificationModel> Notifications { get; private set; }

        public ResponseObject(TData @object)
        {
            Success = true;
            HasError = false;
            Data = @object;
            Notifications = [];
        }

        public ResponseObject(List<NotificationModel> notifications)
        {
            Success = false;
            HasError = true;
            Data = default;
            Notifications = notifications;
        }
    }
}
