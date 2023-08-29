using System.Collections;
using System.Collections.Generic;

using DriverHostapp.Backend.CallbackInterface;
using DriverHostapp.Backend.Utils.ControlModes;

// STUB
// NOT YET IMPLEMENTED

namespace DriverHostapp.Backend.CallbackBT{
    public class HostappBackendBluetooth : IHostappBackend{

        public NLog.Logger? Logger = null;

        public void ListDevices(){
        }

        public List<string> GetConnectionsAsListOfStrings(){
            return new List<string>();
        }

        public void ChooseConnectionByIndex(uint index){

        }

        public void OpenConnection(){

        }

        public void SendConfiguration(){

        }

        public void SetMode(ControlMode new_mode){

        }
        public ControlMode GetMode(){
            return ControlMode.Speed;
        }

        public void SetSpeed(uint target_speed_in_mrpm){

        }
        public uint GetSpeed(){
            return 0u;
        }

        public void SetPosition(){

        }
        public uint GetPosition(){
            return 0u;
        }

        public void TurnDriverOn(){

        }

        public void TurnDriverOff(){

        }

        public bool GetOffOnState(){
            return false;
        }

        public void CloseConnection(){

        }

        public void SetLogger(NLog.Logger? Logger){
            this.Logger = Logger;
        }
    }
}
