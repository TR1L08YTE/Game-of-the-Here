using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject Showtime;
    [SerializeField] private GameObject Disapper;
    public Sprite openedSprite;
    public bool IsOpened { get; private set; }

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
    }

    public void SetOpened(bool opened)
    {
        if (IsOpened = opened)
        {
            Showtime.SetActive(true);
            Disapper.SetActive(false);
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
}
