using BL.EqualityComparers;
using BL.Interfaces;
using BL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using Tests.UnitTests.Fixtures;
using Xunit;

namespace Tests.UnitTests.Services
{
    public class InternshipLanguagesServiceTest
    {
        private readonly Mock<IUnitOfWork> _uowMock;
        private readonly IInternshipLanguagesService _internshipLanguagesService;
        private readonly InternshipLanguagesFixture _internshipLanguagesFixture;

        public InternshipLanguagesServiceTest()
        {
            _uowMock = new Mock<IUnitOfWork>();
            _internshipLanguagesService = new InternshipLanguagesService(_uowMock.Object);
            _internshipLanguagesFixture = new InternshipLanguagesFixture();
        }

        [Fact]
        public async void CreateOrDeleteLanguagesAsync_IfNewLanguagesCountMoreOrEquelOldLanguagesCount_CreateLanguages()
        {
            // arrange
            var internshipLanguagesFixture = _internshipLanguagesFixture.GetInternships();
            var newInternship = internshipLanguagesFixture[0];
            var oldInternship = internshipLanguagesFixture[1];

            var expected = internshipLanguagesFixture[0];

            _uowMock.Setup(x => x.InternshipLanguages.CreateOrDeleteLanguagesAsync(It.IsAny<Internship>(), It.IsAny<Internship>()))
                .ReturnsAsync(newInternship);

            // act
            var actual = await _internshipLanguagesService.CreateOrDeleteLanguagesAsync(oldInternship, newInternship);

            // assert
            Assert.Equal(expected, actual, new InternshipLanguagesEqualityComparer());
        }
    }
}
