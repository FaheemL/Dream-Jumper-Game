using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    public PlayerController player;
    private void OnTriggerEnter2D(Collider2D collision) {
    if ((collision.tag == "Player") && (collision.name != "Ground detector")) {
        collision.gameObject.transform.SetParent(transform);
    }

   }

    private void OnTriggerExit2D(Collider2D collision) {
    if ((collision.tag == "Player") && (collision.name != "Ground detector")) {

        collision.gameObject.transform.SetParent(null);
        player.editJumpCount(0);

   }
}
}
