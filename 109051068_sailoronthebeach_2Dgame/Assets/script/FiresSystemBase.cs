using UnityEngine;



namespace Jay 
{

    /// <summary>
    /// 發射系統基底
    /// </summary>
    public class FiresSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabshoot;
        [SerializeField, Header("子彈生成點")]
        private Transform pointspawn;

        //自訂方法
        //生成子彈
        //保存級別:允許子類別存取
        protected void SpwanShoot() 
        {
            //實力化(生成角度,座標,角度)
            //生成 子彈預製物 座標與角度跟生成點相同
             
            Instantiate(prefabshoot, pointspawn.position, pointspawn.rotation);
        }
    }
}