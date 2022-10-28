namespace Balta.NotificationsContext
{
  public abstract class Notifiable
  {
    public List<Notification> Notifications { get; set; }
    public void AddNotificatio(Notification notification)
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