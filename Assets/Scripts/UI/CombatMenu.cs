using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using character;

public class CombatMenu : MonoBehaviour {

    public GameObject gameManager;

    public void Attack()

    {
        GameManager.Instance.getEnemy().GetComponent<CharacterHolder>().getCharacter().receiveDamage(
        GameManager.Instance.getAttackingPlayer().GetComponent<CharacterHolder>().getCharacter().dmg
    );
        if (GameManager.Instance.getEnemy().GetComponent<CharacterHolder>().getCharacter().hp <= 0) {
            GameObject.Destroy(GameManager.Instance.getEnemy());
        }

    }

    public void Defend()

    {

    }

    public void EndTurn()
    {
        gameManager.GetComponent<TurnManager>().changeTurn();
    }
}
