
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementPerClick = 0.1f;

    [SerializeField] KeyCode key;

    bool change = false;
    [SerializeField] Sprite run0;
    [SerializeField] Sprite run1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key)){
            if (change){
                GetComponent<SpriteRenderer>().sprite = run0;
                change = false;
            }
            else{
                GetComponent<SpriteRenderer>().sprite = run1;
                change = true;
            }
            transform.position += new Vector3(movementPerClick,0,0);
        }
    }
}
