class Program
{
    static void Main(string[] args)
    {
        var clientService = new ClientService();
        var notificationService = new NotificationService();

        clientService.CreateClient();
        clientService.ReadClient();
        clientService.UpdateClient();
        clientService.DeleteClient();
        notificationService.NotifyClient();
    }
}