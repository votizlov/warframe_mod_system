using System;
using System.Collections.Generic;
using UnityEngine;

namespace AttackSystem
{
    public class AttackManager : MonoBehaviour
    {
        [SerializeField] private List<GameObject> attackPrefabs;
        public static AttackManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        public void Attack(AttackingObject attackingObject)
        {
            switch (attackingObject.AttackType)
            {
                case 0: Instantiate(attackPrefabs[0],attackingObject.AttackRoot.transform);
                    break;
            }
        }
    }
}
