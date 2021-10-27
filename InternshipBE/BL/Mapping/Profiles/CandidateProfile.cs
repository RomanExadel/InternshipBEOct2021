using AutoMapper;
using BL.DTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using static Shared.Constants.ImportFileOffsets;


namespace BL.Mapping.Profiles
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile()
        {
			CreateMap<IList<object>, CandidateDTO>()
				.ForMember(e => e.FirstName, source => source.MapFrom(s => s[FIRST_NAME_OFFSET].ToString()))
				.ForMember(e => e.LastName, source => source.MapFrom(s => s[LAST_NAME_OFFSET].ToString()))
				.ForMember(e => e.RegistationDate, source => source
					.MapFrom(s => DateTime.ParseExact(s[REGISTRATION_DATE_OFFSET].ToString(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture)))
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
				.ForMember(e => e.BestContactTime, source => source.MapFrom(s => DateTime.Parse(s[BEST_CONTACT_TIME_OFFSET].ToString())));

			CreateMap<CandidateDTO, Candidate>()
				.ForPath(x => x.FirstName, o => o.MapFrom(src => src.FirstName))
				.ForPath(x => x.LastName, o => o.MapFrom(src => src.LastName))
				.ForPath(x => x.Email, o => o.MapFrom(src => src.Email))
				.ForPath(x => x.Education, o => o.MapFrom(src => src.Education))
				.ForPath(x => x.Location, o => o.MapFrom(src => src.Location))
				.ForPath(x => x.EnglishLevelType, o => o.MapFrom(src => src.EnglishLevelType))
				.ForPath(x => x.BestContactTime, o => o.MapFrom(src => src.BestContactTime))
				.ForPath(x => x.CurrentJob, o => o.MapFrom(src => src.CurrentJob))
				.ForPath(x => x.RegistationDate, o => o.MapFrom(src => src.RegistationDate))
				.ForPath(x => x.IsPlanningToJoin, o => o.MapFrom(src => src.IsPlanningToJoin))
				.ForPath(x => x.Links, o => o.MapFrom(src => src.Links))
				.ForPath(x => x.Phone, o => o.MapFrom(src => src.Phone))
				.ForPath(x => x.PrimarySkill, o => o.MapFrom(src => src.PrimarySkill))
				.ForPath(x => x.ProfessionalCertificates, o => o.MapFrom(src => src.ProfessionalCertificates))
				.ForPath(x => x.Skype, o => o.MapFrom(src => src.Skype))
				.ForPath(x => x.StackType, o => o.MapFrom(src => src.StackType))
				.ForPath(x => x.OtherInfo, o => o.MapFrom(src => src.OtherInfo))
				.ForAllOtherMembers(x => x.Ignore());
        }
    }
}
