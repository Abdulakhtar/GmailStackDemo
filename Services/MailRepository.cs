using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;

namespace GmailStackDemo.Services
{
    public class MailRepository : IMailService
    {
        private readonly string mailServer, login, password;
        private readonly int port;
        private readonly bool ssl;

        public MailRepository(string mailServer, int port, bool ssl, string login, string password)
        {
            this.mailServer ="imap.gmail.com";
            this.port =993;
            this.ssl =true;
            this.login ="abdullahtestmail1@gmail.com";
            this.password = "ifdy hoff koua gayc";
        }

        public IEnumerable<string> GetUnreadMails()
        {
            var messages = new List<string>();

            using (var client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.Authenticate(login, password);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                var results = inbox.Search(SearchOptions.All, SearchQuery.Not(SearchQuery.Seen));
                foreach (var uniqueId in results.UniqueIds)
                {
                    var message = inbox.GetMessage(uniqueId);
                    messages.Add(message.HtmlBody);
                }

                client.Disconnect(true);
            }

            return messages;
        }

        public IEnumerable<string> GetAllMails()
        {
            var messages = new List<string>();

            using (var client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.Authenticate(login, password);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                var results = inbox.Search(SearchOptions.All, SearchQuery.Not(SearchQuery.Seen));
                foreach (var uniqueId in results.UniqueIds)
                {
                    var message = inbox.GetMessage(uniqueId);
                    messages.Add(message.HtmlBody);
                }

                client.Disconnect(true);
            }

            return messages;
        }
    }
}
