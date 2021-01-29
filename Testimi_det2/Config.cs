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
            public static string ricipientInputElementClass = "pickerInput_8207e7dc";
            public static string nextButton = "idSIButton9";
            public static string validRicipient = "pleurat.pula@riinvest.net";
            public static string sendButtonClass = "_1ThK9dT4toWCphxfLMD8kj";
            public static string ricipientIsRequired = "This message must have at least one recipient.";
            public static string subjectInputElement = "input[contains(@placeholder, \"example\")]";
            public static string subjectString = "Arsye testuese";
            public static string bodyInputElementClass = "_2_G1lB2DCB_6t73ZTT6vX3";
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
            public static string newContactSurname = "Pula";
            public static string newContactSurnameInput = "Surname";
            public static string newContactEmailInput = "PersonaEmails1-0";

            public static string createContactXPath = "/html/body/div[6]/div/div/div/div[2]/div[2]/main/section[2]/div[2]/div/button[1]";

        }
    }
}
