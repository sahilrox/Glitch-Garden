using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batterfly : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collider = collision.gameObject;

        if (collider.GetComponent<Shooter>())
        {
            GetComponent<Attacker>().Attack(collider);
        }
    }
}
