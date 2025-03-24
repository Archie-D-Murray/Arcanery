using UnityEngine;

using Projectile;

namespace Spells {
    public class LinearSpell : SpellData {
        public float DamageMultiplier;

        public override void Fire(Vector2 position, Vector2 direction) {
            GameObject projectile = Instantiate(Prefab);
            projectile.GetOrAddComponent<LinearProjectileMover>().Init(Speed);

        }
    }
}