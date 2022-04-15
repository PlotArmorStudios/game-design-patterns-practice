using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseAnimatorExtensionMethod : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _animator.SetUpdateMode();
        }
    }
}
