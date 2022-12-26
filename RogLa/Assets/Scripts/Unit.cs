using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Unit : MonoBehaviour
{
    public enum atkType {Physic, Magic, Pierce, }

    public struct stat
    {
        public int atk;                 // 공격력
        public int def;                 // 방어력
        public float moveSpd;           // 이동속도
        public int maxHp;               // 최대체력
        public float atkSpd;            // 공격속도
        public float critRate;          // 치명타확률
        public float critDmg;           // 치명타피해
        public float CDRate;            // 쿨타임 감소

        public stat(int atk, int def,
                    float moveSpd, int maxHp, float atkSpd, 
                    float critRate, float critDmg, float CDRate){
            this.atk = atk;
            this.def = def;
            this.moveSpd = moveSpd;
            this.maxHp = maxHp;
            this.atkSpd = atkSpd;
            this.critRate = critRate;
            this.critDmg = critDmg;
            this.CDRate = CDRate;
        }

    }

    // stats
    private int curHp;
    private float curMovSpd;



    public void takeDamage(atkType type, int damage){
        int finalDamage = 0;

        // actual Damage calculation(finalDamage)
        switch(type){
            case atkType.Magic:
                break;
            case atkType.Physic:
                break;
            case atkType.Pierce:
                break;
            default:
                print("Error : attack Type undefined (in takeDamage() in RogLa)");
                break;
        }

        // hp adjust
        curHp -= finalDamage;
        
        // healthCheck
        if(curHp <= 0){
            destroyed();
        }

    }


    public abstract void destroyed();


    public void Init(){
        stat myStat = new stat(1,1,1,1,1,1,1,1);
    }
}
