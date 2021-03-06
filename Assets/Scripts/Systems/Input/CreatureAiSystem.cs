﻿using Entitas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Systems.Input
{
    class CreatureAiSystem : IExecuteSystem
    {
        private IGroup<GameEntity> _identifiableCreatures;
        private GameContext _context;



        public CreatureAiSystem(Contexts contexts)
        {
            _identifiableCreatures = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.EnemyAi, GameMatcher.MoveSpeed, GameMatcher.View));
            _context = contexts.game;
        }

        public void Execute()
        {
            foreach (var entity in _identifiableCreatures)
            {
                Vector3 pos = entity.view.Value.transform.position;
                if (Vector3.Distance(entity.point.Value,pos) <= 0.1)
                {
                    entity.point.Value = entity.enemyAi.path[entity.enemyAi.index].transform.position;
                    if(entity.enemyAi.index < entity.enemyAi.path.Length)
                    {
                        entity.enemyAi.index++;
                    }

                    if (entity.enemyAi.path.Length == entity.enemyAi.index)
                    {
                        entity.isPlayerDamage = true;
                    }
                }
            }
        }
    }
}
