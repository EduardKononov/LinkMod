﻿using EntityStates;
using RoR2;
using RoR2.Projectile;
using UnityEngine;
using EntityStates;

namespace LinkMod.SkillStates
{
    public class Shoot : SkillStates.BaseStates.LinkMain
    {
        public static float damageCoefficient = 1;
        public static float procCoefficient = 1f;
        public static float baseDuration = 1.5f;
        public static float force = 30f;
        public static float recoil = 3f;
        public static float range = 256f;
        public static GameObject tracerEffectPrefab = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Effects/Tracers/TracerGoldGat");
        public static GameObject projectilePrefab;

        private float duration;
        private float fireTime;
        private float arrowSpeed;
        private float timer;
        private bool hasFired;
        private string muzzleString;

        public override void OnEnter()
        {
            base.OnEnter();
            this.duration = Shoot.baseDuration;
            this.fireTime = 0.2f * this.duration;
            base.characterBody.SetAimTimer(1000000f);
            this.muzzleString = "Muzzle";
            this.timer = 0f;            
            this.arrowSpeed = 30f;
            string[] sounds = { "Bow_Draw0", "Bow_Draw1", "Bow_Draw2", "Bow_Draw3", "Bow_Draw4", "Bow_Draw5" };
            Util.PlaySound(sounds[Random.Range(0, 5)], base.gameObject);
            // Too annoying
            // Util.PlaySound("BombArrow_Charge", base.gameObject);
            base.PlayAnimation("Gesture, Override", "BowDraw", "ShootGun.playbackRate", 1.8f);
        }

        public override void OnExit()
        {
            base.OnExit();
            base.characterBody.SetAimTimer(1f);
            if (!this.hasFired)
            {
                this.hasFired = true;

                base.characterBody.AddSpreadBloom(1.5f);
                EffectManager.SimpleMuzzleFlash(EntityStates.Commando.CommandoWeapon.FirePistol2.muzzleEffectPrefab, base.gameObject, this.muzzleString, false);
                string[] sounds = { "Bow_Release1", "Bow_Release2", "Bow_Release3", "Bow_Release5" };
                Util.PlaySound(sounds[Random.Range(0,3)], base.gameObject);
                base.PlayAnimation("Gesture, Override", "BowShoot", "ShootGun.playbackRate", 1.8f);

                if (base.isAuthority)
                {
                    Ray aimRay = base.GetAimRay();                    
                    ProjectileManager.instance.FireProjectile(Modules.Projectiles.bombArrowPrefab,
                        aimRay.origin,
                        Util.QuaternionSafeLookRotation(aimRay.direction),
                        base.gameObject,
                        Shoot.damageCoefficient * this.damageStat,
                        1500f,
                        base.RollCrit(),
                        DamageColorIndex.Default,
                        null,
                        this.arrowSpeed);
                }

            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            this.timer += Time.fixedDeltaTime;
            
            if (base.inputBank.skill2.down) 
            {
                if (base.fixedAge <= this.duration && base.isAuthority) //The longer the skill is held down, the more damage and force the arrow has
                {                    
                    this.arrowSpeed += (this.timer * 5f);
                }
                this.characterBody.AddTimedBuffAuthority(RoR2Content.Buffs.Slow80.buffIndex, 0.1f);                
            }          
            //if(this.timer % 1f == 0)
            //{
            //    Util.PlaySound("BombArrow_Charge", base.gameObject);
            //}
            
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }
    }
}