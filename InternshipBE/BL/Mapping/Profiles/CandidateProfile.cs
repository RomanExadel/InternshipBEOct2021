using AutoMapper;
using BL.DTOs.CandidateDTOs;
using DAL.Entities;
using Shared.Config.Interfaces;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using static Shared.Constants.ImportFileOffsets;

namespace BL.Mapping.Profiles
{
    public class CandidateProfile : Profile
	{
		private readonly IGoogleConfig _googleSheetConfig;

		public CandidateProfile(IGoogleConfig googleSheetConfig)
		{
			_googleSheetConfig = googleSheetConfig;
		}

		public CandidateProfile()
		{
			CreateMap<IList<object>, CandidateDTO>()
				.ForMember(e => e.FirstName, source => source.MapFrom(s => s[FIRST_NAME_OFFSET].ToString()))
				.ForMember(e => e.LastName, source => source.MapFrom(s => s[LAST_NAME_OFFSET].ToString()))
				.ForMember(e => e.RegistrationDate, source => source
					.MapFrom(s => DateTime.ParseExact(s[REGISTRATION_DATE_OFFSET].ToString(), _googleSheetConfig.DateTimeFormat, CultureInfo.InvariantCulture)))
				.ForMember(e => e.Email, source => source.MapFrom(s => s[EMAIL_OFFSET].ToString()))
				.ForMember(e => e.Location, source => source.MapFrom(s => s[LOCATION_OFFSET].ToString()))
				.ForMember(e => e.Phone, source => source.MapFrom(s => s[PHONE_OFFSET].ToString()))
				.ForMember(e => e.Skype, source => source.MapFrom(s => s[SKYPE_OFFSET].ToString()))
				.ForMember(e => e.StackType, source => source.MapFrom(s => Enum.Parse<Shared.Enums.StackType>(s[STACK_OFFSET].ToString())))
				.ForMember(e => e.EnglishLevelType, source => source.MapFrom(s => Enum.Parse<Shared.Enums.EnglishLevelType>(s[ENGLISH_LEVEL_OFFSET].ToString())))
				.ForMember(e => e.Education, source => source.MapFrom(s => s[EDUCATION_OFFSET].ToString()))
				.ForMember(e => e.Links, source => source.MapFrom(s => s[LINKS_OFFSET].ToString()))
				.ForMember(e => e.CurrentJob, source => source.MapFrom(s => s[CURRENT_JOB_OFFSET].ToString()))
				.ForMember(e => e.ProfessionalCertificates, source => source.MapFrom(s => s[PROFESSIONAL_CERTIFICATES_OFFSET].ToString()))
				.ForMember(e => e.OtherInfo, source => source.MapFrom(s => s[OTHER_INFO_OFFSET].ToString()))
				.ForMember(e => e.IsPlanningToJoin, source => source.MapFrom(s => s[IS_PLANNING_TO_JOIN_OFFSET].ToString().ToLower() == "yes" ? true : false))
				.ForMember(e => e.PrimarySkill, source => source.MapFrom(s => s[PRIMARY_SKILL_OFFSET].ToString()))
				.ForMember(e => e.BestContactTime, source => source.MapFrom(s => DateTime.Parse(s[BEST_CONTACT_TIME_OFFSET].ToString())))
				.ForMember(e => e.InternshipId, source => source.MapFrom(s => Convert.ToInt32(s[INTERNSHIP_OFFSET].ToString().Substring(0, 1))))
				.ForAllOtherMembers(x => x.Ignore());

			CreateMap<CandidateDTO, Candidate>()
				.ForMember(entity => entity.EnglishLevelType, src => src.MapFrom(dto => Enum.Parse<EnglishLevelType>(dto.EnglishLevelType)))
				.ForMember(entity => entity.StackType, src => src.MapFrom(dto => Enum.Parse<StackType>(dto.StackType)))
				.ForMember(entity => entity.StatusType, src => src.MapFrom(dto => Enum.Parse<CandidateStatusType>(dto.StatusType)))
				.ForMember(x => x.TestTaskEvaluation, o => o.Ignore())
				.ForMember(x => x.TeamId, o => o.Ignore())
				.ForMember(x => x.Team, o => o.Ignore())
				.ForMember(x => x.Users, o => o.Ignore())
				.ForMember(x => x.Internship, o => o.Ignore())
				.ReverseMap()
				.ForMember(dto => dto.EnglishLevelType, src => src.MapFrom(entity => entity.EnglishLevelType.ToString()))
				.ForMember(dto => dto.StackType, src => src.MapFrom(entity => entity.StackType.ToString()))
				.ForMember(dto => dto.StatusType, src => src.MapFrom(entity => entity.StatusType.ToString()));
		}
	}
}
