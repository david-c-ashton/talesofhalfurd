using UnityEngine;
using System.Collections;

public struct mSpell
{
	public int power;
	public int mana;
	public float duration;
	public string name;
	public mDOMAIN domain;
	public aTYPE type;
	public AnimationClip anim;
}

public class Spell
{
	public mSpell spell;

	public void setSpellPower(int p)
	{
		this.spell.power = p;
	}

	public int getSpellPower()
	{
		return this.spell.power;
	}

	public void setSpellMana(int m)
	{
		this.spell.mana = m;
	}

	public int getSpellMana()
	{
		return this.spell.mana;
	}

	public void setSpellDuration(float dur)
	{
		this.spell.duration = dur;
	}

	public float getSpellDuration()
	{
		return this.spell.duration;
	}

	public void setSpellName(string n)
	{
		this.spell.name = n;
	}

	public string getSpellName()
	{
		return this.spell.name;
	}

	public void setSpellDomain(mDOMAIN dom)
	{
		this.spell.domain = dom;
	}

	public mDOMAIN getSpellDomain()
	{
		return this.spell.domain;
	}

	public void setSpellType(aTYPE t)
	{
		this.spell.type = t;
	}

	public aTYPE getSpellType()
	{
		return this.spell.type;
	}

	public void debug()
	{
		Debug.Log (this.spell.power.ToString ());
		Debug.Log (this.spell.mana.ToString ());
		Debug.Log (this.spell.duration.ToString ());
		Debug.Log (this.spell.name);
		Debug.Log (this.spell.domain.ToString());
		Debug.Log (this.spell.type.ToString ());
	}
}