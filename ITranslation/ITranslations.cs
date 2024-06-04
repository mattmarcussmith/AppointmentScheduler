using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969MatthewSmith.ITranslation
{
    public interface ITranslations
    {
        string LabelHeader { get; }
        string LabelUsername { get; }
        string LabelPassword { get; }
        string ButtonLogin { get; }
        string ButtonExit { get; }
        string ErrorEmptyUsernamePassword { get; }
        string ErrorInvalidUsernamePassword { get; }
      

    }
}
