using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {

    Collider expectedCollider;

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
        //Debug.Log("SecondaryTrigger " + collider);
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider == expectedCollider)
        {
            //FindObjectOfType unity finds objects not necessarily gameobjects
            // but in the heirarchy 
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore(1);
        }
    }

}
