using DAL.Entities;
using Shared.Enums;
using System.Collections.Generic;

namespace Tests.Fixtures
{
    public class InternshipLanguagesFixture
    {
        private readonly List<Internship> _internships;

        public InternshipLanguagesFixture()
        {
            _internships = new List<Internship>
            {
                new Internship
                {
                    LanguageTypes = new List<InternshipLanguage>
                    {
                        new InternshipLanguage { Id = 1, LanguageType = InternshipLanguageType.English, InternshipId = 1, Internship = null },
                        new InternshipLanguage { Id = 2, LanguageType = InternshipLanguageType.German, InternshipId = 1, Internship = null }
                    }
                },
                new Internship
                {
                    LanguageTypes = new List<InternshipLanguage>
                    {
                        new InternshipLanguage { Id = 1, LanguageType = InternshipLanguageType.English, InternshipId = 1, Internship = null },
                        new InternshipLanguage { Id = 3, LanguageType = InternshipLanguageType.French, InternshipId = 1, Internship = null }
                    }
                },
            };
        }

        public List<Internship> GetInternships() 
        {
            return _internships;
        }
    }
}
