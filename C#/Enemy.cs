using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public struct mUnit
{
	public int enemyId;
	public int health;
	public int speed;
	public mTYPE type;
	public Equipment items;
	public pStat stats;
	public mDOMAIN domain;
	public mCLASS eClass;
	public mSEX gender;
}

public enum mSEX
{
	MALE,
	FEMALE,
	MECH
}

public enum aTYPE
{
	SINGLE,
	RANGE,
	AREA_OF_EFFECT,
	SPLASH,
	SUPPORT
}

public struct pStat
{
	public int intelligence;
	public int strength;
	public int constitution;
	public int agility;
	public int speed;
	public int charisma;
	public int wisdom;
}

public enum mSTAT
{
	INTELLIGENCE,
	STRENGTH,
	CONSTITUTION,
	AGILITY,
	SPEED,
	CHARISMA,
	WISDOM
}

public enum mTYPE
{
	HUMANOID,
	DRAGON,
	ANIMAL,
	MERFOLK,
	DEMON
}

public enum mDOMAIN
{
	/* ALL, */  // NULL to SELF                     || 0% from SELF
	FIRE,       // 2x to AIR                        || 50% from AIR
	WATER,      // 2x to FIRE                       || 50% from EARTH
	EARTH,      // 2x to SOUL                       || 50% from FIRE
	AIR,        // 2x to EARTH                      || 50% from WATER
	DARKNESS,   // 2x to LIGHT                      || 50% from VAMPIRIC
	LIGHT,      // 2x to DARKNESS, VAMPIRIC         || 50% from SOUL, BODY, MIND
	MIND,       // 2x to BODY                       || 50% from SOUL
	SOUL,       // 2x to VAMPIRIC                   || 50% from BODY
	BODY,       // 2x to MIND                       || 50% from DARKNESS
	VAMPIRIC,   // 2x to LIGHT, MIND, SOUL, BODY    || 50% from ELEMENT
	PHYSICAL,   // 2x to NONE                       || 50% from ALL			
	NONE        // 2x to NULL                       || 200% from PHYSICAL                125% ELEMENTAL resist
}

public class mCLASS
{
	public object Class;
}

public enum WARRIOR 
{                      // TEMPLATE
	WARRIOR,        // First job
	CRUSADER,       // Second job
	HANDOFGOD,      // Third job:good
	TEMPLAR         // Third job:evil
};
public enum WIZARD
{
	WIZARD,
	SCHOLAR,
	ARCHMAGE,
	LICH
};
public enum THIEF
{
	THIEF,
	BANDIT,
	ROGUE,
	OUTLAW
};
public enum HEALER
{
	HEALER,
	CLERIC,
	PRIEST,
	BLOODMASTER
};

public class Enemy
{
	public mUnit pMob;

	public Enemy(int id)
	{
		this.pMob.enemyId = id;
	}

	public Enemy(int id, int hp, int spd, Equipment equipped, pStat stat, mDOMAIN dom, mCLASS c, mSEX g)
	{
		this.pMob.enemyId = id;
		this.pMob.health = hp;
		this.pMob.speed = spd;
		this.pMob.items = equipped;
		this.pMob.stats = stat;
		this.pMob.domain = dom;
		this.pMob.eClass = c;
		this.pMob.gender = g;
	}

	public void setEnemyId(int id)
	{
		this.pMob.enemyId = id;
	}

	public int getEnemyId()
	{
		return this.pMob.enemyId;
	}

	public void setEnemyHealth(int h)
	{
		this.pMob.health = h;
	}

	public int getEnemyHealth()
	{
		return this.pMob.health;
	}

	public void setEnemySpeed(int s)
	{
		this.pMob.speed = s;
	}

	public int getEnemySpeed()
	{
		return this.pMob.speed;
	}

	public void setEnemyType(mTYPE t)
	{
		this.pMob.type = t;
	}

	public mTYPE getEnemyType()
	{
		return this.pMob.type;
	}

	public void setEnemyEquipment(Equipment e)
	{
		this.pMob.items = e;
	}

	public Equipment getEnemyEquipment()
	{
		return this.pMob.items;
	}

	public void setEnemyStats(pStat s)
	{
		this.pMob.stats = s;
	}

	public pStat getEnemyStats()
	{
		return this.pMob.stats;
	}

	public void setEnemyDomain(mDOMAIN dom)
	{
		this.pMob.domain = dom;
	}

	public mDOMAIN getEnemyDomain()
	{
		return this.pMob.domain;
	}

	public void setEnemyClass(mCLASS c)
	{
		this.pMob.eClass = c;
	}

	public mCLASS getEnemyClass()
	{
		return this.pMob.eClass;
	}

	public void setEnemyGender(mSEX g)
	{
		this.pMob.gender = g;
	}

	public mSEX getEnemyGender()
	{
		return this.pMob.gender;
	}
}