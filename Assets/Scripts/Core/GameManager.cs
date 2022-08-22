using System;
using ModSystemDrawer;
using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private ModDrawer _modDrawer;
        [SerializeField] private FirstPersonLook _firstPersonLook;
        [SerializeField] private FirstPersonMovement _firstPersonMovement;
        void Start()
        {
            DontDestroyOnLoad(this);
            
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                var b = _modDrawer.gameObject.activeSelf;
                _modDrawer.gameObject.SetActive(!b);
                _firstPersonLook.CanLook = b;
                _firstPersonMovement.CanMove = b;
            }
        }

        private void InitSystems()
        {
            
        }
    }
}
