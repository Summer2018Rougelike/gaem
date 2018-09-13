using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using character;

public class CombatMenu : MonoBehaviour {

    public GameObject gameManager;

    public void Attack()

    {
        GameObject created = gameObject.GetComponent<CharacterManager>().createEnemy(BaseCharacter.Type.WARRIOR, "Test Enemy Wilson");

    }

    public void Defend()

    {
        GameObject created = gameObject.GetComponent<CharacterManager>().createPlayer(BaseCharacter.Type.MAGE, "Test Player Character");

    }

    public void EndTurn()
    {
        gameManager.GetComponent<TurnManager>().changeTurn();
    }
}
