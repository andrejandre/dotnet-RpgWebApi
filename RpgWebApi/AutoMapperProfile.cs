using RpgWebApi.Dtos.Fight;
using RpgWebApi.Dtos.Skill;
using RpgWebApi.Dtos.Weapon;

namespace RpgWebApi;

public class AutoMapperProfile : Profile 
{
    public AutoMapperProfile()
    {
        CreateMap<Character, GetCharacterDto>();
        CreateMap<AddCharacterDto, Character>();
        CreateMap<UpdateCharacterDto, Character>();
        CreateMap<Weapon, GetWeaponDto>();
        CreateMap<GetWeaponDto, Weapon>();
        CreateMap<Skill, GetSkillDto>();
        CreateMap<Character, HighscoreDto>();
    }
}
