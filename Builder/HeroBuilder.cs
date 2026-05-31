namespace KPZ_Lab2.Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character character;

        public HeroBuilder()
        {
            character = new Character();
        }

        public void SetName()
        {
            character.Name = "Arthas";
        }

        public void SetHeight()
        {
            character.Height = "185 cm";
        }

        public void SetHairColor()
        {
            character.HairColor = "Blonde";
        }

        public void SetEyeColor()
        {
            character.EyeColor = "Blue";
        }

        public void SetClothes()
        {
            character.Clothes = "Knight Armor";
        }

        public void SetInventory()
        {
            character.Inventory = "Sword, Shield, Potion";
            character.Alignment = "Good";
        }

        public Character GetCharacter()
        {
            return character;
        }
    }
}
