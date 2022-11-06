using UnityEngine;

namespace Jay 
{

    /// <summary>
    /// 玩家發射系統
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
