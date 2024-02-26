using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grimorie
{
    public static class CommandLine
    {
        public static async Task ExecuteCommandAsync(string fileName, string command)
        {
            // Create a new process
            using (Process process = new Process())
            {
                // Configure the process using StartInfo properties
                process.StartInfo.FileName = fileName; // Command prompt
                process.StartInfo.Arguments = $"/c {command}"; // Command to be executed
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true; // Do not create a window
                process.EnableRaisingEvents = true;

                // Event handlers to handle process events
                process.OutputDataReceived += (sender, e) =>
                {
                    Console.WriteLine($"Output: {e.Data}");
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    Console.WriteLine($"Error: {e.Data}");
                };

                // Start the process
                process.Start();

                // Asynchronously read the output and error streams
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // Wait asynchronously for the process to exit
                await process.WaitForExitAsync();
            }
        }
    }

    ///

    public static class ProcessExtensions
    {
        public static Task<bool> WaitForExitAsync(this Process process, int milliseconds = -1)
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(true);
            if (milliseconds >= 0)
            {
                return Task.WhenAny(tcs.Task, Task.Delay(milliseconds)).ContinueWith(t =>
                {
                    return t.Result == tcs.Task;
                });
            }
            else
            {
                return tcs.Task;
            }
        }
    }
    ///
}
