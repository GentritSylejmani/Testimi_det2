using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testimi_det2
{
    public class Config
    {
        public static class Hotmail
        {

            public static class Credentials
            {
                public static string email = "gentrit.sylejmani@live.com";
                public static string password = "94574262Genti.11";
            }
            public static string login_page = "https://outlook.live.com/owa/?nlp=1";
            public static string emailInputElement = "i0116";
            public static string passwordInputElement = "i0118";
            public static string newEmailButton = "id__5";
            public static string ricipientInputElementXPath = "/html/body/div[2]/div/div[2]/div[1]/div[1]/div/div/div[3]/div[2]/div/div[2]/div[1]/div/div/div/div[1]/div[1]/div[1]/div/div[1]/div/div/div/div/div[1]/div/div/input";
            public static string nextButton = "idSIButton9";
            public static string validRicipient = "pleurat.pula@riinvest.net";
            public static string sendButtonClass = "_1ThK9dT4toWCphxfLMD8kj";
            public static string ricipientIsRequired = "This message must have at least one recipient.";
            public static string subjectInputElement = "/html/body/div[2]/div/div[2]/div[1]/div[1]/div/div/div[3]/div[2]/div/div[2]/div[1]/div/div/div/div[1]/div[1]/div[2]/div[2]/div/div/div/input";
            public static string subjectString = "Arsye testuese";
            public static string bodyInputElementXPath = "/html/body/div[2]/div/div[2]/div[1]/div[1]/div/div/div[3]/div[2]/div/div[2]/div[1]/div/div/div/div[1]/div[2]/div[1]";
            public static string GenerateRString(int length = 10)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                var random = new Random();
                var randomString = new string(Enumerable.Repeat(chars, length)
                                                        .Select(s => s[random.Next(s.Length)]).ToArray());
                return randomString;
            }

            public static string contactsButtonXPath = "//*[@id=\"app\"]/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div/div[3]/div[3]/a/span/i";
            public static string newContactButtonXPath = "/html/body/div[2]/div/div[2]/div/div[2]/div/div[1]/div/div/div/div/div/div[1]/div[1]/div/div/span/button[1]";
            public static string newContactNameInput = "GivenName";
            public static string newContactName = "Pluerat";
            //public static string newContactSurname = "Pula";
            public static string newContactSurnameInput = "Surname";
            public static string newContactEmailInput = "PersonaEmails1-0";

            public static string createContactXPath = "/html/body/div[6]/div/div/div/div[2]/div[2]/main/section[2]/div[2]/div/button[1]";

            public static string wrongEmailFormat = "Use this format: someone@example.com";
            public static string calendarButtonXPath = "/html/body/div[2]/div/div[2]/div[1]/div[1]/div/div/div[1]/div[2]/div/div[3]/div[2]";

            public static string newCalendarEventButtonXPath = "//*[@id=\"NewEventButtonAnchor\"]";
            public static string eventTitleInputXPath = "/html/body/div[6]/div/div/div/div[3]/div/div[2]/div[2]/div[1]/div[2]/div[2]/div/div/div/div/input";

            public static string saveEventButtonXPath = "/html/body/div[6]/div/div/div/div[3]/div/div[2]/div[2]/div[2]/button[1]";

            public static string confirmEventCreationButtonXPath = "/html/body/div[8]/div/div/div/div[2]/div[2]/div/div[2]/div[2]/div/span[1]/button";

            public static string confirmEventWithoutTitle = "Do you want to save this appointment without a title?";

            public static string noSubjectEvent = "(No subject)";

        }
    }
}
