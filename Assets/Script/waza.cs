using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private Sonidos Entrar;
    [SerializeField] private AudioSource _audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (_audioSource != null && Entrar != null && Entrar.SoundClip != null)
        {
            _audioSource.clip = Entrar.SoundClip;
            _audioSource.Play();
        }
        _audioSource.Stop();
    }

    private void OnTriggerExit(Collider other)
    {
        if (_audioSource != null && Entrar != null && Entrar.SoundClip != null)
        {
            _audioSource.clip = Entrar.SoundClip;
            _audioSource.Play();
        }
    }

}
