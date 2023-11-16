using UnityEngine;
using System.Collections;

public class Clipboard : MonoBehaviour
{
    //This is the function that is called when the player collides with the clipboard.
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.ClipboardCollected();
            StartCoroutine(goAway());
            GetComponent<AudioSource>().Play();
        }
    }
    //This is the function that makes the clipboard disappear after 1 second.
    private IEnumerator goAway()
    {
        yield return new WaitForSeconds(1.0f);
        gameObject.SetActive(false);
    }
}

