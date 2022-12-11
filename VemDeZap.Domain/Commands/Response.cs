using prmToolkit.NotificationPattern;

namespace VemDeZap.Domain.Commands
{
    public class Response
    {
        public bool Success { get; }
        public object Data { get; }
        public IEnumerable<Notification> Notifications { get; }

        public Response(INotifiable notifiable)
        {
            this.Success = notifiable.IsValid();
            this.Notifications = notifiable.Notifications;
        }

        public Response(INotifiable notifiable, object data)
        {
            this.Success = notifiable.IsValid();
            this.Data = data;
            this.Notifications = notifiable.Notifications;
        }

 
    }
}
