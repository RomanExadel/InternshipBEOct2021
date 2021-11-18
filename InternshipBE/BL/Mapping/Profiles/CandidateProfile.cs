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
				.ForMember(e => e.RegistrationDate, source => source.MapFrom(s => DateTime.Parse(s[REGISTRATION_DATE_OFFSET].ToString(), new CultureInfo("ru-RU"))))
				.ForMember(e => e.Email, source => source.MapFrom(s => s[EMAIL_OFFSET].ToString()))
				.ForMember(e => e.Location, source => source.MapFrom(s => s[LOCATION_OFFSET].ToString()))
				.ForMember(e => e.Phone, source => source.MapFrom(s => s[PHONE_OFFSET].ToString()))
				.ForMember(e => e.Skype, source => source.MapFrom(s => s[SKYPE_OFFSET].ToString()))
				.ForMember(e => e.StackType, source => source.MapFrom(s => Enum.Parse<StackType>(s[STACK_OFFSET].ToString())))
				.ForMember(e => e.EnglishLevelType, source => source.MapFrom(s => Enum.Parse<EnglishLevelType>(s[ENGLISH_LEVEL_OFFSET].ToString())))
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

			CreateMap<Candidate, CandidateDTO>()
				.ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
				.ForMember(dto => dto.RegistrationDate, src => src.MapFrom(entity => entity.RegistrationDate))
				.ForMember(dto => dto.Email, src => src.MapFrom(entity => entity.Email))
				.ForMember(dto => dto.FirstName, src => src.MapFrom(entity => entity.FirstName))
				.ForMember(dto => dto.LastName, src => src.MapFrom(entity => entity.LastName))
				.ForMember(dto => dto.Location, src => src.MapFrom(entity => entity.Location))
				.ForMember(dto => dto.Phone, src => src.MapFrom(entity => entity.Phone))
				.ForMember(dto => dto.Skype, src => src.MapFrom(entity => entity.Skype))
				.ForMember(dto => dto.StackType, src => src.MapFrom(entity => entity.StackType.ToString()))
				.ForMember(dto => dto.EnglishLevelType, src => src.MapFrom(entity => entity.EnglishLevelType.ToString()))
				.ForMember(dto => dto.Education, src => src.MapFrom(entity => entity.Education))
				.ForMember(dto => dto.Links, src => src.MapFrom(entity => entity.Links))
				.ForMember(dto => dto.OtherInfo, src => src.MapFrom(entity => entity.OtherInfo))
				.ForMember(dto => dto.PrimarySkill, src => src.MapFrom(entity => entity.PrimarySkill))
				.ForMember(dto => dto.CurrentJob, src => src.MapFrom(entity => entity.CurrentJob))
				.ForMember(dto => dto.ProfessionalCertificates, src => src.MapFrom(entity => entity.ProfessionalCertificates))
				.ForMember(dto => dto.IsPlanningToJoin, src => src.MapFrom(entity => entity.IsPlanningToJoin))
				.ForMember(dto => dto.TestTaskEvaluation, src => src.MapFrom(entity => entity.TestTaskEvaluation))
				.ForMember(dto => dto.StatusType, src => src.MapFrom(entity => entity.StatusType.ToString()))
				.ForMember(dto => dto.InternshipId, src => src.MapFrom(entity => entity.InternshipId))
				.ForMember(dto => dto.TeamId, src => src.MapFrom(entity => entity.TeamId))
				.ForMember(dto => dto.Users, src => src.MapFrom(entity => entity.Users))
				.ForAllOtherMembers(x => x.Ignore());

			CreateMap<CandidateDTO, Candidate>()
				.ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
				.ForMember(entity => entity.FirstName, src => src.MapFrom(dto => dto.FirstName))
				.ForMember(entity => entity.LastName, src => src.MapFrom(dto => dto.LastName))
				.ForMember(entity => entity.Location, src => src.MapFrom(dto => dto.Location))
				.ForMember(entity => entity.Phone, src => src.MapFrom(dto => dto.Phone))
				.ForMember(entity => entity.Email, src => src.MapFrom(dto => dto.Email))
				.ForMember(entity => entity.Skype, src => src.MapFrom(dto => dto.Skype))
				.ForMember(entity => entity.Education, src => src.MapFrom(dto => dto.Education))
				.ForMember(entity => entity.Links, src => src.MapFrom(dto => dto.Links))
				.ForMember(entity => entity.OtherInfo, src => src.MapFrom(dto => dto.OtherInfo))
				.ForMember(entity => entity.PrimarySkill, src => src.MapFrom(dto => dto.PrimarySkill))
				.ForMember(entity => entity.CurrentJob, src => src.MapFrom(dto => dto.CurrentJob))
				.ForMember(entity => entity.ProfessionalCertificates, src => src.MapFrom(dto => dto.ProfessionalCertificates))
				.ForMember(entity => entity.BestContactTime, src => src.MapFrom(dto => dto.BestContactTime))
				.ForMember(entity => entity.TestTaskEvaluation, src => src.MapFrom(dto => dto.TestTaskEvaluation))
				.ForMember(entity => entity.StatusType, src => src.MapFrom(dto => Enum.Parse<CandidateStatusType>(dto.StatusType)))
				.ForMember(entity => entity.StackType, src => src.MapFrom(dto => Enum.Parse<StackType>(dto.StackType)))
				.ForMember(entity => entity.EnglishLevelType, src => src.MapFrom(dto => Enum.Parse<EnglishLevelType>(dto.EnglishLevelType)))
				.ForMember(entity => entity.IsPlanningToJoin, src => src.MapFrom(dto => dto.IsPlanningToJoin))
				.ForMember(entity => entity.RegistrationDate, src => src.MapFrom(dto => dto.RegistrationDate))
				.ForMember(entity => entity.InternshipId, src => src.MapFrom(dto => dto.InternshipId))
				.ForMember(entity => entity.TeamId, src => src.MapFrom(dto => dto.TeamId))
				.ForAllOtherMembers(x => x.Ignore());
		}
	}
}
