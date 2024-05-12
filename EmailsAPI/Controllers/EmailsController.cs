using EmailsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmailsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly ILogger<EmailsController> _logger;
        private readonly ISendEmail _sendEmail;

        public EmailsController(ILogger<EmailsController> logger, ISendEmail sendEmail)
        {
            _logger = logger;
            _sendEmail = sendEmail;
        }

        [HttpPost]
        [Route("sendemail")]
        public async Task<IActionResult> SendEmail(string email, string subject, string body)
        {
            try
            {
                await _sendEmail.SendEmailAsync(email, subject, body);
                _logger.LogInformation($"{StatusCodes.Status200OK} - Email enviado com sucesso");
                return Ok("Email enviado com sucesso !!!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("Erro ao enviar o email");
            }
        }
    }
}
