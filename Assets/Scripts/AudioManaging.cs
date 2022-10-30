using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManaging : MonoBehaviour
{
    [SerializeField]
    AudioSource intro;

    [SerializeField]
    AudioSource ghostNormal;



    void Start()
    {
        StartCoroutine(introPlayOrder());
        
    }

    void Update()
    {
        
    }

    IEnumerator introPlayOrder()
    {
        intro.Play();
        yield return new WaitForSeconds(intro.clip.length);
        ghostNormal.Play();

    }
}
