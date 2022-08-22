using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageNumber : MonoBehaviour
{
    [SerializeField] private float _destroyDelay = 0.5f;
    void Start()
    {
        StartCoroutine(DestroyAfter(_destroyDelay));
    }

    IEnumerator DestroyAfter(float t)
    {
        yield return new WaitForSeconds(t);
        Destroy(gameObject);
    }
}
