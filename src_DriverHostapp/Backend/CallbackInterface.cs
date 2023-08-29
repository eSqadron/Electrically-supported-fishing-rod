using System.Collections;
using System.Collections.Generic;
using DriverHostapp.Backend.Utils.ControlModes;

namespace DriverHostapp.Backend.CallbackInterface{
    public interface IHostappBackend{
        void ListDevices();

        List<string> GetConnectionsAsListOfStrings();
        void ChooseConnectionByIndex(uint index);

        void OpenConnection();

        void SendConfiguration();

        void SetMode(ControlMode new_mode);
        ControlMode GetMode();

        void SetSpeed(uint target_speed_in_mrpm);
        uint GetSpeed();

        void SetPosition();
        uint GetPosition();

        void TurnDriverOn();
        void TurnDriverOff();

        bool GetOffOnState();

        void CloseConnection();

        void SetLogger(NLog.Logger? Logger);
    }
}
