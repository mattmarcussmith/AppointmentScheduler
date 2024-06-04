using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969MatthewSmith.ITranslation
{
    public class EnglishTranslation : ITranslations
    {
        public string LabelHeader => "Login";
        public string LabelUsername => "Username";
        public string LabelPassword => "Password";
        public string ButtonLogin => "Login";
        public string ButtonExit => "Exit";
        public string ErrorEmptyUsernamePassword => "Please enter a username and password";
        public string ErrorInvalidUsernamePassword => "Invalid username or password";
    }
    
}
