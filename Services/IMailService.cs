using System.Collections.Generic;

namespace GmailStackDemo.Services
{
    public interface IMailService
    {
        IEnumerable<string> GetUnreadMails();
        IEnumerable<string> GetAllMails();
    }
}
