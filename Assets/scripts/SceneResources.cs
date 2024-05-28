using System;
using UnityEngine;

public class SceneResources : MonoBehaviour
{
        private static SceneResources instance;
        public static SceneResources Instance => instance;

        [SerializeField]
        private gameManager gameManager;
        public gameManager GameManager => gameManager;

        private void Awake()
        {
                if (instance == null)
                {
                        instance = this;
                }
                else if (instance != null) 
                {
                        Destroy(gameObject);
                }
        }

}