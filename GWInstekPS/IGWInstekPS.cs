using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWInstekPS
{
    interface IGWInstekPS
    {
        void Connect(string port,int baud);
        bool IsConnected { get; }
        bool SetCurrent(double CurrentValue);
        bool SetVoltage(double VoltageValue);
        double GetCurrent();
        double GetVoltage();
        double GetCurrentReading();
        double GetVoltageReading();
        void OutputEnable();
        void OutputDisable();
        bool OutputStatus();
        bool SetOverVoltageProtection(double voltage);
        bool SetOverCurrentProtection(double curent);
        double GetOverVoltageProtection();
        double GetOverCurrentProtection();
    }
}
