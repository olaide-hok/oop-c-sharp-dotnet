using System;

public abstract class Developer {
    private string _mainDevLanguage;

    public Developer(string mainDevLanguage) {
        this._mainDevLanguage = mainDevLanguage;
    }

    public virtual void Code(string firstExtraDevLang = null, string secondExtraDevLang = null) {
         if (firstExtraDevLang == null && secondExtraDevLang == null) {
            Console.WriteLine("I am coding using my main dev language {0}", this._mainDevLanguage);

         } else if (firstExtraDevLang != null && secondExtraDevLang != null) {

        Console.WriteLine("I am coding  using my main dev language {0}. Additionally, I am using {1} and {2} extra dev languages", this._mainDevLanguage, firstExtraDevLang, secondExtraDevLang);
         } else if (firstExtraDevLang != null) {
            Console.WriteLine(string.Format("I am coding using my main dev langauge {0}. Additionally, I am using {1} extra dev language.", this._mainDevLanguage, firstExtraDevLang));
         } else if (secondExtraDevLang != null) {
            Console.WriteLine(string.Format("I am coding using my main dev langauge {0}. Additionally, {1} extra dev language.", this._mainDevLanguage, secondExtraDevLang));
         }
    }
}