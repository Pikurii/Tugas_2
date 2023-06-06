using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int hp;
    public int hpMax;
    public int goldToGive;

    public Image hpImage;

    public void Damage() {
        hp--;
        SetHpBar();

        if (hp <= 0)Dead();
    }

    public void SetHpBar() {
        hpImage.fillAmount = (float)hp / (float)hpMax;
    }

    public void Dead(){
        EnemyManager.instance.DestroyEnemy(gameObject);
    }
}
