namespace KPZ_Lab2.Builder
{
    public interface ICharacterBuilder
    {
        void SetName();
        void SetHeight();
        void SetHairColor();
        void SetEyeColor();
        void SetClothes();
        void SetInventory();

        Character GetCharacter();
    }
}
