using UnityEngine;
public class WinUI : MonoBehaviour
{
    [SerializeField] private GameObject NahIWin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            NahIWin.SetActive(true);
            Time.timeScale = 0;
        }
    }
}