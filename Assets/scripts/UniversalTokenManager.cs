using System.Collections.Generic;
using UnityEngine;

public class UniversalTokenManager : MonoBehaviour
{
        [SerializeField]
       
        List<UniversalToken> universalTokens;

        public void OnTokenPlaced(Token token)
        {
                foreach (var universalToken in universalTokens)
                {
                        universalToken.OnTokenPlaced(token);
                }
        }
}