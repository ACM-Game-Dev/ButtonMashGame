
using UnityEngine;
using UnityEngine.SceneManagement;

public class RematchButton : MonoBehaviour
{

    public void Rematch(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
