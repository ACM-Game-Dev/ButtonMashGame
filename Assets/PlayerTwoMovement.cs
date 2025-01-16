
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public float movementPerClick = 0.1f;

    bool change = false;
    [SerializeField] Sprite redRun0;
    [SerializeField] Sprite redRun1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)){
            if (change){
                GetComponent<SpriteRenderer>().sprite = redRun0;
                change = false;
            }
            else{
                GetComponent<SpriteRenderer>().sprite = redRun1;
                change = true;
            }
            transform.position += new Vector3(movementPerClick,0,0);
        }
    }
}
