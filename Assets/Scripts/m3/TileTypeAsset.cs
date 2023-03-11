using UnityEngine;

namespace match3
{
    [CreateAssetMenu(menuName = "Resources/Items")]
    public sealed class TileTypeAsset : ScriptableObject
    {
        public int id;

        public int value;

        public Sprite sprite;
    }
}