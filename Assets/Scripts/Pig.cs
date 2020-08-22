using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collider = collision.gameObject;

        if (collider.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(collider);
        }
    }
}
