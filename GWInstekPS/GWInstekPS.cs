using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Timers;
using System.Globalization;

namespace GWInstekPS
{
    public class GWInstekPS : IGWInstekPS
    {
        // Global Variable Declaration
         
        public const double MAX_VOLTS = 30;
        public const double MAX_AMPS = 3;
        public const int MEMORY_RANGE_LOW = 1;
        public const int TRACK_MODE_MAX = 2;
        public const string MODEL = "GW-INSTEK,PSW30-36";
        public const string COMPORT = "COM6";
        object SerialPort;
        Type mType;
        Type[] Parametertype;

        // This method is for RECEIVE MESSAGE from GWInstek PowerSupply
        // It return the string if MESSAGE is RECEIVED else return NULL
        private string getResponse(string sCmd)
        {
            try
            {
                if (sCmd == null || sCmd.Length == 0)
                    return null;
                Parametertype = new Type[] { typeof(string) };
                MethodInfo SendCmd = mType.GetMethod("SendCommand", Parametertype);
                if (SendCmd != null)
                {
                    SendCmd.Invoke(SerialPort, new object[] { sCmd });
                }
                MethodInfo Receive = mType.GetMethod("ReadData");
                if (Receive != null)
                {
                    string data = (String)Receive.Invoke(SerialPort, null);
                    return data;
                }
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Launching DLL Dynamically from specified path
        public void GetBaseLayerDLL(string sourceCodePath)
        {
            string driverPath = Path.Combine(sourceCodePath,"BaseLayer","serialDriver", "bin","Debug");
            string[] dlls = Directory.GetFiles(driverPath); string dll = null;
            dll = dlls.FirstOrDefault(s => Path.GetFileName(s).EndsWith("serialDriver.dll"));
            Assembly loadDll = Assembly.LoadFrom(dll);
            Type[] types = loadDll.GetTypes();
            foreach(Type type in types)
            {
                if(type.IsClass && type.IsPublic)
                {
                    SerialPort = Activator.CreateInstance(type);
                    mType = type;
                }
            }
        }    

        // Method to make Connection to the GWInstek PowerSupply 
        public void Connect(string port, int baud)
        {
            try{
                MethodInfo ConnectMethod = mType.GetMethod("Connect");
                if(ConnectMethod != null)
                {
                    ConnectMethod.Invoke(SerialPort,new object[] {port, baud});
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Method to disconnect the connection from GWInstek PowerSupply
        public void DisConnect()
        {
            try{
                MethodInfo DisconnectMethod = mType.GetMethod("Disconnect");
                if(DisconnectMethod != null)
                {
                    DisconnectMethod.Invoke(SerialPort,null);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // DisConnect the PowerSupply and Clear the memory used by the system.
        public void Dispose()
        {
            try{
                MethodInfo DisposeMethod = mType.GetMethod("Dispose");
                if(DisposeMethod != null)
                {
                    DisposeMethod.Invoke(SerialPort,null);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Method to GetCurrent Value from the PS, it is the Current WHich is configured during instrument conf. 
        // Return Current Value else return max value if error occures
        public double GetCurrent()
        {
            try{
            double dReturn = MAX_AMPS + 1;
            string sCmd = ":CURRent:LEVel:IMMediate:AMPLitude?";
            string sCurrent = getResponse( sCmd );
            if ( sCurrent != null ) {
                if ( !double.TryParse( sCurrent, out dReturn ) ) {
                    throw new ParseValueException( "Failed to parse value for set current" );
                }
            }
            return dReturn;
            }
            catch(Exception e){
                throw e;
            }
        }

        // Method to GetVoltage Value from the PS, it is the Voltage Which is configured during instrument conf. 
        // Return Voltage Value else return max value if error occures
        public double GetVoltage()
        {
            try{
            double dReturn = MAX_VOLTS + 1;
            string  sCmd = ":VOLTage:LEVel:IMMediate:AMPLitude?";
            string sVoltage = getResponse( sCmd );
            if ( sVoltage != null ) {
                // sVoltage = sVoltage.Substring( 0, sVoltage.Length-1 - DATA_OFFSET_END );
                if ( !double.TryParse( sVoltage, out dReturn ) ) {
                    throw new ParseValueException( "Failed to parse value for set voltage" );
                }
            }

            return dReturn;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Method to Configure Current
        // return true if current set else return false
        public bool SetCurrent(double Current)
        {
            if ( Current <= 0 || Current > MAX_AMPS ) 
            {
                Console.WriteLine( "Maximum current cannot be less than/equal to 0 or greater than 3A" );
                return false;
            }
            else if(IsConnected)
            {
                string sCmd = ":CURRent:LEVel:IMMediate:AMPLitude "+Current;
                setParameter(sCmd);               
                    if (Current == GetCurrent()) 
                    {
                        return true;
                    } 
                   
            }
            return false;
            
        }


        // Method to Configure Voltage
        // return true if volage is set, else return false
        public bool SetVoltage(double Voltage)
        {
            if (Voltage <= 0 || Voltage > MAX_VOLTS)
            {
                Console.WriteLine("Voltage cannot be less than/equal to 0 or greater than 30V");
                return false;
            }
            else if (IsConnected)
            {
                string sCmd = ":VOLTage:LEVel:IMMediate:AMPLitude " + Voltage;
                setParameter(sCmd);
                if (Voltage == GetVoltage())
                {
                    return true;
                }

            }
            return false;
        }

        // Property to Check the system is Connected or not
        // return true if connected else return false
        public bool IsConnected
        {
            get
            {
                try
                {
                    PropertyInfo isconnected = mType.GetProperty("IsConnected");
                    object value = isconnected.GetValue(SerialPort);
                    return (bool)value;
                }
                catch(Exception e)
                {
                    return false;
                }
            }
        }


        // Helping Method to Set the Current, Voltage, OCP, OVP
        // return true if given parameter are set properly
        public bool setParameter(string sCmd)
        {
            try
            {
                Parametertype = new Type[]{typeof(string)};
                MethodInfo SetParameterMethod = mType.GetMethod("SendCommand",Parametertype);
                if(SetParameterMethod != null)
                {
                    SetParameterMethod.Invoke(SerialPort,new object[]{sCmd});
                    System.Threading.Thread.Sleep(10);
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
                throw e;
            }
            return false;
        }

          
        // Method to measure the actual current consuming by load
        // return actual current consuming by load
        public double GetCurrentReading()
        {
            try
            {
                double dReturn = MAX_AMPS + 1;
                string sCmd = ":MEASure:CURRent?";
                string sCurrent = getResponse(sCmd);
                if(sCurrent != null)
                {
                    if(!double.TryParse(sCurrent, out dReturn))
                    {
                        throw new ParseValueException("Parsing Exception");
                    }
                }
                return dReturn;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Method to measure the actual voltage delevering to load
        // return actual voltage given to load
        public double GetVoltageReading()
        {
            try
            {
                double dReturn = MAX_VOLTS + 1;
                string sCmd = "MEASure:VOLTage?";
                string sVoltage = getResponse(sCmd);
                if(sVoltage != null)
                {
                    if(!double.TryParse(sVoltage, out dReturn))
                    {
                        throw new ParseValueException("Parsing Exception");
                    }
                }
                return dReturn;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Method to toggle  The Output to Enabled state
        public void OutputEnable()
        {
            string sCmd = ":OUTPut ON";
            setParameter(sCmd);  
        }

        // Method to check the output status
        // return true if Output is enabled else return false
        public bool OutputStatus()
        {
            string sCmd = ":OUTPut?";
            int op_status = int.Parse(getResponse(sCmd));
            if(op_status==1)
                return true;
            return false;
        }

        // Method to toggle  The Output to Disabled state
        public void OutputDisable()
        {
            string sCmd = ":OUTPut OFF";
            setParameter(sCmd);             
        }
        
        // Method to set the Over Current Protection Value
        // return true if Over Current is configured, else return false
        public bool SetOverCurrentProtection(double Current)
        {
            string sCmd = ":CURRent:PROTection:LEVel " + Current;
            if (setParameter(sCmd))
                return true;
            return false;
        }

        // Method to set the Over Voltage Protection Value
        // return true if Over Voltage is configured, else return false
        public bool SetOverVoltageProtection(double Voltage)
        {
            string sCmd = ":VOLTage:PROTection:LEVel " + Voltage;
            if (setParameter(sCmd))
                return true;
            return false;
        }

        // Method to read the Over Current Protection which is configure to PS
        // return the current value which is confi. in the PS
        public double GetOverCurrentProtection()
        {
            string sCmd = ":CURRent:PROTection:LEVel?";
            string sCurrent = getResponse(sCmd);
            double dReturn = MAX_AMPS + 1;
            if (sCurrent != null)
            {
                if (!double.TryParse(sCurrent, out dReturn))
                {
                    throw new ParseValueException("Parsing Exception");
                }
            }
            return dReturn;
        }

        // Method to read the Over Voltage Protection which is configure to PS
        // return the current value which is confi. in the PS
        public double GetOverVoltageProtection()
        {         
            string sCmd = ":VOLTage:PROTection:LEVel?";
            string sVoltage = getResponse(sCmd);
            double dReturn = MAX_VOLTS + 1;
            if (sVoltage != null)
            {
                if (!double.TryParse(sVoltage, out dReturn))
                {
                    throw new ParseValueException("Parsing Exception");
                }
            }
            return dReturn;
   
        }
        
        //  Exception Handling mechanism
        public class NoSupplyException : Exception
        {
            public NoSupplyException(){}
            public NoSupplyException(string message): base(message){}
            public NoSupplyException(string message, Exception inner):base(message, inner){}
            protected NoSupplyException(
               System.Runtime.Serialization.SerializationInfo info,
               System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
        }

        //  Exception Handling mechanism
        public class ParseValueException : NoSupplyException
        {
            public ParseValueException(){}
            public ParseValueException(string message) : base(message){}
            public ParseValueException(string message, Exception inner): base(message, inner){}
            protected ParseValueException(
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context)
            : base(info, context){}
        }
    }
}