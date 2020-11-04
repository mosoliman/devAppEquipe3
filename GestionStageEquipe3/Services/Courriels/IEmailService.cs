using System;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Services.Courriels
{
    public interface IEmailService
    {
        Task<Exception> Send(EmailMessage emailMessage);
    }
}