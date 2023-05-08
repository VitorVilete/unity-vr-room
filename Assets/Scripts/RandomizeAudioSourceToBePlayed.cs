using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeAudioSourceToBePlayed : MonoBehaviour
{
    public AudioSource[] AudioSourcesToBePlayed;
    // Start is called before the first frame update
    void Start()
    {
        InvokePlay();
    }

    // Update is called once per frame
    void InvokePlay()
    {
        Invoke("PlayRandomAudioSource", 5);
    }

    void PlayRandomAudioSource()
    {
        int asIndex = Random.Range(0, AudioSourcesToBePlayed.Length);
        AudioSourcesToBePlayed[asIndex].Play();
        InvokePlay();
    }
}
