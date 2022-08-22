using System;
using UnityEngine;

namespace AttackSystem
{
    public class DamagableObject : MonoBehaviour
    {
        [SerializeField] private GameObject canvas;
        [SerializeField] private GameObject text;

        private void OnTriggerEnter(Collider other)
        {
                Debug.Log(other.gameObject.layer);
                if(other.gameObject.layer == 6)
                    Debug.Log(gameObject.name + " DAMAGEd");
                Vector2 screenPosition = Camera.main.WorldToScreenPoint(other.transform.position);

                Instantiate(text, transform.position, Quaternion.identity, canvas.transform);

        }
    }
}
