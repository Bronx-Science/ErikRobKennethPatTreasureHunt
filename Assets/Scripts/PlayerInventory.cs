using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfClipboards { get; private set; }
    
    public UnityEvent<PlayerInventory> OnClipboardCollected;

    public void ClipboardCollected()
    {
        //When the clipboard is collected, the number of clipboards increases by 1 and is added into an inventory.
        NumberOfClipboards++;
        OnClipboardCollected.Invoke(this);
    }
}
