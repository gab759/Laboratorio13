using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    private Animator _compAnimator;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.CompareTag("Bullet") == true)
        {
            _compAnimator.SetTrigger("IsDeath");
            Destroy(this.gameObject, 0.8f);
        }
    }
}
