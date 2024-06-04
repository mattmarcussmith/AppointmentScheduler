using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969MatthewSmith.ITranslation
{
    public class TranslationManager
    {
        public ITranslations GetTranslation()
        {
            string currentLanguage = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

            if (currentLanguage.Equals("es", StringComparison.OrdinalIgnoreCase))
            {
                return new SpanishTranslation();
            }
            else
            {
                return new EnglishTranslation();
            }

        }
    }
}
