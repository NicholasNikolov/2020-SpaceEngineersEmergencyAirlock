public Program()

{
   Runtime.UpdateFrequency = UpdateFrequency.Update100;

}




public void Main(string argument, UpdateType updateSource)

{

   // List of Air vents
   var vents = new List<IMyTerminalBlock>();
   GridTerminalSystem.GetBlocksOfType<IMyAirVent>(vents);
   List<IMyAirVent> airVents = new List<IMyAirVent>();
   airVents = vents.ConvertAll(x=>(IMyAirVent)x);

   var door = new List<IMyTerminalBlock>();
   GridTerminalSystem.GetBlocksOfType<IMyDoor>(door);
   List<IMyDoor> doors = new List<IMyDoor>();
   doors = door.ConvertAll(x=>(IMyDoor)x);

   var light = new List<IMyTerminalBlock>();
   GridTerminalSystem.GetBlocksOfType<IMyInteriorLight>(light);
   List<IMyInteriorLight> lights = new List<IMyInteriorLight>();
   lights = light.ConvertAll(x=>(IMyInteriorLight)x);
   

   var PrgRoomDoor = (IMyDoor)GridTerminalSystem.GetBlockWithName("PrgRoomDoor");
   var alarm = (IMySoundBlock)GridTerminalSystem.GetBlockWithName("Alarm");
   int CompromisedRoomCount = vents.Count;

   for(int v = 0; v<airVents.Count; v++)
   {
       if(airVents[v].CanPressurize==false)
       {
           CompromisedRoomCount++;
           for (int d=0; d<doors.Count; d++)
           {
               if (doors[d].CustomName == airVents[v].CustomName )
               {
                   doors[d].GetActionWithName("Open_Off").Apply(doors[d]);
                   
               }
           }
         }
       else
       {
           CompromisedRoomCount--;
       }
         

       }
   if(CompromisedRoomCount==0)
   {
       alarm.GetActionWithName("OnOff_Off").Apply(alarm);
   }

   else
   {
       alarm.GetActionWithName("OnOff_On").Apply(alarm);
   }

   float blinkInterval = 0.9f;
   float blinkLength = 50f;   
   float normalInterval = 0f;
   float normalLength = 0f;
   Color WarnColor = new Color(256,0,0);
   Color NormalColor = new Color (256,256,256);

   for(int v2 = 0; v2<airVents.Count; v2++)
   {
       if(airVents[v2].CanPressurize==false)
       {
           for (int d2=0; d2<doors.Count; d2++)
           {
               for (int l=0;l<lights.Count;l++)
               {
               if (doors[d2].CustomName == airVents[v2].CustomName && lights[l].CustomName == doors[d2].CustomName )
               {
                   if(doors[d2].Status == DoorStatus.Closed)
                   {
                   doors[d2].GetActionWithName("OnOff_Off").Apply(doors[d2]);
                   lights[l].SetValue("Blink Lenght",blinkLength);
                   lights[l].SetValue("Blink Interval",blinkInterval);
                   lights[l].SetValue("Color",WarnColor);
                   
                   }
               }
               }
           }

       }

       else
       {
            for (int d2=0; d2<doors.Count; d2++)
           {
               for (int l=0;l<lights.Count;l++)
               {
               if (doors[d2].CustomName == airVents[v2].CustomName && lights[l].CustomName == doors[d2].CustomName )
               {
                   doors[d2].GetActionWithName("OnOff_On").Apply(doors[d2]);
                   lights[l].SetValue("Blink Lenght",normalLength);
                   lights[l].SetValue("Blink Interval",normalInterval);
                   lights[l].SetValue("Color",NormalColor);
               }
               }
           }
       }
         
   }

   

}