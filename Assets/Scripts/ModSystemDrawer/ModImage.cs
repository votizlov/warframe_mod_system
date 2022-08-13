using UnityEngine;
using UnityEngine.UI;

namespace ModSystemDrawer
{
    public class ModImage : MonoBehaviour
    {
        private Image img;
        void Start()
        {
            img = GetComponent<Image>();
        }

        public void ClearMod()
        {
            img.sprite = null;
        }
    }
}
