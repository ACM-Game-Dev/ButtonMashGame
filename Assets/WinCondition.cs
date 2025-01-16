using Unity.VisualScripting;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "PlayerOne"){
            Debug.Log("Player One Wins!");
        }
        else if (other.gameObject.tag == "PlayerTwo"){
            Debug.Log("Player Two Wins!");
        }
    }
}
