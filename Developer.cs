using System;

public abstract class Developer {
    private string _mainDevLanguage;

    public Developer(string mainDevLanguage) {
        this._mainDevLanguage = mainDevLanguage;
    }

    // Static Polymorphism
     public virtual void Code() {
         Console.WriteLine("I am coding using my main dev language {0}", this._mainDevLanguage);
     }

      public virtual void Code(string extraDevLang) {
         Console.WriteLine(string.Format("I am coding using my main dev langauge {0}. Additionally, I am using {1} as extra dev language.", this._mainDevLanguage, extraDevLang));
      }

       public virtual void Code(string firstExtraDevLang, string secondExtraDevLang) {
         Console.WriteLine("I am coding  using my main dev language {0}. Additionally, I am using {1} and {2} as extra dev languages", this._mainDevLanguage, firstExtraDevLang, secondExtraDevLang);
       }
}