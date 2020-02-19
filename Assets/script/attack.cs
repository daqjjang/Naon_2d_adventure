using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {
    public bool enemy_hit=false;
    public Vector3 hit_effect_pos;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.name);
        enemy_hit = true;
        hit_effect_pos= other.transform.position;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        enemy_hit = false;
    }
}
