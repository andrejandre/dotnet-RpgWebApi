using RpgWebApi.Dtos.Weapon;

namespace RpgWebApi.Services;

public interface IWeaponService
{
    Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
}
