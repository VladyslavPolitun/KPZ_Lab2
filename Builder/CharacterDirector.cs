namespace KPZ_Lab2.Builder
{
    public class CharacterDirector
    {
        public Character CreateCharacter(ICharacterBuilder builder)
        {
            builder.SetName();
            builder.SetHeight();
            builder.SetHairColor();
            builder.SetEyeColor();
            builder.SetClothes();
            builder.SetInventory();

            return builder.GetCharacter();
        }
    }
}
