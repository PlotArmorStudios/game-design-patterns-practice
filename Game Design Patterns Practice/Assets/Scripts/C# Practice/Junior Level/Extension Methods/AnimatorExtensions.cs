using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimatorExtensions
{
    public static void SetUpdateMode(this Animator animator)
    {
        animator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }
}
