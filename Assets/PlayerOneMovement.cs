
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour
{
    public float movementPerClick = 0.1f;

    bool change = false;
    [SerializeField] Sprite blueRun0;
    [SerializeField] Sprite blueRun1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            if (change){
                GetComponent<SpriteRenderer>().sprite = blueRun0;
                change = false;
            }
            else{
                GetComponent<SpriteRenderer>().sprite = blueRun1;
                change = true;
            }
            transform.position += new Vector3(movementPerClick,0,0);
        }
    }
}
