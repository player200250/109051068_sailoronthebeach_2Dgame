using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jay 
{
    public class menu : MonoBehaviour
    {
        public void PlaygGame()
        {
            //主菜單場景控制
            SceneManager.LoadScene(SceneManager.GetActiveScene() .buildIndex+1);
        }
    }
}

