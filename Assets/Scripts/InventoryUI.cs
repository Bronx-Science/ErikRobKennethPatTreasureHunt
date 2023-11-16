using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI clipboardText;
    private SpawnCollectablesScript bScript;

    // Start is called before the first frame update
    void Start()
    {
        clipboardText = GetComponent<TextMeshProUGUI>();

        //This is the script that is attached to the SpawnCollectables game object.
        GameObject g = GameObject.Find("SpawnCollectables");
        bScript = g.GetComponent<SpawnCollectablesScript>();

        //This is the initial clipboard text that is displayed on the UI.
        clipboardText.text = "0/" + bScript.amountOfCollectables.ToString();
    }

    public void UpdateClipboardText(PlayerInventory playerInventory)
    {
        int NumOfCollected = playerInventory.NumberOfClipboards;
        int NumOfNeededCollected = bScript.amountOfCollectables;

        //This is the win condition. If the player collects all the clipboards, they win.
        if (NumOfCollected == NumOfNeededCollected)
        {
            SceneManager.LoadScene(2);
        }

        //This is the clipboard text that is displayed on the UI.
        clipboardText.text = NumOfCollected.ToString() + "/" + NumOfNeededCollected.ToString();
    }
}
