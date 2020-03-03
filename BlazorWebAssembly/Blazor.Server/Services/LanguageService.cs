using System.Collections.Generic;

namespace API.Services
{
    public partial class LanguageService : ILanguageService
    {
        protected virtual List<string> Languages { get; }

        public LanguageService()
        {
            Languages = new List<string>();
            Languages.Add("English");
            Languages.Add("French");
        }

        public virtual void AddLanguage(string language)
        {
            Languages.Add(language);
        }

        public virtual List<string> GetAll()
        {
            return Languages;
        }
    }

    public partial interface ILanguageService
    {
        void AddLanguage(string language);

        List<string> GetAll();
    }
}
