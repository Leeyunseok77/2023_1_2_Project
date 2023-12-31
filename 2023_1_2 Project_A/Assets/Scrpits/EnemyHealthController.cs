using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{

    public int totalHealth;             //체력설정

    public void TakeDamage(int damageAmount)
    {
        totalHealth -= damageAmount;

        if(totalHealth <= 0)
        {
            totalHealth = 0;
            Destroy(gameObject);
            //싱글톤으로 돈을 올려주는 처리 함수
            //죽은 이후 처리 들을 여기서 해준다.
        }
    }  
}
