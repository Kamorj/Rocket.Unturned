﻿using Rocket.API.Commands;
using Rocket.API.Eventing;
using Rocket.API.Player;
using Rocket.API.User;
using Rocket.Core.Player.Events;
using SDG.Unturned;
using UnityEngine;

namespace Rocket.Unturned.Player.Events
{
    public class UnturnedPlayerDamagedEvent : PlayerDamageEvent
    {
        public EDeathCause DeathCause { get; set; }
        public ELimb Limb { get; set; }
        public Vector3 Direction { get; set; }
        public float Times { get; set; }

        public UnturnedPlayerDamagedEvent(IPlayer player, EDeathCause deathCause, ELimb limb, IUser damageDealer, Vector3 direction, float damage, float times) : base(player, damage, damageDealer)
        {
            DeathCause = deathCause;
            Limb = limb;
            Direction = direction;
            Damage = damage;
            Times = times;
        }
        public UnturnedPlayerDamagedEvent(IPlayer player, EDeathCause deathCause, ELimb limb, IUser damageDealer, Vector3 direction, float damage, float times, bool global = true) : base(player, damage, damageDealer, global)
        {
            DeathCause = deathCause;
            Limb = limb;
            Direction = direction;
            Damage = damage;
            Times = times;
        }
        public UnturnedPlayerDamagedEvent(IPlayer player, EDeathCause deathCause, ELimb limb, IUser damageDealer, Vector3 direction, float damage, float times, EventExecutionTargetContext executionTarget = EventExecutionTargetContext.Sync, bool global = true) : base(player, damage, damageDealer, executionTarget, global)
        {
            DeathCause = deathCause;
            Limb = limb;
            Direction = direction;
            Damage = damage;
            Times = times;
        }
    }
}