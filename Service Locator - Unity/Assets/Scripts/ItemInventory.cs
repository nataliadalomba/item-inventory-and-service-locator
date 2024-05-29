using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class ItemInventory : MonoBehaviour {
    public Item[] slots;
    public GameObject slotPrefab;
    public Transform gridParent; //reference to GridLayoutGroup's transform

    private void Start() {
        PopulateGrid();
    }

    private void PopulateGrid() {
        if (slotPrefab == null) {
            Debug.LogError("Slot prefab is not assigned");
            return;
        }

        if (gridParent == null) {
            Debug.LogError("Grid parent is not assigned");
            return;
        }

        for (int i = 0; i < slots.Length; i++) {
            GameObject slot = Instantiate(slotPrefab, gridParent);
            Debug.Log("Instantiated slot: " + i);

            Item item = slots[i];
            if (item != null) {
                Image image = slot.GetComponent<Image>();
                if (image != null && item.itemSprite != null)
                    image.sprite = item.itemSprite;

                TextMeshProUGUI itemText = slot.GetComponentInChildren<TextMeshProUGUI>();
                if (itemText != null)
                    itemText.text = item.itemName;
            }
        }
    }
}
