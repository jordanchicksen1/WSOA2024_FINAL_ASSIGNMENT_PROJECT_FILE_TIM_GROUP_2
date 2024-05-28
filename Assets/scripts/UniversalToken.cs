using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalToken : MonoBehaviour
{
    [SerializeField]
    private float raycastExtent = 3.1f;
    
    public void OnTokenPlaced(Token token)
    {
        // Token placed
        /*Debug.Log($"{gameObject.name} -- Token: {token.name}");
        
        var right = Physics2D.RaycastAll(transform.position, Vector3.right, raycastExtent, layerMask);
        var left = Physics2D.RaycastAll(transform.position, Vector3.left, raycastExtent, layerMask);
        var up = Physics2D.RaycastAll(transform.position, Vector3.up, raycastExtent, layerMask);
        var down = Physics2D.RaycastAll(transform.position, Vector3.down, raycastExtent, layerMask);
        */
        var layerMask = token.TokenLayerMask;
        // 45 degress
        var diagonal = new Vector3(1, 1);
        var fortyFive = CheckForAlignedTokens(token, diagonal, layerMask);
        diagonal = new Vector3(-1, 1);
        var oneThirtyFive = CheckForAlignedTokens(token, diagonal, layerMask);
        diagonal = new Vector3(-1, -1);
        var twoTwentyFive = CheckForAlignedTokens(token, diagonal, layerMask);
        diagonal = new Vector3(1, -1);
        var threeFifteen = CheckForAlignedTokens(token, diagonal, layerMask);
    
        /*// 135 degrees
        diagonal = new Vector3(-1, 1);
        diagonal.Normalize();
        var oneThirtyFive = Physics2D.RaycastAll(transform.position, diagonal, raycastExtent, layerMask);
        
        // 225 degress
        diagonal = new Vector3(-1, -1);
        diagonal.Normalize();
        var twoTwentyFive = Physics2D.RaycastAll(transform.position, diagonal, raycastExtent, layerMask);
        
        // 315 degress
        diagonal = new Vector3(1, -1);
        diagonal.Normalize();
        var threeFifteen = Physics2D.RaycastAll(transform.position, diagonal, raycastExtent, layerMask);
        */
        
        Debug.Log($"{gameObject.name}");
        Debug.Log($"45: {fortyFive.Length}, 135: {oneThirtyFive.Length}");
        Debug.Log($"225: {twoTwentyFive.Length}, 315: {threeFifteen.Length}");
    }

    private RaycastHit2D[] CheckForAlignedTokens(Token token, Vector3 diagonal, LayerMask layerMask)
    {
        diagonal.Normalize();
        var fortyFive = Physics2D.RaycastAll(transform.position, diagonal, raycastExtent, layerMask);

        if (HasPlayerWon(token, fortyFive))
        {
            SceneResources.Instance.GameManager.PlayerWon(token);
        }

        return fortyFive;
    }

    private bool HasPlayerWon(Token token, RaycastHit2D[] raycastResults)
    {
        /*
         * 1. Correct Length
         * 2. Correct Tokens
         */

        if (raycastResults.Length < 3)
        {
            return false;
        }
        
        
        // Check which player the tokens belong to
        foreach (var raycastResult in raycastResults)
        {
            var attachedToken = raycastResult.transform.GetComponent<Token>();
            if (attachedToken.PlayerNumber == token.PlayerNumber)
            {
                continue;
            }
            return false;
        }
        return true;
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.black;
        
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * raycastExtent);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.left * raycastExtent);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.up * raycastExtent);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * raycastExtent);

        var diagonal = new Vector3(1, 1);
        diagonal.Normalize();
        Gizmos.DrawLine(transform.position, transform.position + diagonal * raycastExtent);
        
        diagonal = new Vector3(-1, 1);
        diagonal.Normalize();
        Gizmos.DrawLine(transform.position, transform.position + diagonal * raycastExtent);
        
        diagonal = new Vector3(-1, -1);
        diagonal.Normalize();
        Gizmos.DrawLine(transform.position, transform.position + diagonal * raycastExtent);
        
        diagonal = new Vector3(1, -1);
        diagonal.Normalize();
        Gizmos.DrawLine(transform.position, transform.position + diagonal * raycastExtent);
    }

}
