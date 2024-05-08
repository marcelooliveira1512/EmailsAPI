namespace EmailsAPI.Services
{
    public interface ISendEmail
    {
        Task SendEmailAsync(string email, string subject, string body);
    }
}
