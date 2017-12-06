using UnityEngine;

public class GameManager : MonoBehaviour {

	public int PlayerProjectileDamage;
	public int EnemyProjectileDamage;
	public int EnemyDamage;
	public int Gems;

	public int GetGems() {
		return Gems;
	}

	public int GetPlayerProjectileDamage() {
		return PlayerProjectileDamage;
	}

	public int GetEnemyProjectileDamage() {
		return EnemyProjectileDamage;
	}

	public int GetEnemyDamage() {
		return EnemyDamage;
	}

	public void ChangeGems(int val) {
		Gems += val;
	}
}
