using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ToggleAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause(); // Jika audio sedang diputar, berhenti
        }
        else
        {
            audioSource.Play(); // Jika tidak, mulai memainkan audio
        }
    }
}
