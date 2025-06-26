using System;
using System.Collections;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private int currentIdle = 0;
    private string currentAnimation = "";

    private string[] animationNames = new string[]
    {
        "Male_Idle_Neutral_1",  // Idle breve
        "fight_Preparation",    // Acción más larga
        "Male_Idle_Neutral_2",  // Idle breve
        "dancing_2"             // Acción más larga
    };

    private float[] animationDurations = new float[]
    {
        5f,     // Idle 1 (acortada)
        7.5f,   // Preparación (original o un poco más)
        6f,     // Idle 2 (acortada)
        10f     // Dancing (más tiempo)
    };

    void Start()
    {
        StartCoroutine(PlayIdleCycle());
    }

    IEnumerator PlayIdleCycle()
    {
        while (true)
        {
            string anim = animationNames[currentIdle];
            float duration = animationDurations[currentIdle];

            ChangeAnimation(anim);
            yield return new WaitForSeconds(duration);

            currentIdle = (currentIdle + 1) % animationNames.Length;
        }
    }

    private void ChangeAnimation(string animation, float crossfade = 0.04f)
    {
        if (currentAnimation != animation)
        {
            GetComponent<Animator>().CrossFade(animation, crossfade);
            currentAnimation = animation;
        }
    }
}
