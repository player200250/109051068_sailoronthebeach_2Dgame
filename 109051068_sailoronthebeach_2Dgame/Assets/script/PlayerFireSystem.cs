using UnityEngine;

namespace Jay 
{

    /// <summary>
    /// ���a�o�g�t��
    /// </summary>
    public class PlayerFireSystem : FiresSystemBase
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                SpwanShoot();
            }
        }
    }
}
