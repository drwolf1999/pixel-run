using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glue : MonoBehaviour
{
    private Transform bombParent;

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            PlayerStat ps = other.gameObject.GetComponent<PlayerStat>();
            ps.adhesive = true;
            gameObject.SetActive(false);
        }
    }
}
