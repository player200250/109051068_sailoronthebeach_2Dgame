using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jay 
{
    public class menu : MonoBehaviour
    {
        public void PlaygGame()
        {
            //�D����������
            SceneManager.LoadScene(SceneManager.GetActiveScene() .buildIndex+1);
        }
    }
}

