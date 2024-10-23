using WKTechnology.TesteTecnico.Domain.Model.Common;

namespace WKTechnology.TesteTecnico.App
{
    public class BaseApp
    {
        protected List<NotificationModel> GetNotifications(string message)
        {
            return CreateNotifications(message);
        }

        protected List<NotificationModel> GetNotifications(List<string> messages)
        {
            return CreateNotifications(string.Join("; ", messages));
        }

        private List<NotificationModel> CreateNotifications(string message)
        {
            return
            [
                new NotificationModel { Type = "Error", Message = message }
            ];
        }
    }
}
