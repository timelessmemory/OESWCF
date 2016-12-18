using System;
using System.ServiceModel;
using OesWCFImpl;

namespace OesWCFHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(ServiceHost examHost = new ServiceHost(typeof(ExamService)))
            using (ServiceHost questionHost = new ServiceHost(typeof(QuestionService)))
            using (ServiceHost userHost = new ServiceHost(typeof(UserService)))
            {
                userHost.Open();
                examHost.Open();
                questionHost.Open();

                Console.WriteLine("Service started, Press ENTER to stop and exit.");
                Console.ReadLine();
            }
        }
    }
}
