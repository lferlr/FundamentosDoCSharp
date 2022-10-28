namespace Balta.NotificationsContext
{
  public abstract class Notifiable
  {
    public List<Notification> Notifications { get; set; }

    public Notifiable()
    {
      Notifications = new List<Notification>();
    }
    public void AddNotification(Notification notification)
    {
      Notifications.Add(notification);
    }

    public void AddNotificationRange(IEnumerable<Notification> notifications)
    {
      Notifications.AddRange(notifications);
    }

    public bool IsValid => Notifications.Any();
  }

}