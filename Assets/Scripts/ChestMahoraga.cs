using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestMahoraga : MonoBehaviour, IInteractable
{
    [Header("Mahoraga")]
    [SerializeField] private AudioClip Mahoraga;
    [SerializeField] private GameObject Wall;

    public bool IsOpened { get; private set; }
    public string ChestID { get; private set; }
    public GameObject itemPrefab;
    public Sprite openedSprite;

    void Start()
    {
        ChestID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }


    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenChest();
    }
    private void OpenChest()
    {
        SetOpened(true);

        if (itemPrefab)
        {
            GameObject droppedItem = Instantiate(itemPrefab, transform.position + Vector3.up, Quaternion.identity);
            SoundManager.instance.StopMusicBGM();
            SoundManager.instance.PlaySound(Mahoraga);
        }
    }

    public void SetOpened(bool opened)
    {
        if (IsOpened = opened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
            Wall.SetActive(false);
        }
    }
}
