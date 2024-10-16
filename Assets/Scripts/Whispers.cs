using UnityEngine;

public class Whispers : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component
    public GameObject player;        // Reference to the player (to detect when they enter the room)

    // This method is called when another object enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the room is the player
        if (other.gameObject == player)
        {
            // Play the sound effect when the player enters the room
            if (!audioSource.isPlaying)  // Optional: prevent sound from playing again if it's already playing
            {
                audioSource.Play();
            }
        }
    }
}
