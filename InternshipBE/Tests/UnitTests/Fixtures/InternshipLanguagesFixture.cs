using DAL.Entities;
using Shared.Enums;
using System.Collections.Generic;

namespace Tests.UnitTests.Fixtures
{
    public class InternshipLanguagesFixture
    {
        private readonly List<Internship> _internships;
        private readonly List<InternshipLanguage> _internshipLanguages;

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

            _internshipLanguages = new List<InternshipLanguage> 
            {
                new InternshipLanguage {Id = 1, InternshipId = 1, LanguageType = InternshipLanguageType.English },
                new InternshipLanguage {Id = 2, InternshipId = 0, LanguageType = InternshipLanguageType.German },
            };
        }

        public List<Internship> GetInternships() 
        {
            return _internships;
        }

        public List<InternshipLanguage> GetInternshipLanguages() 
        {
            return _internshipLanguages;
        }
    }
}
