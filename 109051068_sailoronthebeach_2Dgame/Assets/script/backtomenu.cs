using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jay
{
    public class backtomenu : MonoBehaviour
    {
        public void backmenu()
        {
            //�D����������
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}


