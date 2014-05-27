using UnityEngine;
using System.Collections;

public struct mPlayer
{
	public string name;
	public int id;
	public Equipment inventory;
	public mSEX gender;
	public pStat stats;
	public mTYPE race;
	public mCLASS pClass;
	[HideInInspector]
	public GameObject obj;
}

public class Player
{
	public mPlayer player;

	public void setNewCharacter(string n)
	{
		this.player.name = n;
		this.player.id = 0;
		this.player.inventory = Blanks.defaultHumanEQ (0, mSEX.MALE);
		this.player.gender = mSEX.MALE;
		int[] stats = { 10, 12, 12, 10, 10, 10, 10 };

		this.player.stats = Blanks.createStats(stats);

		mCLASS c = new mCLASS ();
		c.Class = WARRIOR.WARRIOR;
		this.player.pClass = c;
	}
}