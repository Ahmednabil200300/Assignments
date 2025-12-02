using assignment.Authentication;
using assignment.Notification;
using assignment.Shape;


namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Circle circle = new Circle() { Radius = 7};
            //     circle.DisplayShapeInfo();
            //   Rectangle rectangle = new Rectangle() { Width = 10, Height = 20};
            //     rectangle.DisplayShapeInfo();


            #endregion



            #region Q2
            //IAuthenticationService authenticationService = new BasicAuthenticationService();
            //bool isUser = authenticationService.AuthenticateUser("ola", "123");

            //Console.WriteLine(isUser);

            //bool isAdmin = authenticationService.AuthorizeUser("ola", "admin");

            //Console.WriteLine(isAdmin);


            // isUser = authenticationService.AuthenticateUser("mohamed", "456");

            //Console.WriteLine(isUser);
            //isAdmin = authenticationService.AuthorizeUser("mohamed", "user");
            //Console.WriteLine(isAdmin);



            #endregion



            #region Q3


            INotificationService EmailNotification = new EmailNotificationService() ;
            EmailNotification.SendNotification("Ola", "Please Answer The message");
            Console.WriteLine("================");
            INotificationService SmsNotification = new SmsNotificationService() ;
            SmsNotification.SendNotification("ola", "Please Answer The message");
            Console.WriteLine("================");
            INotificationService PushNotification = new PushNotificationService() ;
            PushNotification.SendNotification("ola", "Please Answer The message");

            #endregion
        }
    }
}
