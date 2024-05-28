using UnityEngine;

public class Token : MonoBehaviour
{
        public enum PlayerToken
        {
                Nothing,
                PlayerOne,
                PlayerTwo
        }

        [SerializeField]
        private PlayerToken playerToken;

        [SerializeField]
        private LayerMask tokenLayerMask;

        public LayerMask TokenLayerMask => tokenLayerMask;

        public PlayerToken PlayerNumber => playerToken;
}