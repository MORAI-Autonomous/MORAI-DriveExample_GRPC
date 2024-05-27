using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grpc.Core;
using CoreLib.Grpc.Protobuf.MoraiSimAPI.Simulation;
using CoreLib.Grpc.Protobuf.MoraiSimAPI.Simulator;
using CoreLib.Grpc.Protobuf.MoraiSimAPI.Actor;
using System.Runtime.InteropServices;
using System.Threading;

namespace MoraiGrpcApiExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:7789", ChannelCredentials.Insecure);
            var client_sim = new Simulation.SimulationClient(channel);
            var client_actor = new Actor.ActorClient(channel);

            string client_key = "example_code";

            StartParam param = new StartParam();
            param.MapAndVehicle = new MapAndVehicle()
            { 
                MapName = "V_RHT_HighwayJunction_1",
                EgoVehicleModel = "2023_Hyundai_Ioniq5",
            };

            param.EgoSetting = new EgoSetting()
            { 
                EgoId = "Ego",
                Label = "Ego",
                ClientKey = client_key,
            };

            param.EgoTransform = new CoreLib.Grpc.Protobuf.MoraiSimAPI.Transform()
            {
                Location = new CoreLib.Grpc.Protobuf.MoraiSimAPI.Vector3()
                {
                    X = -21.29,
                    Y = 34.95,
                    Z = 4.0244,
                },
                Rotation = new CoreLib.Grpc.Protobuf.MoraiSimAPI.Vector3()
                {
                    X = 0,
                    Y = 0,
                    Z = 0,
                }
            };

            param.EgoCruiseSetting = new EgoCruiseControl()
            {
                CruiseOn = false,
                CruiseType = EgoCruiseType.Link,
                LinkSpeedRatio = 0,
                ConstantVelocity = 0,
            };

            param.Mode = new SyncMode()
            { 
                Type = SyncModeType.Unspecified,                
            };
            var ret = client_sim.Start(param);

            Console.WriteLine(ret.ToString());

            GetAllActorsFilter filter = new GetAllActorsFilter()
            {
                Obstacle = true,
                Vehicle = true,
                Pedestrian = true,
                ClientKey = client_key,
            };

            while (true)
            {
                var actors = client_actor.GetAllActorsState(filter);
                if (actors != null)
                {
                    Console.WriteLine(actors);
                    Thread.Sleep(1000);
                }
            }
            
        }
    }
}
