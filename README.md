# EmailsAPI

Esta aplicação fornece uma API para envio de emails usando como base o SMTP do GMAIL. 

É necessário que a conta que a ser usada seja cadastrada no Senhas App do Google (https://myaccount.google.com/apppasswords?)

No arquivo appsettings.json informe os dados do  remetente dos emails, altere o 
{
  "AllowedHosts": "*",
  "SmtpSettings": {
    "Server": "smtp.gmail.com",
    "Port": 465,
    "SenderName": "nome_da_aplicação",
    "SenderEmail": "seuemail@gmail.com",
    "Username": "seuemail@gmail.com",
    "Password": "senha_gerada"
  }
}



## Endpoint

### Email

#### Envio de Email
- Método: POST
- Rota: `/api/emails/sendemail`
- Descrição: Envia email com a mensagem informada para conta desejada.
