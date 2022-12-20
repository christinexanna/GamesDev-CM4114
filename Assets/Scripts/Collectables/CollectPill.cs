using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPill : MonoBehaviour
{
    public AudioSource redpillFX;

    void OnTriggerEnter(Collider other)
    {
        redpillFX.Play();
        this.gameObject.SetActive(false); // when player collides with pill play sound effect

    }
}
