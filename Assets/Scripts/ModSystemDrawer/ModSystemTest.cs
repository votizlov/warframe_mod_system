using System;
using ModSystem;
using ModSystem.Gun;
using UnityEngine;

namespace ModSystemDrawer
{
    public class ModSystemTest: MonoBehaviour
    {
        [SerializeField] private ModDrawer _modDrawer;
        [SerializeField] private Stats _stats;
        [SerializeField] private Mod mod;

        private void Start()
        {
            _modDrawer.DrawItem(new ModdableGun());
            _modDrawer.InitStats(_stats);

            foreach (var modImage in FindObjectsOfType<ModImage>())
            {
                modImage.DrawMod(mod);
            }
        }

        public Mod CreateRandomMod()
        {
            return ScriptableObject.CreateInstance<Mod>();
        }
    }
}