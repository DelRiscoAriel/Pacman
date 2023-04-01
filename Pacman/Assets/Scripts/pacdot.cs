using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacdot : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Pacman")
            Destroy (gameObject);
    }
}
