using System;
using ModSystem;
using UnityEngine;
using TMPro;

namespace ModSystemDrawer
{
    public class ModDrawer : MonoBehaviour
    {
        [SerializeField] private ModImage[] modImages;

        [SerializeField] private TMP_Text statsText;
        
        private bool _isHoldingMod = false;
        private ModImage _selectedImage;
        private Stats _currentStats;

        private void Start()
        {
            foreach (var modImage in modImages)
            {
                modImage.OnImageSelected.AddListener(OnImageSelected);
            }
        }

        private void Update()
        {
            if (_isHoldingMod)
            {
                if (!Input.GetMouseButton(0))
                {
                    _isHoldingMod = false;
                    return;
                }
                //todo place mod from inventory to item, move within item, place from item to inventory;
                _selectedImage.transform.position = Input.mousePosition;
            }
        }

        private void OnImageSelected(ModImage selectedImage)
        {
            if (_isHoldingMod) return;

            this._selectedImage = selectedImage;
            _isHoldingMod = true;
        }

        public void DrawItem(IModdable item)
        {
            
        }

        public void InitStats(Stats s)
        {
            this._currentStats = s;
            UpdateStats();
        }

        private void UpdateStats()
        {
            string newStatsText = String.Empty;
            foreach (var stat in _currentStats.fields)
            {
                newStatsText += stat.name + " " + stat.value;
                newStatsText += "\n";
            }

            statsText.text = newStatsText;
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
