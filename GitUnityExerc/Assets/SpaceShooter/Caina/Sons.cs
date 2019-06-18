using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sons : MonoBehaviour
{

    public static Sons sons;
    AudioSource audioSource;

    void Awake()
    {
        if (!sons) {
            sons = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        } else {
            Destroy(gameObject);
        }
    }

    public void TocaOSom (AudioClip som) {
        audioSource.PlayOneShot(som);
    }
}
