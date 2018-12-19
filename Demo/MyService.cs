﻿using System.Threading.Tasks;
using Akka.Actor;
using Demo.Actors;
using Demo.Actors.Ask;
using Demo.Actors.AtLeastOnceDelivery;
using Demo.Actors.Behavior;
using Demo.Actors.Persistence;
using Demo.Actors.Remote;

namespace Demo
{
    public class MyService
    {
        public void Start()
        {
            // Show how to use a task to get results from multiple actors
            // Demo 

            //BehaviorDemo.Start();

            //FutureDemo.Start();

            //AtLeastOnceDeliveryDemo.Start();

            //PersistenceDemo.Start();

            RemoteDemo.Start();
        }

        public Task TerminationHandle => SystemActors.System.WhenTerminated;

        public async Task StopAsync()
        {
            await CoordinatedShutdown.Get(SystemActors.System).Run();
        }
    }
}
