using projetoEnvioEmail.model;

namespace projetoEnvioEmail.service
{
    public interface IEmailService
    {
         void SendEmail(Message message);
    }
}