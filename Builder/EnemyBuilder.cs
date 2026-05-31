namespace KPZ_Lab2.Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character character;

        public EnemyBuilder()
        {
            character = new Character();
        }

        public void SetName()
        {
            character.Name = "Diablo";
        }

        public void SetHeight()
        {
            character.Height = "210 cm";
        }

        public void SetHairColor()
        {
            character.HairColor = "Black";
        }

        public void SetEyeColor()
        {
            character.EyeColor = "Red";
        }

        public void SetClothes()
        {
            character.Clothes = "Dark Armor";
        }

        public void SetInventory()
        {
            character.Inventory = "Axe, Fire Magic";
            character.Alignment = "Evil";
        }

        public Character GetCharacter()
        {
            return character;
        }
    }
}
