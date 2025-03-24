using System;

using Entity;

using UnityEngine;

namespace Projectile {

    public class AoEDamager : MonoBehaviour {
        private float damage;
        private float radius;

        public Action<Vector3> onHit;

        public AoEDamager Init(float damage, float radius) {
            this.damage = damage;
            this.radius = radius;
            return this;
        }

        private void OnTriggerEnter2D(Collider2D collider) {
            foreach (Collider2D hit in Physics2D.OverlapCircleAll(transform.position, radius, AssetServer.Instance.HitLayer)) {
                if (hit.TryGetComponent(out Health health)) {
                    health.Damage(damage);
                }
            }
            onHit?.Invoke(transform.position);
            Destroy(gameObject);
        }
    }
}