using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;

namespace ReactNativeOpenExeModule
{
    [ReactModule("ReactNativeOpenExeModule")]
    internal sealed class ReactNativeModule
    {
        private ReactContext _reactContext;

        [ReactConstant]
        public string variable = "Olá Mundo em CS";

        [ReactInitializer]
        public void Initialize(ReactContext reactContext)
        {
            _reactContext = reactContext;
        }

        [ReactMethod]
        public void sampleMethod(string stringArgument, int numberArgument, Action<string> callback)
        {
            // TODO: Implement some actually useful functionality
            callback("Received numberArgument: " + numberArgument + " stringArgument: " + stringArgument);
        }

        [ReactMethod]
        public void OpenExe(string path)
        {
            Process.Start(path);
        }
    }
}
