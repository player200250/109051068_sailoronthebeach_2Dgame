using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jay
{
    public class backtomenu : MonoBehaviour
    {
        public void backmenu()
        {
            //主菜單場景控制
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}


