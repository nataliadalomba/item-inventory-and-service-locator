using UnityEngine;

public class GameController : MonoBehaviour {
    private ItemInventory itemInventory;

    private void Start() {
        itemInventory = ServiceLocator.Instance.GetSystem<ItemInventory>();

        if (itemInventory != null)
            itemInventory.PrintMessage();
        else
            Debug.LogError(nameof(itemInventory) + " not found!");
    }
}