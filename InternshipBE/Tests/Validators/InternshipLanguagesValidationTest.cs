﻿using Tests.Fixtures;
using WebApi.Validators;
using Xunit;

namespace Tests.Validators
{
    public class InternshipLanguagesValidationTest
    {
        private readonly InternshipLanguagesFixture _languagesFixture;

        public InternshipLanguagesValidationTest()
        {
            _languagesFixture = new InternshipLanguagesFixture();
        }

        [Fact]
        public async void InternshipLanguagesValidator_IfIncorrectData_ThenThrowsException()
        {
            // arrange
            var internshipLanguages = _languagesFixture.GetInternshipLanguages();
            var validator = new InternshipLanguagesValidator();

            // act
            var result = await validator.ValidateAsync(internshipLanguages[1]);

            // assert
            Assert.False(result.IsValid);
        }
               // I know DRY (for Roma) Ento vso Zeny. Ego Bei
        [Fact]
        public async void InternshipLanguagesValidator_IfCorrectData_ThenThrowsException()
        {
            // arrange
            var internshipLanguages = _languagesFixture.GetInternshipLanguages();
            var validator = new InternshipLanguagesValidator();

            // act
            var result = await validator.ValidateAsync(internshipLanguages[0]);

            // assert
            Assert.True(result.IsValid);
        }
    }
}
