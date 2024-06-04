using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969MatthewSmith.ITranslation
{
     public class SpanishTranslation : ITranslations
    {
        public string LabelHeader => "Inicio de sesión";
        public string LabelUsername => "Nombre de usuario";
        public string LabelPassword => "Contraseña";
        public string ButtonLogin => "Iniciar sesión";
        public string ButtonExit => "Salida";
        public string ErrorEmptyUsernamePassword => "Por favor, introduzca un nombre de usuario y una contraseña";
        public string ErrorInvalidUsernamePassword => "Nombre de usuario o contraseña no válidos";
    }
    
}
