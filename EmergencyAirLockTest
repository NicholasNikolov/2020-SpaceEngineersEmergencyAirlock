

public void Main(string argument, UpdateType updateSource)

{

 var PrgRoomVent = (IMyAirVent)GridTerminalSystem.GetBlockWithName("PrgRoomVent");
   var PrgRoomDoor = (IMyDoor)GridTerminalSystem.GetBlockWithName("PrgRoomDoor");
   var PrgRoomLight = (IMyLightingBlock)GridTerminalSystem.GetBlockWithName("PrgRoomWarnLight");
   Color WarnColor = new Color(256,0,0);
   float blinkInterval = 0.9f;
   float blinkLength = 50f;
  
   if (PrgRoomVent.CanPressurize == false){
       PrgRoomVent.GetActionWithName("OnOff").Apply(PrgRoomVent);
       PrgRoomDoor.GetActionWithName("Open_Off").Apply(PrgRoomDoor);
       PrgRoomLight.SetValue("Color",WarnColor);
       PrgRoomLight.SetValue("Blink Lenght",blinkLength);
       PrgRoomLight.SetValue("Blink Interval",blinkInterval);
   }

   Rm1Emergency();

   

}


public void Rm1Emergency()
{
   var Rm1Vent = (IMyAirVent)GridTerminalSystem.GetBlockWithName("Rm1Vent");
   var Rm1Door = (IMyDoor)GridTerminalSystem.GetBlockWithName("Rm1Door");
   var Rm1Light = (IMyLightingBlock)GridTerminalSystem.GetBlockWithName("Rm1WarnLight");
   Color WarnColor = new Color(256,0,0);
   float blinkInterval = 0.9f;
   float blinkLength = 50f;

   if (Rm1Vent.CanPressurize == false)
   {
       Rm1Vent.GetActionWithName("OnOff").Apply(Rm1Vent);
       Rm1Door.GetActionWithName("Open_Off").Apply(Rm1Door);
       Rm1Light.SetValue("Color",WarnColor);
       Rm1Light.SetValue("Blink Lenght",blinkLength);
       Rm1Light.SetValue("Blink Interval",blinkInterval);
   }
}