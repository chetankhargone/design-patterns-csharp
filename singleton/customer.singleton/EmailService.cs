using customer.singleton;
using System;

namespace singleton.email
{
    public sealed class EmailService : IEmailService
    {
        private static volatile EmailService _instance;
        private static object syncRoot = new object();

        private EmailService()
        {
        }

        public static EmailService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new EmailService();
                        }
                    }
                }
                return _instance;
            }
        }

        public bool Send(EmailTO email)
        {
            throw new NotImplementedException();
        }
    }
}