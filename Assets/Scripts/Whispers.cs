using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        // Check if the player enters the trigger
        if (other.CompareTag("Player"))
        {
            // Play the sound
            audioSource.Play();
        }
    }
}
