using System;
using UnityEngine;

namespace AttackSystem
{
    public class AttackingObject : MonoBehaviour
    {
        [SerializeField] private GameObject attackRoot;
        [SerializeField] private int _attackType;

        public GameObject AttackRoot => attackRoot;

        public int AttackType => _attackType;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
            }
        }

        public void Attack()
        {
            AttackManager.Instance.Attack(this);
        }
    }
}
