using UnityEngine;



namespace Jay 
{

    /// <summary>
    /// �o�g�t�ΰ�
    /// </summary>
    public class FiresSystemBase : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabshoot;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointspawn;

        //�ۭq��k
        //�ͦ��l�u
        //�O�s�ŧO:���\�l���O�s��
        protected void SpwanShoot() 
        {
            //��O��(�ͦ�����,�y��,����)
            //�ͦ� �l�u�w�s�� �y�лP���׸�ͦ��I�ۦP
             
            Instantiate(prefabshoot, pointspawn.position, pointspawn.rotation);
        }
    }
}