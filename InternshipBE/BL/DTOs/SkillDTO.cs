using Shared.Enums;

namespace BL.DTOs
{
    public class SkillDTO
    {
        public int Id { get; set; }

        public StackType StackType { get; set; }

        public string Name { get; set; }

        public bool IsHardSkill { get; set; }
    }
}
