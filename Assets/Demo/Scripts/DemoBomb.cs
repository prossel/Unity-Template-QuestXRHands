using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoBomb : MonoBehaviour
{
    // tick sound
    public AudioClip tickSound;
    public AudioClip explosionSound;

    // audio source
    private AudioSource audioSource;

    // rotation speed
    public float rotationSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("PlayTickSound", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
        gameObject.transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);

    }

    // detect collision and dump destroy the collided object
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected");
        Destroy(collision.gameObject);
        PlayExplosionSound();
    }

    // Play tick sound
    void PlayTickSound()
    {
        audioSource.PlayOneShot(tickSound);
    }

    // Play explosion sound
    void PlayExplosionSound()
    {
        audioSource.PlayOneShot(explosionSound);
    }
}
