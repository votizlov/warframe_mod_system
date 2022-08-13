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

        private void Start()
        {
            _modDrawer.DrawItem(new ModdableGun());
        }
    }
}