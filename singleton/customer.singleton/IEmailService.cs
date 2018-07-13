using customer.singleton;

namespace singleton.email
{
    public interface IEmailService
    {
        bool Send(EmailTO email);
    }
}