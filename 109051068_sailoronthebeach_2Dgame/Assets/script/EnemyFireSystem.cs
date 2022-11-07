using UnityEngine;

namespace Jay 
{
    /// <summary>
    /// �ĤH�o�g�t��
    /// </summary>
    public class EnemyFireSystem : FiresSystemBase
    {
        [SerializeField, Header("�ͦ��l�u���j"), Range(0, 50)]
        private float interval = 1.5f;
        private void Awake()
        {
            //�I�s��k
            //SpwanShoot();

            //���𭫽ƩI�s("��k�W��", ����ɶ� ,�����W�v)
            InvokeRepeating("SpwanShoot", 5, interval);
        }
    }
}

