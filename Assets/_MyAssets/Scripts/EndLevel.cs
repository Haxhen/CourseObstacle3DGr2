using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        int noScene = SceneManager.GetActiveScene().buildIndex;
        if (noScene < SceneManager.sceneCountInBuildSettings -1 )
        {
            SceneManager.LoadScene(noScene + 1);

        }
        else
        {
            Debug.Log("FINITO PEPITO");
            Debug.Log("Collisions total :" + GameManager.Instance.NbCollision);
            Debug.Log("Temps :" + GameManager.Instance.);

        }
    }

}