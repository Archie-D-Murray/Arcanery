using Entity;

using UnityEngine;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Projectile {

    public enum Element { Ice, Fire, Wood, Stone }

    public class IceDamage : MonoBehaviour {
        private float damage;

        public void Init(float damage) {
            this.damage = damage;
        }

        private void OnTriggerEnter2D(Collider2D collider) {
            if (collider.TryGetComponent(out Health health)) {
                health.Damage(damage, transform.position);
            }
            Destroy(gameObject);
        }
    }
}