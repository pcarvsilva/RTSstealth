using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaitAgentReachDestination : CustomYieldInstruction {

         public NavMeshAgent _agent;

        public override bool keepWaiting
        {
            get
            {
                return _agent.remainingDistance > _agent.stoppingDistance;
            }
        }

        public WaitAgentReachDestination(NavMeshAgent agent)
        {
            _agent = agent;
        }
}
