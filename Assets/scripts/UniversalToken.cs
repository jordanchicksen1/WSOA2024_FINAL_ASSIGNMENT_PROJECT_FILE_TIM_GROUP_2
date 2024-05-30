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
