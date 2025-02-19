using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winText;

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "PlayerOne"){
            Debug.Log("Player One Wins!");
            winText.gameObject.SetActive(true);
            winText.text = "Player One Wins!";
        }
        else if (other.gameObject.tag == "PlayerTwo"){
            Debug.Log("Player Two Wins!");
            winText.gameObject.SetActive(true);
            winText.text = "Player Two Wins!";
        }
    }
}
