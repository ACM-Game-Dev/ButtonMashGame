using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winText;

    void OnTriggerEnter2D(Collider2D other){
        winText.gameObject.SetActive(true);
        winText.text = other.gameObject.name + " wins!";
    }
}
