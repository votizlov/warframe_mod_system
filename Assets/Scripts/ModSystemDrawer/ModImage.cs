using System;
using ModSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ModSystemDrawer
{
    public class ModImage : MonoBehaviour
    {
        public UnityEvent<ModImage> OnImageSelected = new();
        [SerializeField]
        private Image img;
        [SerializeField]
        private TMP_Text Name;
        [SerializeField]
        private TMP_Text Description;

        void Start()
        {
            img = GetComponent<Image>();
        }

        public void DrawMod(Mod mod)
        {
            img.sprite = mod.sprite;
        }

        public void OnMouseDown()
        {
            OnImageSelected?.Invoke(this);
        }

        public void ClearMod()
        {
            img.sprite = null;
        }
    }
}
