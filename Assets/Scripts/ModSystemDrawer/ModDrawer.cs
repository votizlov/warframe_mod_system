using ModSystem;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ModSystemDrawer
{
    public class ModDrawer : MonoBehaviour
    {
        [SerializeField] private ModImage[] modImages;

        [SerializeField] private TMP_Text statsText;

        public void DrawItem(IModdable item)
        {
            
        }

        public void UpdateStats()
        {
            
        }

        public void UpdateMods()
        {
            ClearMods();

            /*foreach (var VARIABLE in item.get)
            {
                
            }*/
        }

        private void ClearMods()
        {
            foreach (var img in modImages)
            {
                img.ClearMod();
            }
        }
    }
}
