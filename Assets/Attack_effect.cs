using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_effect : MonoBehaviour {
    private Animator attack_effect_anim;
    public GameObject hit_box;
    private attack hit_box_collision;
    private SpriteRenderer show_effect;
    // Use this for initialization
    void Start () {
        attack_effect_anim = this.gameObject.GetComponent<Animator>();
        hit_box_collision = hit_box.GetComponent<attack>();
        show_effect = this.gameObject.GetComponent<SpriteRenderer>();
        show_effect.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (hit_box_collision.enemy_hit )
        {
            show_effect.enabled = true;
            attack_effect_anim.SetBool("effect_start",true);

        }
        else if (!hit_box_collision.enemy_hit)
        {
            show_effect.enabled = false;
            attack_effect_anim.SetBool("effect_start",false);

        }

    }
}
