using UnityEngine;

namespace Spells {
    public abstract class SpellData : ScriptableObject {
        public GameObject Prefab;
        public string Name;
        public float Speed;
        public int BaseCost;
        public float CostMultiplier;
        public abstract void Fire(Vector2 position, Vector2 direction);

        public int GetCost(float multiplier = 1.0f) {
            return Mathf.RoundToInt(BaseCost * multiplier);
        }
    }
}