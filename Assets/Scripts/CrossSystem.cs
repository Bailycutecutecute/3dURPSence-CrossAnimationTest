using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSystem : MonoBehaviour
{
    public Animator animator;
    public string[] animations;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        { 
            PlayByIndex(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PlayByIndex(1);

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        { 
            PlayByIndex(2);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayByIndex(3);
        }
    }
    
    public void PlayByIndex(int index)
    { 
        animator.Play(animations[index]);
        animator.speed = 1;
    }

    public void Pause()
    {
        if (animator.speed != 0)
        {
            animator.speed = 0;
        }
        else
        {
            animator.speed = 1;
        }
    }
}
