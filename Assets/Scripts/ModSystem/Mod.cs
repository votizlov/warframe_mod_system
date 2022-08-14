using UnityEngine;

namespace ModSystem
{
    [CreateAssetMenu(fileName = "ModData", menuName = "ScriptableObjects/Mods", order = 2)]
    public class Mod : ScriptableObject
    {
        public Sprite sprite;
        public string name;
        public int currentLevel;
        public int maxLevel;
        private ModType modType;
        public Stats.Stat[] fields;

        public Mod(Sprite sprite, string name, int currentLevel, int maxLevel, ModType modType, Stats.Stat[] fields)
        {
            this.sprite = sprite;
            this.name = name;
            this.currentLevel = currentLevel;
            this.maxLevel = maxLevel;
            this.modType = modType;
            this.fields = fields;
        }
    }
}
