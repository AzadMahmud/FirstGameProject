using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameHasEnded = false;
    public float restartDelay = 2f;  
   public void EndGame()
    {
        if(gameHasEnded==false){
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
    }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
